using Ki_ADAS;
using Ki_ADAS.ThreadADAS;
using Ki_ADAS.VEPBench;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ki_ADAS
{
    public partial class Frm_Mainfrm : Form
    {
        private int m_nCurrentFrmIdx = Def.FOM_IDX_MAIN;

        public SettingConfigDb _db;
        private Form m_ActiveSubForm;
        public Frm_Main m_frmMain;
        public Frm_Config m_frmConfig;
        public Frm_Calibration m_frmCalibration = new Frm_Calibration();
        public Frm_Manual m_frmManual = new Frm_Manual();
        public Frm_Result m_frmResult;
        public Frm_VEP m_frmVEP;
        public Frm_Operator User_Monitor = null;
        public VEPBenchDescriptionZone _descriptionZone = null;
        private List<Button> m_NavButtons = new List<Button>();
        private BarcodeReader _barcodeReader;
        private GlobalVal gv;

        private IniFile _iniFile;
        public static string ipAddress;
        public static int port;
        private const string CONFIG_SECTION = "Network";
        private const string VEP_IP_KEY = "VepIp";
        private const string VEP_PORT = "VepPort";


		public Frm_Notice noticeDlg = null;

		public Frm_Mainfrm(SettingConfigDb dbInstance)
        {
            InitializeComponent();
            
            _db = dbInstance;

            // Read network configuration
            string iniPath = System.IO.Path.Combine(Application.StartupPath, "config.ini");
            _iniFile = new IniFile(iniPath);
            ipAddress = _iniFile.ReadValue(CONFIG_SECTION, VEP_IP_KEY);
            port = _iniFile.ReadInteger(CONFIG_SECTION, VEP_PORT);

            gv = GlobalVal.Instance;
            gv.InitializeVepSystem(ipAddress, port);

            m_frmMain = new Frm_Main(_db, gv._Client);
            m_frmConfig = new Frm_Config(_db);
            m_frmVEP = new Frm_VEP(gv._Client);
            m_frmResult = new Frm_Result(_db);
            m_frmCalibration = new Frm_Calibration();
            m_frmManual = new Frm_Manual();

			GWA.MW(this.Handle, 0, 0, 1920, 1000);
		}

        private void Frm_Mainfrm_Load(object sender, EventArgs e)
        {
            try
            {
                m_frmMain.SetParent(this);
                m_frmConfig.SetParent(this);
                m_frmCalibration.SetParent(this);
                m_frmManual.SetParent(this);
                m_frmResult.SetParent(this);
                m_frmVEP.SetParent(this);

                InitializeSubForm(m_frmMain);
                InitializeSubForm(m_frmConfig);
                InitializeSubForm(m_frmCalibration);
                InitializeSubForm(m_frmManual);
                InitializeSubForm(m_frmResult);
                InitializeSubForm(m_frmVEP);

                m_NavButtons.Add(BtnCalibration);
                m_NavButtons.Add(BtnConfig);
                m_NavButtons.Add(BtnCalibration);
                m_NavButtons.Add(BtnManual);
                m_NavButtons.Add(BtnResult);
                m_NavButtons.Add(BtnVEP);

                ShowFrm(Def.FOM_IDX_MAIN);




                if (!this.DesignMode)
                {
                    if (User_Monitor == null || User_Monitor.Text == "")
                    {


						int WorkerViewWidth = 1920;
						int WorkerViewHeight = 990;


						User_Monitor = new Frm_Operator(m_frmMain);

						User_Monitor.StartPosition = FormStartPosition.Manual;
						User_Monitor.Location = new Point(1920, 0);

						User_Monitor.Width = WorkerViewWidth;
						User_Monitor.Height = WorkerViewHeight;
						User_Monitor.Show();


						
                    }
                }
                
                StartBarcode();


				SetDeviceStatus(1, 2);
				SetDeviceStatus(2, 2);
				SetDeviceStatus(3, 5);
				
				CreateNoticeDlg();
				gv.NoticeShow("Ready", "Scan Barcod", "");
				//gv.NoticeHide("","","");

			}
            catch (Exception ex)
            {
                MsgBox.ErrorWithFormat("ErrorLoadingMainFormFrame", "Error", ex.Message);
            }
        }
        
        private void Frm_Mainfrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                _barcodeReader?.Disconnect();
            }
            catch (Exception ex)
            {
                MsgBox.ErrorWithFormat("ErrorDisconnectingBarcodeReader", "Error", ex.Message);
            }
        }

        private void Frm_Mainfrm_Resize(object sender, EventArgs e)
        {
            RepositionSubForm(this.ActiveSubForm);
        }
		private void CreateNoticeDlg()
		{
			noticeDlg = new Frm_Notice();
			noticeDlg.StartPosition = FormStartPosition.Manual;
			noticeDlg.Location = new Point(1920, 0);
			int WorkerViewWidth = 1920;
			int WorkerViewHeight = 990;

			noticeDlg.Width = WorkerViewWidth;
			noticeDlg.Height = WorkerViewHeight;
			noticeDlg.Show();

			gv.noticeHwnd = noticeDlg.Handle;
		}
		private void StartBarcode()
        {
            try
            {
                _barcodeReader = new BarcodeReader(Frm_Main.barcodeIp);
                _barcodeReader.OnBarcodeReceived += BarcodeReceivedHandler;
                _barcodeReader.OnError += BarcodeReader_OnError;
                _barcodeReader.ConnectBarcodeReader();
            }
            catch (Exception ex)
            {
                MsgBox.ErrorWithFormat("ErrorConnectingBarcodeReader", "Error", ex.Message);
            }
        }

        private void BarcodeReader_OnError(object sender, Exception e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => MsgBox.ErrorWithFormat("ErrorInBarcodeReadLoop", "Error", e.Message)));
            }
            else
            {
                MsgBox.ErrorWithFormat("ErrorInBarcodeReadLoop", "Error", e.Message);
            }
        }

        private void BarcodeReceivedHandler(object sender, BarcodeReader.BarcodeEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => ProcessBarcode(e.BarcodeData)));
            }
            else
            {
                ProcessBarcode(e.BarcodeData);
            }
        }

        private void ProcessBarcode(string barcodeData)
        {
            if (m_frmMain != null && !m_frmMain.IsDisposed)
            {
                m_frmMain.SetBarcodeData(barcodeData);
            }
        }

        private void InitializeSubForm(Form f)
        {
			int SubViewWidth = 1850 - 100;
			int SubViewHeight = 700 - 50;
			
			try
            {


				f.TopLevel = false;
                f.ControlBox = false;
                f.FormBorderStyle = FormBorderStyle.None;
                f.StartPosition = FormStartPosition.Manual;
				this.Controls.Add(f);
				f.Parent = this;
				//f.MdiParent = this;
				f.Location = new Point(200, 20);
				f.Width = SubViewWidth;
				f.Height = SubViewHeight;
				//GWA.MW(f.Handle, 120, 20, (uint)SubViewWidth, (uint)SubViewHeight);


			}
            catch (Exception ex)
            {
                MsgBox.ErrorWithFormat("ErrorInitializingSubForm", "Error", ex.Message);
            }
        }

        private void RepositionSubForm(Form fSubform)
        {
            try
            {
                if (fSubform == null)
                    return;



				fSubform.Location = new Point(93, 2);
                fSubform.Size = new Size(ClientSize.Width - panelNavBar.Size.Width - 4, ClientSize.Height - 50-4);
            }
            catch (Exception ex)
            {
                MsgBox.ErrorWithFormat("ErrorRepositioningSubForm", "Error", ex.Message);
            }
        }

        public Form ActiveSubForm
        {
            get
            {
                return m_ActiveSubForm;
            }
            set
            {
                m_ActiveSubForm = value;
                if (m_ActiveSubForm == null)
                    return;

                RepositionSubForm(m_ActiveSubForm);
            }
        }

        private void ShowFrm(int nIdx)
        {
            try
            {
                m_nCurrentFrmIdx = nIdx;
                Form f = new Form();

				switch (nIdx)
                {
                    case Def.FOM_IDX_MAIN:
                        f = m_frmMain;
                        break;
                    case Def.FOM_IDX_CONFIG:
                        f = m_frmConfig;
                        break;
                    case Def.FOM_IDX_CALIBRATION:
                        f = m_frmCalibration;
                        break;
                    case Def.FOM_IDX_MANUAL:
                        f = m_frmManual;
                        break;
                    case Def.FOM_IDX_RESULT:
                        f = m_frmResult;
                        break;
                    case Def.FOM_IDX_VEP:
                        f = m_frmVEP;
                        break;
                }
				
				f.Show();
				f.BringToFront();
				ActiveSubForm = f;
            }
            catch (Exception ex)
            {
                MsgBox.ErrorWithFormat("ErrorShowingForm", "Error", ex.Message);
            }
        }

        private void ChangeButtonColor(Button pButton)
        {
            try
            {
                foreach (Button btn in m_NavButtons)
                {
                    if (pButton.Text == btn.Text)
                    {
                        btn.BackColor = Color.Gray;
                        btn.ForeColor = SystemColors.ControlLightLight;
                    }
                    else
                    {
                        btn.BackColor = Color.Gainsboro;
                        btn.ForeColor = Color.Black;
                    }
                }
            }
            catch (Exception ex)
            {
                MsgBox.ErrorWithFormat("ErrorChangingButtonColor", "Error", ex.Message);
            }
        }

        private void BtnMain_Click(object sender, EventArgs e)
        {
            try
            {
                ChangeButtonColor((Button)sender);
                ShowFrm(Def.FOM_IDX_MAIN);
				
			}
            catch (Exception ex)
            {
                MsgBox.ErrorWithFormat("ErrorMainButtonClick", "Error", ex.Message);
            }
        }

        private void BtnConfig_Click(object sender, EventArgs e)
        {
            try
            {
                ChangeButtonColor((Button)sender);
                ShowFrm(Def.FOM_IDX_CONFIG);
            }
            catch (Exception ex)
            {
                MsgBox.ErrorWithFormat("ErrorConfigButtonClick", "Error", ex.Message);
            }
        }

        private void btnCalibration_Click(object sender, EventArgs e)
        {
            try
            {
                ChangeButtonColor((Button)sender);
                ShowFrm(Def.FOM_IDX_CALIBRATION);
            }
            catch (Exception ex)
            {
                MsgBox.ErrorWithFormat("ErrorCalibrationButtonClick", "Error", ex.Message);
            }
        }

        private void BtnManual_Click_1(object sender, EventArgs e)
        {
            try
            {
                ChangeButtonColor((Button)sender);
                ShowFrm(Def.FOM_IDX_MANUAL);
            }
            catch (Exception ex)
            {
                MsgBox.ErrorWithFormat("ErrorManualButtonClick", "Error", ex.Message);
            }
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            try
            {
                ChangeButtonColor((Button)sender);
                ShowFrm(Def.FOM_IDX_RESULT);
            }
            catch (Exception ex)
            {
                MsgBox.ErrorWithFormat("ErrorResultButtonClick", "Error", ex.Message);
            }
        }

        private void BtnVEP_Click(object sender, EventArgs e)
        {
            try
            {
                ChangeButtonColor((Button)sender);
                ShowFrm(Def.FOM_IDX_VEP);
            }
            catch (Exception ex)
            {
                MsgBox.ErrorWithFormat("ErrorVEPButtonClick", "Error", ex.Message);
            }
        }

		private void BtnParameter_Click(object sender, EventArgs e)
		{

		}

		private void SetDeviceStatus(int nDevice, int nStatus)
		{

			int D_CONNECTED = 1;
			int D_RUN = 2;
			int D_NOT_CONNECTED = 5;
			int PLC = 1;
			int VEP = 2;
			int BARCODE = 3;



		Color backColor = Color.Purple;
			if (nStatus == D_CONNECTED) backColor = Color.DarkGreen;
			if (nStatus == D_RUN) backColor = Color.LightSeaGreen;
			if (nStatus == D_NOT_CONNECTED) backColor = Color.OrangeRed;

			if (nDevice == PLC)
			{
				BTN_PLC.BackColor = backColor;
				BTN_PLC.BackgroundColor = backColor;
				BTN_PLC.BorderColor = backColor;
				BTN_PLC.Invalidate();
			}
			if (nDevice == VEP)
			{
				BTN_VEP.BackColor = backColor;
				BTN_VEP.BackgroundColor = backColor;
				BTN_VEP.BorderColor = backColor;
				BTN_VEP.Invalidate();
			}
			if (nDevice == BARCODE)
			{
				BTN_BARCODE.BackColor = backColor;
				BTN_BARCODE.BackgroundColor = backColor;
				BTN_BARCODE.BorderColor = backColor;
				BTN_BARCODE.Invalidate();
			}


		}
	}
}