using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ki_ADAS
{

	static class GWA
	{

		public struct COPYDATASTRUCT
		{
			public IntPtr dwData;
			public int cbData;
			[MarshalAs(UnmanagedType.LPStr)]
			public string lpData;
		}
		

		public const int WM_COPYDATA = 0x4A;
		public const int WM_USER = 0x0400;
		public const int COPY_MSG_DATA = WM_USER + 101;



		public const int SHOW_WINDOW = WM_USER + 9900;
		public const int HIDE_WINDOW = WM_USER + 9901;
		public const int CLOSE_WINDOW = WM_USER + 9999;



		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern bool ReleaseCapture();
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, ref COPYDATASTRUCT lParam);

		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

		[DllImport("user32")]
		public static extern IntPtr FindWindow(String lpClassName, String lpWindowName);

		[DllImport("user32.dll")]
		public static extern IntPtr FindWindowEx(IntPtr hWnd1, int Hwnd2, string lpClassName, string lpWindowName);


		[DllImport("user32.dll")]
		private static extern bool MoveWindow(IntPtr hWnd, int x, int y, uint nWidth, uint nHeight, bool bRepaint);





		public static String strName = "";

		public static void STM(String strMsg)
		{

			COPYDATASTRUCT cds;
			IntPtr hWnd = FindWindow(null, "MessageView");
			if (hWnd != IntPtr.Zero)
			{
				cds.dwData = (IntPtr)COPY_MSG_DATA;
				cds.cbData = strMsg.Length + 1;
				cds.lpData = strMsg;
				SendMessage(hWnd, WM_COPYDATA, 0, ref cds);
			}
		}
		public static void MW(IntPtr hWnd, int X, int Y, uint nWidth, uint nHeight, bool bRepaint = true)
		{
			MoveWindow(hWnd, X, Y, nWidth, nHeight, bRepaint);
		}
		//public static void SendMsg(IntPtr hWnd, uint Msg, uint wParam, uint lParam)
		//{
		//	SendMessage(hWnd, Msg, wParam, lParam);
		//}






	}
}
