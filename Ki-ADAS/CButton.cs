using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KI_Controls
{
	internal class CButton : Button
	{
		private Color originalBackColor;
		private bool isPressed = false;


		private bool _bCenter = true;
		private bool _bCheck = false;

		public Color NormalBackColor { get; set; } = Color.LightGray;
		public Color NormalForeColor { get; set; } = Color.Black;

		public Color DisabledBackColor { get; set; } = Color.DarkGray;
		public Color DisabledForeColor { get; set; } = Color.Black;

		public uint BorderSize { get; set; } = 1;
		public Color BorderColor { get; set; } = Color.Black;

		public void SetCenter(bool bCenter) { _bCenter = bCenter; }
		public void SetCheck(bool bCheck)
		{
			_bCheck = bCheck;
			if (_bCheck) NormalForeColor = Color.White;
			else NormalForeColor = Color.Black;

			UpdateAppearance();
		}
		public bool GetCheck() { return _bCheck; }

		public CButton()
		{
			this.FlatStyle = FlatStyle.Flat;
			this.FlatAppearance.BorderSize = (int)BorderSize;
			this.FlatAppearance.BorderColor = BorderColor;

			this.BackColor = NormalBackColor;
			this.ForeColor = NormalForeColor;

			this.SetStyle(ControlStyles.AllPaintingInWmPaint |
			  ControlStyles.UserPaint |
			  ControlStyles.OptimizedDoubleBuffer |
			  ControlStyles.ResizeRedraw |
			  ControlStyles.SupportsTransparentBackColor, true);
			this.BackColor = Color.Transparent;
		}


		private void UpdateAppearance()
		{
			if (_bCheck)
			{
				this.BackColor = Color.Ivory;

			}
			else
			{
				this.BackColor = NormalBackColor;

			}

			originalBackColor = this.BackColor;
		}

		protected override void OnPaint(PaintEventArgs pevent)
		{
			//base.OnPaint(pevent);
			// 배경, 테두리 등은 그대로 그리되
			base.OnPaintBackground(pevent);


			Color backColor = this.Enabled ? this.BackColor : DisabledBackColor;
			Color foreColor = this.Enabled ? this.ForeColor : DisabledForeColor;

			using (SolidBrush brush = new SolidBrush(backColor))
			{
				pevent.Graphics.FillRectangle(brush, this.ClientRectangle);
			}

			using (Pen pen = new Pen(this.FlatAppearance.BorderColor, this.FlatAppearance.BorderSize))
			{
				pevent.Graphics.DrawRectangle(pen, 0, 0, this.Width - 1, this.Height - 1);
			}

			Rectangle textRect = this.ClientRectangle;
			if (isPressed && this.Enabled)
				textRect.Offset(0, 2);
			if (_bCenter)
			{
				TextRenderer.DrawText(
					pevent.Graphics,
					this.Text,
					this.Font,
					textRect,
					foreColor,
					TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
				);
			}
			else
			{
				TextRenderer.DrawText(
					pevent.Graphics,
					this.Text,
					this.Font,
					textRect,
					foreColor,
					TextFormatFlags.Left | TextFormatFlags.VerticalCenter
				);

			}



		}
		protected override void OnMouseDown(MouseEventArgs mevent)
		{
			base.OnMouseDown(mevent);
			isPressed = true;
			this.Invalidate();  // 다시 그리기 요청
		}

		protected override void OnMouseUp(MouseEventArgs mevent)
		{
			base.OnMouseUp(mevent);
			isPressed = false;
			this.Invalidate();
		}
		protected override void OnMouseEnter(EventArgs e)
		{


			{
				originalBackColor = this.BackColor;
				this.BackColor = LightenColor(this.BackColor, 0.2f); // 20% 밝게
			}
			base.OnMouseEnter(e);
		}

		protected override void OnMouseLeave(EventArgs e)
		{


			{
				this.BackColor = originalBackColor;
			}

			base.OnMouseLeave(e);
		}

		/// <summary>
		/// 지정된 색을 밝게 만듭니다.
		/// </summary>
		private Color LightenColor(Color color, float amount)
		{
			int r = (int)(color.R + (255 - color.R) * amount);
			int g = (int)(color.G + (255 - color.G) * amount);
			int b = (int)(color.B + (255 - color.B) * amount);
			return Color.FromArgb(r, g, b);
		}



	}
}
