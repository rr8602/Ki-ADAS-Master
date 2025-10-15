using Ki_ADAS.DB;
using Ki_ADAS.VEPBench;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Ki_ADAS
{
    public partial class Frm_Result : Form
    {
        private Frm_Mainfrm m_frmParent = null;
        private ResultRepository _resultRepository;
        private VEPBenchDataManager _vepManager = GlobalVal.Instance._VEP;

		DateTime _selDateTime = new DateTime();
		public Frm_Result(SettingConfigDb db)
        {
            InitializeComponent();

            _resultRepository = new ResultRepository(db);

            SetAngleInfo();
        }

        private void LoadInfoList()
        {
            try
            {
                seqList.Items.Clear();

                var results = _resultRepository.GetResultInfo();

                if (results == null || results.Count == 0)
                {
                    return;
                }

                foreach (var result in results)
                {
                    var item = new ListViewItem(result.AcceptNo);
                    item.SubItems.Add(result.PJI);
                    seqList.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MsgBox.ErrorWithFormat("ErrorLoadingXMLFile", "Error", ex.Message);
            }
        }

        private void seqList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (seqList.SelectedItems.Count > 0)
                {
                    SetAngleInfo();
                }
                else
                {
                    MsgBox.Info("SelectTestResultToViewDetails");
                }
            }
            catch (Exception ex)
            {
                MsgBox.ErrorWithFormat("ErrorDisplayingTestResultDetails", "Error", ex.Message);
            }
        }

        public void SetParent(Frm_Mainfrm f)
        {
            m_frmParent = f;
        }

        private void SetAngleInfo()
        {
            lblRoll.Text = _vepManager.SynchroZone.FrontCameraAngle1.ToString();
            lblAzimuth.Text = _vepManager.SynchroZone.FrontCameraAngle2.ToString();
            lblElevation.Text = _vepManager.SynchroZone.FrontCameraAngle3.ToString();
            lblRearRightRadarAngle.Text = _vepManager.SynchroZone.RearRightRadarAngle.ToString();
            lblRearLeftRadarAngle.Text = _vepManager.SynchroZone.RearLeftRadarAngle.ToString();
            lblFrontRightRadarAngle.Text = _vepManager.SynchroZone.FrontRightRadarAngle.ToString();
            lblFrontLeftRadarAngle.Text = _vepManager.SynchroZone.FrontLeftRadarAngle.ToString();
        }

        private void Frm_Result_Load(object sender, EventArgs e)
        {
            try
            {
                this.seqList.OwnerDraw = true;
                this.seqList.DrawColumnHeader += new DrawListViewColumnHeaderEventHandler(this.seqList_DrawColumnHeader);
                this.seqList.DrawSubItem += new DrawListViewSubItemEventHandler(this.seqList_DrawSubItem);

                LoadInfoList();
                dateTimePicker1.Value = DateTime.Now;
				
				_selDateTime = DateTime.Now;
				BTN_DATE.Text = _selDateTime.ToString("yyyy-MM-dd ▼");

			}
            catch (Exception ex)
            {
                MsgBox.ErrorWithFormat("ErrorLoadingResultForm", "Error", ex.Message);
            }
        }

        private void btnDateSearch_Click(object sender, EventArgs e)
        {
            try
            {
                seqList.Items.Clear();

                //var resultsByDate = _resultRepository.GetResultInfoByDate(dateTimePicker1.Value.ToString("yyyyMMdd"));
				var resultsByDate = _resultRepository.GetResultInfoByDate(_selDateTime.ToString("yyyyMMdd"));

				int count = 0;

                if (resultsByDate == null || resultsByDate.Count == 0)
                {
					//MsgBox.InfoWithFormat("NoResultsFoundForDate", "SearchResults", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
					MsgBox.InfoWithFormat("NoResultsFoundForDate", "SearchResults", _selDateTime.ToString("yyyy-MM-dd"));
					return;
                }

                foreach (var result in resultsByDate)
                {
                    var item = new ListViewItem(result.AcceptNo);
                    item.SubItems.Add(result.PJI);
                    seqList.Items.Add(item);
                    count++;
                }

                if (count > 0)
                {
                    seqList.Items[0].Selected = true;
                    seqList.Focus();
                }
            }
            catch (Exception ex)
            {
                MsgBox.ErrorWithFormat("ErrorDuringDateSearch", "Error", ex.Message);
            }
        }

        private void btnPJISearch_Click(object sender, EventArgs e)
        {
            try
            {
                seqList.Items.Clear();

                var resultsByPji = _resultRepository.GetResultInfoByPji(txtPji.Text.Trim());
                int count = 0;

                if (resultsByPji == null || resultsByPji.Count == 0)
                {
                    MsgBox.Info("NoResultsFoundForPJI", "SearchResults");
                    return;
                }

                foreach (var result in resultsByPji)
                {
                    var item = new ListViewItem(result.AcceptNo);
                    item.SubItems.Add(result.PJI);
                    seqList.Items.Add(item);
                    count++;
                }

                if (count > 0)
                {
                    seqList.Items[0].Selected = true;
                    seqList.Focus();
                }
            }
            catch (Exception ex)
            {
                MsgBox.ErrorWithFormat("ErrorDuringPJISearch", "Error", ex.Message);
            }
        }

        private void seqList_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            try
            {
                using (StringFormat sf = new StringFormat())
                {
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;

                    e.DrawBackground();
                    e.Graphics.DrawString(e.Header.Text, e.Font, new SolidBrush(this.seqList.ForeColor), e.Bounds, sf);
                }
            }
            catch (Exception ex)
            {
                MsgBox.ErrorWithFormat("ErrorDrawingResultColumnHeader", "Error", ex.Message);
            }
        }

        private void seqList_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
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
                    e.DrawBackground();
                    TextRenderer.DrawText(e.Graphics, e.SubItem.Text, e.SubItem.Font, e.Bounds, e.SubItem.ForeColor, flags);
                }
            }
            catch (Exception ex)
            {
                MsgBox.ErrorWithFormat("ErrorDrawingResultSubItem", "Error", ex.Message);
            }
        }

		private void btnDateSearch_Click_1(object sender, EventArgs e)
		{

		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void BTN_DATE_Click(object sender, EventArgs e)
		{
			Size size = new Size(450, 450); // 충분히 크게
			CCalendar calendar = new CCalendar(size);


			Form popup = new Form
			{
				FormBorderStyle = FormBorderStyle.None,
				StartPosition = FormStartPosition.Manual,
				ShowInTaskbar = false,
				ClientSize = size // 충분히 크게
			};

			Point location = BTN_DATE.PointToScreen(Point.Empty);
			popup.Location = new Point(location.X, location.Y + BTN_DATE.Height);
			popup.Controls.Add(calendar);
			calendar.DateSelected += (s, date) =>
			{

				String strDate = BTN_DATE.Text;
				BTN_DATE.Text = date.ToString("yyyy-MM-dd ▼");


				_selDateTime = date;

				if (strDate != BTN_DATE.Text)
				{
					strDate = BTN_DATE.Text;
					strDate = strDate.Replace(" ", "");
					strDate = strDate.Replace("▼", "");
					
					
					//LoadResult(strDate);

				}


				popup.Close();
			};
			popup.Deactivate += (s2, e2) => popup.Close();
			popup.Show();
		}
	}
}
