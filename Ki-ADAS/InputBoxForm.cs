using System;
using System.Windows.Forms;

namespace Ki_ADAS
{
    public partial class InputBoxForm : Form
    {
        public string Value { get; private set; }

        public InputBoxForm(string prompt, string title)
        {
            InitializeComponent();
            this.lblPrompt.Text = prompt;
            this.Text = title;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Value = this.txtInput.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
