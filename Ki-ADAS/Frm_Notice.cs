using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KI_Controls;

namespace Ki_ADAS
{
	public partial class Frm_Notice : Form
	{
		private Point mousePoint; // 현재 마우스 포인터의 좌표저장 변수 선언

		GlobalVal _GV = GlobalVal.Instance;
		private int nNoticeSecond = 0;

		[DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
		public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, UIntPtr dwExtraInfo);

		private const int MOUSEEVENTF_LEFTDOWN = 0x02;
		private const int MOUSEEVENTF_LEFTUP = 0x04;

		public Frm_Notice()
		{
			InitializeComponent();


			_GV.noticeBroker.Subscribe("Notice", UpdateControl);

			this.Activated += (s, e) => RL_LIFT_UP.Invalidate();
			this.Deactivate += (s, e) => RL_LIFT_UP.Invalidate();
		}

		private void Frm_Notice_Load(object sender, EventArgs e)
		{
			InitView();
			//var pos = this.PointToScreen(new System.Drawing.Point(this.Width / 2, this.Height / 2));
			//Cursor.Position = pos;

			// 마우스 클릭 이벤트 발생
			//mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, UIntPtr.Zero);
			//mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, UIntPtr.Zero);


		}
		private void InitView()
		{
			nNoticeSecond = 0;
			timerSecond.Enabled = false;

			btnTop.Text = "";
			btnBody.Text = "";
			btnBottom.Text = "";
			RL_LIFT_UP.Tag = true;
			timerSecond.Enabled = true;
			timerSecond.Interval = 200;

		}
		private void UpdateControl(object data)
		{

			NOTICE_MSG msg = (NOTICE_MSG) data;
			UpdateTop(msg.Top);
			UpdateBody(msg.Body);
			UpdateBottom(msg.Bottom);

		}
		private void UpdateTop(object data)
		{
			if (btnTop.InvokeRequired)
				this.btnTop.BeginInvoke((Action)(() => btnTop.Text = (String)data));
			else
				btnTop.Text = (String)data;
		}
		private void UpdateBody(object data)
		{
			if (btnBody.InvokeRequired)
				this.btnBody.BeginInvoke((Action)(() => btnBody.Text = (String)data));
			else
				btnBody.Text = (String)data;
		}

		private void UpdateBottom(object data)
		{
			if (btnBottom.InvokeRequired)
				this.btnBottom.BeginInvoke((Action)(() => btnBottom.Text = (String)data));
			else
				btnBottom.Text = (String)data;
		}

		private void Frm_Notice_FormClosing(object sender, FormClosingEventArgs e)
		{
			_GV.noticeBroker.Unsubscribe("Notice", UpdateTop);

		}



		protected override void WndProc(ref Message m)
		{
			try
			{
				if (m.Msg == GWA.SHOW_WINDOW)
				{
					this.Show();
				}
				else if (m.Msg == GWA.HIDE_WINDOW)
				{
					this.Hide();
				}
				else
				{
					base.WndProc(ref m);
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("NoticeDlg WndProc : " + ex.Message);
			}
		}

		private void timerSecond_Tick(object sender, EventArgs e)
		{
			nNoticeSecond++;
			RefreshControl();



		}

		private void RefreshControl()
		{
			
			//if (_GV.plcRead.plcReadData.IsLiftUp() == true)
			{
				bool status = (bool )RL_LIFT_UP.Tag;
				if(status == false) 
				{
					RL_LIFT_UP.Image = Properties.Resources.lamp_on;
					RL_LIFT_UP.Tag = true;
					
				}
			}
			//else
			{
				bool status = (bool)RL_LIFT_UP.Tag;
				if (status == true)
				{
					RL_LIFT_UP.Image = Properties.Resources.lamp_off;
					RL_LIFT_UP.Tag = false;
					
				}

			}
		}

		private void Frm_Notice_MouseDown(object sender, MouseEventArgs e)
		{
			mousePoint = new Point(e.X, e.Y); //현재 마우스 좌표 저장
		}

		private void Frm_Notice_MouseMove(object sender, MouseEventArgs e)
		{
			if ((e.Button & MouseButtons.Left) == MouseButtons.Left) //마우스 왼쪽 클릭 시에만 실행
			{
				//폼의 위치를 드래그중인 마우스의 좌표로 이동 
				Location = new Point(Left - (mousePoint.X - e.X), Top - (mousePoint.Y - e.Y));
			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
