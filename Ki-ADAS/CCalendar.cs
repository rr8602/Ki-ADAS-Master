using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ki_ADAS
{
	
	internal class CCalendar : UserControl
	{

		public event EventHandler<DateTime> DateSelected;

		private DateTime currentMonth;
		private TableLayoutPanel table;
		private Button btnPrev;
		private Button btnNext;
		private Label lblMonth;

		private DateTime? selectedDate = null;

		public CCalendar(Size size)
		{
			this.Size = size;
			this.currentMonth = DateTime.Today;
			this.Dock = DockStyle.Fill;

		
			// 상단 헤더: 이전/다음 버튼 + 월 표시
			Panel header = new Panel
			{
				Dock = DockStyle.Top,
				Height = 50,
				BackColor = Color.LightGray
			};

			btnPrev = new Button
			{
				Text = "<",
				Dock = DockStyle.Left,
				Width = 50,
				Font = new Font("Segoe UI", 16, FontStyle.Bold)
			};
			btnPrev.Click += (s, e) => { ShowPreviousMonth(); };

			btnNext = new Button
			{
				Text = ">",
				Dock = DockStyle.Right,
				Width = 50,
				Font = new Font("Segoe UI", 16, FontStyle.Bold)
			};
			btnNext.Click += (s, e) => { ShowNextMonth(); };

			lblMonth = new Label
			{
				TextAlign = ContentAlignment.MiddleCenter,
				Dock = DockStyle.Fill,
				Font = new Font("Segoe UI", 16, FontStyle.Bold)
			};

			header.Controls.Add(lblMonth);
			header.Controls.Add(btnPrev);
			header.Controls.Add(btnNext);
			this.Controls.Add(header);



			// TableLayoutPanel 생성 (날짜 버튼 전용)
			table = new TableLayoutPanel
			{

				Top = 60,
				Height = this.Height,
				Width = this.Width,
				

				RowCount = 7, // 최대 6주
				ColumnCount = 7,
				Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
			};
			GWA.STM("HEIGHT : " + this.Height.ToString());
			for (int i = 0; i < 7; i++)
				//table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50));
				table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, this.Width / 7));
			for (int i = 0; i < 7; i++)
				table.RowStyles.Add(new RowStyle(SizeType.Absolute, this.Height / 7));
				//table.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));

			this.Controls.Add(table);

			DrawCalendar();
		}

		private void DrawCalendar()
		{
			table.Controls.Clear();

			lblMonth.Text = currentMonth.ToString("yyyy MMMM");

			DateTime firstDay = new DateTime(currentMonth.Year, currentMonth.Month, 1);
			int startCol = (int)firstDay.DayOfWeek;
			int daysInMonth = DateTime.DaysInMonth(currentMonth.Year, currentMonth.Month);

			int row = 0;

			for (int day = 0; day < 7; day++)
			{
				int d = day;
				Button btn = new Button();
				if (row == 0)
				{
					if (day == 0) btn.Text = "일";
					if (day == 1) btn.Text = "월";
					if (day == 2) btn.Text = "화";
					if (day == 3) btn.Text = "수";
					if (day == 4) btn.Text = "목";
					if (day == 5) btn.Text = "금";
					if (day == 6) btn.Text = "토";

					btn.Font = new Font("Segoe UI", 14, FontStyle.Bold);
					btn.Dock = DockStyle.Fill;
					btn.Margin = new Padding(1);
					btn.FlatStyle = FlatStyle.Flat;
					btn.BackColor = Color.Gray;
					btn.FlatAppearance.BorderSize = 0;
					btn.ForeColor = (day == 0) ? Color.Red : (day == 6) ? Color.Blue : Color.White;

				}
				table.Controls.Add(btn, day, row);
			}

			row++;

			int col = startCol;



			for (int day = 1; day <= daysInMonth; day++)
			{
				int d = day;
				Button btn = new Button();

				{
					btn.Text = d.ToString();
					btn.Dock = DockStyle.Fill;

					btn.Font = new Font("Segoe UI", 14, FontStyle.Bold);
					btn.Margin = new Padding(1);
					btn.FlatStyle = FlatStyle.Flat;
					btn.BackColor = Color.White;
					btn.ForeColor = (col == 0) ? Color.Red : (col == 6) ? Color.Blue : Color.Black;

				}

				

				// 오늘 날짜 강조
				if (currentMonth.Year == DateTime.Today.Year &&
					currentMonth.Month == DateTime.Today.Month &&
					d == DateTime.Today.Day)
					btn.BackColor = Color.LightYellow;

				// 선택 날짜 강조
				if (selectedDate.HasValue &&
					selectedDate.Value.Year == currentMonth.Year &&
					selectedDate.Value.Month == currentMonth.Month &&
					selectedDate.Value.Day == d)
					btn.BackColor = Color.LightBlue;

				btn.Click += (s, e) =>
				{
					selectedDate = new DateTime(currentMonth.Year, currentMonth.Month, d);
					DateSelected?.Invoke(this, selectedDate.Value);
					DrawCalendar();
				};

				table.Controls.Add(btn, col, row);

				col++;
				if (col > 6)
				{
					col = 0;
					row++;
				}
			}
		}

		public void ShowPreviousMonth()
		{
			currentMonth = currentMonth.AddMonths(-1);
			DrawCalendar();
		}

		public void ShowNextMonth()
		{
			currentMonth = currentMonth.AddMonths(1);
			DrawCalendar();
		}
	}

	
}
