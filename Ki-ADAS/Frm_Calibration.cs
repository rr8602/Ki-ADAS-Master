using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ki_ADAS
{
    public partial class Frm_Calibration : Form
    {
        private Frm_Mainfrm m_frmParent = null;

 
        public Frm_Calibration()
        {
            InitializeComponent();

        }

        public void SetParent(Frm_Mainfrm f)
        {
            m_frmParent = f;
        }

		private void Frm_Calibration_Load(object sender, EventArgs e)
		{

		}
	}
}
