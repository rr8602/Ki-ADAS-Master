using System;
using System.Drawing;
using System.Windows.Forms;

namespace HomePositionSimulator
{
    public partial class Form1 : Form
    {
        // �ý��� ���� ����
        private bool isHomePosition = true;
        private bool isTrafficLightGreen = false;
        private bool isVehicleDetected = false;
        private bool isPIIRequested = false;
        private bool isVEPWorking = false;
        private bool isCameraOptionSelected = false;
        private bool isRadarOptionSelected = false;
        private int cycleValue = 0;
        private string barcodeValue = "";
        private Timer processTimer;
        private int timeElapsed = 0;
        private int timeoutLimit = 30; // 30�� Ÿ�Ӿƿ�

        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();
            SetInitialState();
        }

        private void InitializeCustomComponents()
        {
            // Ÿ�̸� �ʱ�ȭ
            processTimer = new Timer();
            processTimer.Interval = 1000;
            processTimer.Tick += ProcessTimer_Tick;
        }

        private void ProcessTimer_Tick(object sender, EventArgs e)
        {
            timeElapsed++;
            lblTimeElapsed.Text = $"��� �ð�: {timeElapsed}��";

            // Ÿ�Ӿƿ� üũ
            if (timeElapsed > timeoutLimit && !isVEPWorking)
            {
                lblStatus.Text = "����: Ÿ�Ӿƿ� - ���μ��� ����";
                lblStatus.ForeColor = Color.Red;
                processTimer.Stop();
                btnReset.Enabled = true;
            }
        }

        private void SetInitialState()
        {
            // �ʱ� ���� ���� - Home Position
            isHomePosition = true;
            isTrafficLightGreen = false;
            isVehicleDetected = false;
            isPIIRequested = false;
            isVEPWorking = false;
            isCameraOptionSelected = false;
            isRadarOptionSelected = false;
            cycleValue = 0;
            barcodeValue = "";
            timeElapsed = 0;

            // UI ������Ʈ
            lblStatus.Text = "����: Ȩ ������";
            lblStatus.ForeColor = Color.Green;
            lblPositioningDevice.Text = "�����Ŵ� ��ġ: Ȩ";
            lblCameraTarget.Text = "ī�޶� Ÿ��: Ȩ";
            lblVehicleDetect.Text = "���� ���� ����: ����";
            
            // ��ư ���� ������Ʈ
            btnSetTrafficLight.Enabled = true;
            btnScanBarcode.Enabled = false;
            btnRequestPII.Enabled = false;
            btnCheckVEPStatus.Enabled = false;
            btnSelectOption.Enabled = false;
            btnReset.Enabled = true;
            
            // ���� �г� �ʱ�ȭ
            UpdateStatusPanels(1);
            
            // Ÿ�̸� �ʱ�ȭ
            processTimer.Stop();
        }

        private void UpdateStatusPanels(int currentStep)
        {
            // �������� �ܰ迡 ���� �г� ���� ������Ʈ
            pnlHomePosition.BackColor = (currentStep >= 1) ? Color.LightGreen : Color.LightGray;
            pnlTrafficLight.BackColor = (currentStep >= 2) ? Color.LightGreen : Color.LightGray;
            pnlVehicleEntrance.BackColor = (currentStep >= 3) ? Color.LightGreen : Color.LightGray;
            pnlScanBarcode.BackColor = (currentStep >= 4) ? Color.LightGreen : Color.LightGray;
            pnlStartCycle.BackColor = (currentStep >= 5) ? Color.LightGreen : Color.LightGray;
            pnlCheckPII.BackColor = (currentStep >= 6) ? Color.LightGreen : Color.LightGray;
            pnlVEPStatus.BackColor = (currentStep >= 7) ? Color.LightGreen : Color.LightGray;
            pnlCameraRadarOption.BackColor = (currentStep >= 8) ? Color.LightGreen : Color.LightGray;
        }

        private void btnSetTrafficLight_Click(object sender, EventArgs e)
        {
            isTrafficLightGreen = true;
            lblStatus.Text = "����: �Ա� ��ȣ�� �ʷϻ�";
            UpdateStatusPanels(2);
            btnSetTrafficLight.Enabled = false;
            btnScanBarcode.Enabled = true;
        }

        private void btnScanBarcode_Click(object sender, EventArgs e)
        {
            // ���ڵ� ��ĵ �ùķ��̼�
            Random random = new Random();
            barcodeValue = $"VIN{random.Next(10000, 99999)}";
            lblStatus.Text = $"����: ���ڵ� ��ĵ �Ϸ� - {barcodeValue}";
            isVehicleDetected = true;
            lblVehicleDetect.Text = "���� ���� ����: ����";
            UpdateStatusPanels(4);
            btnScanBarcode.Enabled = false;
            
            // ����Ŭ ����
            cycleValue = 1;
            lblStatus.Text = $"����: ����Ŭ ���� �� = {cycleValue}";
            UpdateStatusPanels(5);
            btnRequestPII.Enabled = true;
        }

        private void btnRequestPII_Click(object sender, EventArgs e)
        {
            isPIIRequested = true;
            lblStatus.Text = "����: PII ��û��";
            UpdateStatusPanels(6);
            btnRequestPII.Enabled = false;
            lblStatus.Text = "����: PII�� VEP�� ���۵�";
            btnCheckVEPStatus.Enabled = true;

            // Ÿ�̸� ����
            timeElapsed = 0;
            processTimer.Start();
        }

        private void btnCheckVEPStatus_Click(object sender, EventArgs e)
        {
            // VEP ���� Ȯ�� �ùķ��̼�
            isVEPWorking = checkBoxVEPWorking.Checked;
            
            if (isVEPWorking)
            {
                lblStatus.Text = "����: VEP �۵� ��";
                UpdateStatusPanels(7);
                btnCheckVEPStatus.Enabled = false;
                btnSelectOption.Enabled = true;
                processTimer.Stop();
            }
            else if (timeElapsed > timeoutLimit)
            {
                lblStatus.Text = "����: VEP Ÿ�Ӿƿ� - ���μ��� ����";
                lblStatus.ForeColor = Color.Red;
                processTimer.Stop();
            }
            else
            {
                lblStatus.Text = $"����: VEP ���۵�, ��� ��... ({timeElapsed}��)";
            }
        }

        private void btnSelectOption_Click(object sender, EventArgs e)
        {
            if (radioCamera.Checked)
            {
                isCameraOptionSelected = true;
                isRadarOptionSelected = false;
                lblStatus.Text = "����: ī�޶� �ɼ� ���õ� - Syncro S1+ (�Ĺ� ī�޶�)";
            }
            else if (radioRadar.Checked)
            {
                isCameraOptionSelected = false;
                isRadarOptionSelected = true;
                lblStatus.Text = "����: ���̴� �ɼ� ���õ� - Syncro S3+ (�Ĺ� �ڳ� ���̴�)";
            }
            else
            {
                MessageBox.Show("�ɼ��� �������ּ���.", "�˸�", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            UpdateStatusPanels(8);
            btnSelectOption.Enabled = false;
            lblStatus.Text += " - ���μ��� �Ϸ�";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            SetInitialState();
        }

        private void btnMoveCarToBench_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "����: ������ ��ġ�� �̵� ��";
            MessageBox.Show("������ ��ġ�� �̵��ϼ���.", "�ȳ�", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}