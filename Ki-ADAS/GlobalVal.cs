using Ki_ADAS.VEPBench;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ki_ADAS
{

	public struct NOTICE_MSG
	{
		public String Top;
		public String Body;
		public String Bottom;
	}

	public class Digital_Input
    {
        public bool bFrontDetect = false;
        public bool bRearDetect = false;
    }
    public class Digital_Output
    {
        public bool bCenterOn = false;
    }

    public class PLC
    {
        // Simulator -> ThreadADAS 신호용 변수
        public bool bTargetMove_FRCam = false;
        public bool bTargetHome_FRCam = false;
        public bool bTargetMove_FrontRadar = false;
        public bool bTargetHome_FrontRadar = false;
        public bool bTargetMove_RearRadar = false;
        public bool bTargetHome_RearRadar = false;

        Digital_Output DO = new Digital_Output();
        Digital_Input DI = new Digital_Input();
    }


    internal class GlobalVal
    {
		private static readonly Lazy<GlobalVal> _instance = new Lazy<GlobalVal>(() => new GlobalVal());
        public static GlobalVal Instance => _instance.Value;
        private GlobalVal()
        {
            _PLC = new PLC();
        }

        public VEPBenchDataManager _VEP;
        public VEPBenchClient _Client;
        public PLC _PLC;


		public MsgBroker noticeBroker = new MsgBroker();
		public IntPtr noticeHwnd = new IntPtr();


		public void InitializeVepSystem(string ip, int port)
        {
            _VEP = new VEPBenchDataManager();
            _Client = new VEPBenchClient(ip, port, _VEP);

            _Client.InitializeAndReadDescriptionZone();
        }

		public void NoticeShow(String strTop = "", String strBody = "", String strBottom = "")
		{
			//GWA.SendMessage(workerHwnd, Constants.HIDE_WINDOW, 0, 0);
			GWA.SendMessage(noticeHwnd, GWA.SHOW_WINDOW, 0, 0);
			NOTICE_MSG msg = new NOTICE_MSG();
			msg.Top = strTop;
			msg.Body = strBody;
			msg.Bottom = strBottom;
			noticeBroker.Publish("Notice", msg);

		}
		public void NoticeHide(String strTop = "", String strBody = "", String strBottom = "")
		{
			//GWA.SendMessage(workerHwnd, Constants.SHOW_WINDOW, 0, 0);
			GWA.SendMessage(noticeHwnd, GWA.HIDE_WINDOW, 0, 0);
			NOTICE_MSG msg = new NOTICE_MSG();
			msg.Top = strTop;
			msg.Body = strBody;
			msg.Bottom = strBottom;
			noticeBroker.Publish("Notice", msg);

		}

	}
}
