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
    public partial class Frm_Manual : Form
    {
        private Frm_Mainfrm m_frmParent = null;

        public Frm_Manual()
        {
            InitializeComponent();
        }

        public void SetParent(Frm_Mainfrm f)
        {
            m_frmParent = f;
        }

        private void Frm_Manual_Load(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MsgBox.ErrorWithFormat("ErrorLoadingManualForm", "Error", ex.Message);
            }
        }
    }
}
