﻿using Ki_ADAS.VEPBench;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ki_ADAS
{
    public partial class Frm_VEP : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, string lParam);

        private const int EM_SETCUEBANNER = 0x1501;

        private Frm_Mainfrm m_frmParent = null;
        private VEPBenchClient benchClient;

        private Dictionary<string, Action<int>> _propertySetters;

        public Frm_VEP(VEPBenchClient client)
        {
            InitializeComponent();
            benchClient = client;

            lstSynchroZone.OwnerDraw = true;

            this.lstSynchroZone.DrawColumnHeader += new DrawListViewColumnHeaderEventHandler(this.lstSynchroZone_DrawColumnHeader);
            this.lstSynchroZone.DrawSubItem += new DrawListViewSubItemEventHandler(this.lstSynchroZone_DrawSubItem);

            InitializeMappings();
            PopulateSynchroZoneList();

            benchClient.DescriptionZoneRead += BenchClient_OnDescriptionZoneRead;
            benchClient.StatusZoneChanged += BenchClient_StatusZoneChanged;
            benchClient.SynchroZoneChanged += BenchClient_SynchroZoneChanged;
            benchClient.TransmissionZoneChanged += BenchClient_TransmissionZoneChanged;
            benchClient.ReceptionZoneChanged += BenchClient_ReceptionZoneChanged;
        }

        protected override void OnLoad(EventArgs e)
        {
            try
            {
                base.OnLoad(e);
                SendMessage(txtEditValue.Handle, EM_SETCUEBANNER, 0, "Enter value");
            }
            catch (Exception ex)
            {
                MsgBox.ErrorWithFormat("ErrorLoadingVEPForm", "Error", ex.Message);
            }
        }

        private void InitializeMappings()
        {
            var synchroZone = GlobalVal.Instance._VEP.SynchroZone;

            _propertySetters = new Dictionary<string, Action<int>>
            {
                { "110", value => synchroZone.FrontCameraAngle1 = value },
                { "111", value => synchroZone.FrontCameraAngle2 = value },
                { "112", value => synchroZone.FrontCameraAngle3 = value },
                { "115", value => synchroZone.RearRightRadarAngle = value },
                { "116", value => synchroZone.RearLeftRadarAngle = value },
                { "117", value => synchroZone.FrontRightRadarAngle = value },
                { "118", value => synchroZone.FrontLeftRadarAngle = value }
            };
        }

        public void SetParent(Frm_Mainfrm f)
        {
            m_frmParent = f;
        }

        private void BenchClient_OnDescriptionZoneRead(object sender, VEPBenchDescriptionZone e)
        {
            try
            {
                if (InvokeRequired)
                {
                    BeginInvoke(new Action<object, VEPBenchDescriptionZone>(BenchClient_OnDescriptionZoneRead), sender, e);
                    return;
                }

                txtDesZone.Text = e.ValidityIndicator.ToString();
                txtStatusZoneAddress.Text = e.StatusZoneAddr.ToString();
                txtStatusZoneSize.Text = e.StatusZoneSize.ToString();
                txtSynchroZoneAddress.Text = e.SynchroZoneAddr.ToString();
                txtSynchroZoneSize.Text = e.SynchroZoneSize.ToString();
                txtTzAddress.Text = e.TransmissionZoneAddr.ToString();
                txtTzSize.Text = e.TransmissionZoneSize.ToString();
                txtReAddress.Text = e.ReceptionZoneAddr.ToString();
                txtReSize.Text = e.ReceptionZoneSize.ToString();
                txtAddTzAddress.Text = e.AdditionalTZAddr.ToString();
                txtAddTzSize.Text = e.AdditionalTZSize.ToString();
                txtAddReAddress.Text = e.AdditionalRZAddr.ToString();
                txtAddReSize.Text = e.AdditionalRZSize.ToString();
            }
            catch (Exception ex)
            {
                MsgBox.ErrorWithFormat("ErrorUpdatingDescriptionZone", "Error", ex.Message);
            }
        }

        private void BenchClient_StatusZoneChanged(object sender, VEPBenchStatusZone e)
        {
            try
            {
                if (InvokeRequired)
                {
                    BeginInvoke(new Action(() => UpdateStatusInfo(
                        e.VepStatus,
                        e.VepCycleEnd,
                        e.BenchCycleEnd,
                        e.StartCycle,
                        e.VepCycleInterruption,
                        e.BenchCycleInterruption)));
                }
                else
                {
                    UpdateStatusInfo(
                        e.VepStatus,
                        e.VepCycleEnd,
                        e.BenchCycleEnd,
                        e.StartCycle,
                        e.VepCycleInterruption,
                        e.BenchCycleInterruption);
                }
            }
            catch (Exception ex)
            {
                MsgBox.ErrorWithFormat("ErrorUpdatingStatusZone", "Error", ex.Message);
            }
        }

        private void BenchClient_SynchroZoneChanged(object sender, VEPBenchSynchroZone e)
        {
            try
            {
                UpdateSynchroValues(
                    e.FrontCameraAngle1,
                    e.FrontCameraAngle2,
                    e.FrontCameraAngle3,
                    e.RearRightRadarAngle,
                    e.RearLeftRadarAngle,
                    e.FrontRightRadarAngle,
                    e.FrontLeftRadarAngle);

                PopulateSynchroZoneList();
            }
            catch (Exception ex)
            {
                MsgBox.ErrorWithFormat("ErrorUpdatingSynchroZone", "Error", ex.Message);
            }
        }

        private void BenchClient_TransmissionZoneChanged(object sender, VEPBenchTransmissionZone e)
        {
            try
            {
                if (InvokeRequired)
                {
                    BeginInvoke(new Action(() => UpdateTransmissionInfo(e.AddTzSize, e.ExchStatus, e.FctCode, e.PCNum, e.ProcessCode, e.SubFctCode)));
                }
                else
                {
                    UpdateTransmissionInfo(e.AddTzSize, e.ExchStatus, e.FctCode, e.PCNum, e.ProcessCode, e.SubFctCode);
                }

                if (e.IsRequest)
                {
                    Console.WriteLine($"TransmissionZoneChanged 이벤트: 요청 감지 FctCode={e.FctCode}, PCNum={e.PCNum}");
                }
            }
            catch (Exception ex)
            {
                MsgBox.ErrorWithFormat("ErrorUpdatingTransmissionZone", "Error", ex.Message);
            }
        }

        private void BenchClient_ReceptionZoneChanged(object sender, VEPBenchReceptionZone e)
        {
            try
            {
                if (InvokeRequired)
                {
                    BeginInvoke(new Action(() => UpdateReceptionInfo(e.AddReSize, e.ExchStatus, e.FctCode, e.PCNum, e.ProcessCode, e.SubFctCode)));
                }
                else
                {
                    UpdateReceptionInfo(e.AddReSize, e.ExchStatus, e.FctCode, e.PCNum, e.ProcessCode, e.SubFctCode);
                }

                string status = e.IsResponseCompleted ? "응답 완료" : "응답 준비";
                Console.WriteLine($"ReceptionZoneChanged 이벤트: {status}, FctCode={e.FctCode}");
            }
            catch (Exception ex)
            {
                MsgBox.ErrorWithFormat("ErrorUpdatingReceptionZone", "Error", ex.Message);
            }
        }

        public void UpdateStatusInfo(ushort vepStatus, ushort vepCycleEnd, ushort benchCycleEnd, ushort startCycle, ushort vepCycleInt, ushort benchCycleInt)
        {
            txtStVepStatus.Text = vepStatus.ToString();
            txtStVepCycleEnd.Text = vepCycleEnd.ToString();
            txtStBenchCycleEnd.Text = benchCycleEnd.ToString();
            txtStStartCycle.Text = startCycle.ToString();
            txtStVepCycleInt.Text = vepCycleInt.ToString();
            txtStBenchCycleInt.Text = benchCycleInt.ToString();
        }

        public void UpdateSynchroValues(int frontCameraAngle1, int frontCameraAngle2, int frontCameraAngle3, int rearRightRadarAngle, int rearLeftRadarAngle, int frontRightRadarAngle, int frontLeftRadarAngle)
        {
            txtFrontCameraAngle1.Text = frontCameraAngle1.ToString();
            txtFrontCameraAngle2.Text = frontCameraAngle2.ToString();
            txtFrontCameraAngle3.Text = frontCameraAngle3.ToString();
            txtRearRightRadarAngle.Text = rearRightRadarAngle.ToString();
            txtRearLeftRadarAngle.Text = rearLeftRadarAngle.ToString();
            txtFrontRightRadarAngle.Text = frontRightRadarAngle.ToString();
            txtFrontLeftRadarAngle.Text = frontLeftRadarAngle.ToString();
        }

        public void UpdateTransmissionInfo(ushort size, ushort exchStatus, byte fctCode, byte pcNum, byte processCode, byte subFctCode)
        {
            txtAddrTzSize.Text = size.ToString();
            txtTzExchStatus.Text = exchStatus.ToString();
            txtTzFctCode.Text = fctCode.ToString();
            txtTzPCNum.Text = pcNum.ToString();
            txtTzProcessCode.Text = processCode.ToString();
            txtTzSubFctCode.Text = subFctCode.ToString();
        }

        public void UpdateReceptionInfo(ushort size, ushort exchStatus, byte fctCode, byte pcNum, byte processCode, byte subFctCode)
        {
            txtAddrReSize.Text = size.ToString();
            txtReExchStatus.Text = exchStatus.ToString();
            txtReFctCode.Text = fctCode.ToString();
            txtRePCNum.Text = pcNum.ToString();
            txtReProcessCode.Text = processCode.ToString();
            txtReSubFctCode.Text = subFctCode.ToString();
        }

        private void PopulateSynchroZoneList()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(PopulateSynchroZoneList));
                return;
            }

            try
            {
                lstSynchroZone.Items.Clear();

                var vepManager = GlobalVal.Instance._VEP;
                if (vepManager == null || vepManager.SynchroZone == null || vepManager.DescriptionZone == null) return;

                var synchroZone = vepManager.SynchroZone;
                var descriptionZone = vepManager.DescriptionZone;

                ushort baseAddress = descriptionZone.SynchroZoneAddr;
                ushort[] rawValues = synchroZone.ToRegisters();

                for (int i = 0; i < rawValues.Length; i++)
                {
                    ListViewItem item = new ListViewItem((baseAddress + i).ToString());

                    item.SubItems.Add(i.ToString());

                    int rawValue = rawValues[i];
                    int displayValue = rawValue;

                    if (i == VEPBenchSynchroZone.FRONT_CAMERA_ANGLE1_INDEX ||
                        i == VEPBenchSynchroZone.FRONT_CAMERA_ANGLE2_INDEX ||
                        i == VEPBenchSynchroZone.FRONT_CAMERA_ANGLE3_INDEX ||
                        i == VEPBenchSynchroZone.REAR_RIGHT_RADAR_ANGLE_INDEX ||
                        i == VEPBenchSynchroZone.REAR_LEFT_RADAR_ANGLE_INDEX ||
                        i == VEPBenchSynchroZone.FRONT_RIGHT_RADAR_ANGLE_INDEX ||
                        i == VEPBenchSynchroZone.FRONT_LEFT_RADAR_ANGLE_INDEX)
                    {
                        displayValue = rawValue / 100;
                    }

                    item.SubItems.Add(displayValue.ToString());
                    lstSynchroZone.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MsgBox.ErrorWithFormat("ErrorPopulatingSynchroZoneList", "Error", ex.Message);
            }
        }

        private void btnEditValue_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = cmbValueList.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(selectedItem))
                {
                    MsgBox.Warn("SelectItemToModify");
                    return;
                }

                if (!int.TryParse(txtEditValue.Text, out int valueToSet))
                {
                    MsgBox.Warn("EnterValidInteger");
                    return;
                }

                if (_propertySetters.TryGetValue(selectedItem, out var propertySetter))
                {
                    propertySetter(valueToSet);
                    benchClient.WriteSynchroZone();

                    MsgBox.Info("WriteCommandSentSuccessfully");
                }
                else
                {
                    MsgBox.Warn("UnknownItem");
                }
            }
            catch (Exception ex)
            {
                MsgBox.ErrorWithFormat("ErrorModifyingValue", "Error", ex.Message);
            }
        }

        private void btnEditStartCycle_Click(object sender, EventArgs e)
        {
            try
            {
                var statusZone = GlobalVal.Instance._VEP.StatusZone;
                statusZone.StartCycle = 1;
                benchClient.WriteStatusZone();

                MsgBox.Info("StartCycleValueTo1Successfully");
            }
            catch (Exception ex)
            {
                MsgBox.ErrorWithFormat("ErrorSettingStartCycleValue", "Error", ex.Message);
            }
        }

        private void btnEditTExchStatus_Click(object sender, EventArgs e)
        {
            try
            {
                var transmissionZone = GlobalVal.Instance._VEP.TransmissionZone;
                transmissionZone.ExchStatus = VEPBenchTransmissionZone.ExchStatus_Response;
                benchClient.WriteTransmissionZone();

                MsgBox.Info("TransmissionZoneSetExchStatusTo1");
            }
            catch (Exception ex)
            {
                MsgBox.ErrorWithFormat("ErrorSettingTransmissionZoneExchStatus", "Error", ex.Message);
            }
        }

        private void btnEditRExchStatus_Click(object sender, EventArgs e)
        {
            try
            {
                var receptionZone = GlobalVal.Instance._VEP.ReceptionZone;
                receptionZone.ExchStatus = VEPBenchReceptionZone.ExchStatus_Response;
                benchClient.WriteReceptionZone();

                MsgBox.Info("ReceptionZoneSetExchStatusTo1");
            }
            catch (Exception ex)
            {
                MsgBox.ErrorWithFormat("ErrorSettingReceiptZoneExchStatus", "Error", ex.Message);
            }
        }

        private void lstSynchroZone_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            try
            {
                using (StringFormat sf = new StringFormat())
                {
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;

                    e.DrawBackground();
                    e.Graphics.DrawString(e.Header.Text, e.Font, new SolidBrush(this.lstSynchroZone.ForeColor), e.Bounds, sf);
                }
            }
            catch (Exception ex)
            {
                MsgBox.ErrorWithFormat("ErrorDrawingSynchroColumnHeader", "Error", ex.Message);
            }
        }

        private void lstSynchroZone_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            try
            {
                TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;

                if (e.Item.Selected)
                {
                    e.Graphics.FillRectangle(SystemBrushes.Highlight, e.Bounds);
                    TextRenderer.DrawText(e.Graphics, e.SubItem.Text, e.SubItem.Font, e.Bounds, SystemColors.HighlightText, flags);
                }
                else
                {
                    Color backColor = (e.ItemIndex % 2 == 0)
                        ? Color.White
                        : Color.FromArgb(255, 240, 240, 240);

                    using (Brush b = new SolidBrush(backColor))
                    {
                        e.Graphics.FillRectangle(b, e.Bounds);
                    }

                    TextRenderer.DrawText(e.Graphics, e.SubItem.Text, e.SubItem.Font, e.Bounds, e.SubItem.ForeColor, flags);
                }
            }
            catch (Exception ex)
            {
                MsgBox.ErrorWithFormat("ErrorDrawingSynchroSubItem", "Error", ex.Message);
            }
        }

    }
}
