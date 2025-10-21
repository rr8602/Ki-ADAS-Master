using KI_Controls;

namespace Ki_ADAS
{
	partial class Frm_Notice
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Notice));
            this.timerSecond = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_AUTO = new KI_Controls.RoundLabel();
            this.BTN_POSITION = new KI_Controls.RoundLabel();
            this.BTN_VEP_STATUS = new KI_Controls.RoundLabel();
            this.BTN_MOTOR_STOP = new KI_Controls.RoundLabel();
            this.BTN_DOOR_CLOSE = new KI_Controls.RoundLabel();
            this.RL_LIFT_UP = new KI_Controls.RoundLabel();
            this.btnBottom = new KI_Controls.CButton();
            this.btnBody = new KI_Controls.CButton();
            this.btnTop = new KI_Controls.CButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerSecond
            // 
            this.timerSecond.Interval = 1000;
            this.timerSecond.Tick += new System.EventHandler(this.timerSecond_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.BTN_AUTO);
            this.panel1.Controls.Add(this.BTN_POSITION);
            this.panel1.Controls.Add(this.BTN_VEP_STATUS);
            this.panel1.Controls.Add(this.BTN_MOTOR_STOP);
            this.panel1.Controls.Add(this.BTN_DOOR_CLOSE);
            this.panel1.Controls.Add(this.RL_LIFT_UP);
            this.panel1.Location = new System.Drawing.Point(13, 499);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1897, 475);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BTN_AUTO
            // 
            this.BTN_AUTO.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BTN_AUTO.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BTN_AUTO.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BTN_AUTO.BorderRadius = 10;
            this.BTN_AUTO.BorderSize = 0;
            this.BTN_AUTO.FlatAppearance.BorderSize = 0;
            this.BTN_AUTO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_AUTO.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_AUTO.ForeColor = System.Drawing.Color.White;
            this.BTN_AUTO.Image = ((System.Drawing.Image)(resources.GetObject("BTN_AUTO.Image")));
            this.BTN_AUTO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_AUTO.Location = new System.Drawing.Point(89, 44);
            this.BTN_AUTO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_AUTO.Name = "BTN_AUTO";
            this.BTN_AUTO.Size = new System.Drawing.Size(505, 113);
            this.BTN_AUTO.TabIndex = 0;
            this.BTN_AUTO.Text = "PLC";
            this.BTN_AUTO.TextColor = System.Drawing.Color.White;
            this.BTN_AUTO.UseVisualStyleBackColor = false;
            // 
            // BTN_POSITION
            // 
            this.BTN_POSITION.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BTN_POSITION.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BTN_POSITION.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BTN_POSITION.BorderRadius = 10;
            this.BTN_POSITION.BorderSize = 0;
            this.BTN_POSITION.FlatAppearance.BorderSize = 0;
            this.BTN_POSITION.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_POSITION.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_POSITION.ForeColor = System.Drawing.Color.White;
            this.BTN_POSITION.Image = ((System.Drawing.Image)(resources.GetObject("BTN_POSITION.Image")));
            this.BTN_POSITION.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_POSITION.Location = new System.Drawing.Point(1249, 44);
            this.BTN_POSITION.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_POSITION.Name = "BTN_POSITION";
            this.BTN_POSITION.Size = new System.Drawing.Size(505, 113);
            this.BTN_POSITION.TabIndex = 2;
            this.BTN_POSITION.Text = "     Home Position";
            this.BTN_POSITION.TextColor = System.Drawing.Color.White;
            this.BTN_POSITION.UseVisualStyleBackColor = false;
            // 
            // BTN_VEP_STATUS
            // 
            this.BTN_VEP_STATUS.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BTN_VEP_STATUS.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BTN_VEP_STATUS.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BTN_VEP_STATUS.BorderRadius = 10;
            this.BTN_VEP_STATUS.BorderSize = 0;
            this.BTN_VEP_STATUS.FlatAppearance.BorderSize = 0;
            this.BTN_VEP_STATUS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_VEP_STATUS.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_VEP_STATUS.ForeColor = System.Drawing.Color.White;
            this.BTN_VEP_STATUS.Image = ((System.Drawing.Image)(resources.GetObject("BTN_VEP_STATUS.Image")));
            this.BTN_VEP_STATUS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_VEP_STATUS.Location = new System.Drawing.Point(669, 44);
            this.BTN_VEP_STATUS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_VEP_STATUS.Name = "BTN_VEP_STATUS";
            this.BTN_VEP_STATUS.Size = new System.Drawing.Size(505, 113);
            this.BTN_VEP_STATUS.TabIndex = 1;
            this.BTN_VEP_STATUS.Text = "     VEP Status";
            this.BTN_VEP_STATUS.TextColor = System.Drawing.Color.White;
            this.BTN_VEP_STATUS.UseVisualStyleBackColor = false;
            // 
            // BTN_MOTOR_STOP
            // 
            this.BTN_MOTOR_STOP.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BTN_MOTOR_STOP.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BTN_MOTOR_STOP.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BTN_MOTOR_STOP.BorderRadius = 10;
            this.BTN_MOTOR_STOP.BorderSize = 0;
            this.BTN_MOTOR_STOP.FlatAppearance.BorderSize = 0;
            this.BTN_MOTOR_STOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_MOTOR_STOP.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_MOTOR_STOP.ForeColor = System.Drawing.Color.White;
            this.BTN_MOTOR_STOP.Image = ((System.Drawing.Image)(resources.GetObject("BTN_MOTOR_STOP.Image")));
            this.BTN_MOTOR_STOP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_MOTOR_STOP.Location = new System.Drawing.Point(1249, 186);
            this.BTN_MOTOR_STOP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_MOTOR_STOP.Name = "BTN_MOTOR_STOP";
            this.BTN_MOTOR_STOP.Size = new System.Drawing.Size(505, 113);
            this.BTN_MOTOR_STOP.TabIndex = 5;
            this.BTN_MOTOR_STOP.Text = " Traffic light";
            this.BTN_MOTOR_STOP.TextColor = System.Drawing.Color.White;
            this.BTN_MOTOR_STOP.UseVisualStyleBackColor = false;
            // 
            // BTN_DOOR_CLOSE
            // 
            this.BTN_DOOR_CLOSE.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BTN_DOOR_CLOSE.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BTN_DOOR_CLOSE.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BTN_DOOR_CLOSE.BorderRadius = 10;
            this.BTN_DOOR_CLOSE.BorderSize = 0;
            this.BTN_DOOR_CLOSE.FlatAppearance.BorderSize = 0;
            this.BTN_DOOR_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DOOR_CLOSE.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DOOR_CLOSE.ForeColor = System.Drawing.Color.White;
            this.BTN_DOOR_CLOSE.Image = ((System.Drawing.Image)(resources.GetObject("BTN_DOOR_CLOSE.Image")));
            this.BTN_DOOR_CLOSE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_DOOR_CLOSE.Location = new System.Drawing.Point(669, 186);
            this.BTN_DOOR_CLOSE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_DOOR_CLOSE.Name = "BTN_DOOR_CLOSE";
            this.BTN_DOOR_CLOSE.Size = new System.Drawing.Size(505, 113);
            this.BTN_DOOR_CLOSE.TabIndex = 4;
            this.BTN_DOOR_CLOSE.Text = "   Printer";
            this.BTN_DOOR_CLOSE.TextColor = System.Drawing.Color.White;
            this.BTN_DOOR_CLOSE.UseVisualStyleBackColor = false;
            // 
            // RL_LIFT_UP
            // 
            this.RL_LIFT_UP.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.RL_LIFT_UP.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.RL_LIFT_UP.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.RL_LIFT_UP.BorderRadius = 10;
            this.RL_LIFT_UP.BorderSize = 0;
            this.RL_LIFT_UP.FlatAppearance.BorderSize = 0;
            this.RL_LIFT_UP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RL_LIFT_UP.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RL_LIFT_UP.ForeColor = System.Drawing.Color.White;
            this.RL_LIFT_UP.Image = ((System.Drawing.Image)(resources.GetObject("RL_LIFT_UP.Image")));
            this.RL_LIFT_UP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RL_LIFT_UP.Location = new System.Drawing.Point(89, 186);
            this.RL_LIFT_UP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RL_LIFT_UP.Name = "RL_LIFT_UP";
            this.RL_LIFT_UP.Size = new System.Drawing.Size(505, 113);
            this.RL_LIFT_UP.TabIndex = 3;
            this.RL_LIFT_UP.Text = "   BARCODE";
            this.RL_LIFT_UP.TextColor = System.Drawing.Color.White;
            this.RL_LIFT_UP.UseVisualStyleBackColor = false;
            // 
            // btnBottom
            // 
            this.btnBottom.BackColor = System.Drawing.Color.Black;
            this.btnBottom.BorderColor = System.Drawing.Color.Black;
            this.btnBottom.BorderSize = ((uint)(1u));
            this.btnBottom.DisabledBackColor = System.Drawing.Color.Black;
            this.btnBottom.DisabledForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBottom.Enabled = false;
            this.btnBottom.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBottom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBottom.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBottom.ForeColor = System.Drawing.Color.Black;
            this.btnBottom.Location = new System.Drawing.Point(13, 480);
            this.btnBottom.Margin = new System.Windows.Forms.Padding(4);
            this.btnBottom.Name = "btnBottom";
            this.btnBottom.NormalBackColor = System.Drawing.Color.LightGray;
            this.btnBottom.NormalForeColor = System.Drawing.Color.Black;
            this.btnBottom.Size = new System.Drawing.Size(1897, 12);
            this.btnBottom.TabIndex = 1;
            this.btnBottom.UseVisualStyleBackColor = false;
            this.btnBottom.Visible = false;
            // 
            // btnBody
            // 
            this.btnBody.BackColor = System.Drawing.Color.Black;
            this.btnBody.BorderColor = System.Drawing.Color.Black;
            this.btnBody.BorderSize = ((uint)(1u));
            this.btnBody.DisabledBackColor = System.Drawing.Color.Black;
            this.btnBody.DisabledForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBody.Enabled = false;
            this.btnBody.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBody.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBody.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBody.ForeColor = System.Drawing.Color.Black;
            this.btnBody.Location = new System.Drawing.Point(13, 141);
            this.btnBody.Margin = new System.Windows.Forms.Padding(4);
            this.btnBody.Name = "btnBody";
            this.btnBody.NormalBackColor = System.Drawing.Color.LightGray;
            this.btnBody.NormalForeColor = System.Drawing.Color.Black;
            this.btnBody.Size = new System.Drawing.Size(1897, 339);
            this.btnBody.TabIndex = 1;
            this.btnBody.UseVisualStyleBackColor = false;
            // 
            // btnTop
            // 
            this.btnTop.BackColor = System.Drawing.Color.Black;
            this.btnTop.BorderColor = System.Drawing.Color.Black;
            this.btnTop.BorderSize = ((uint)(1u));
            this.btnTop.DisabledBackColor = System.Drawing.Color.Black;
            this.btnTop.DisabledForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTop.Enabled = false;
            this.btnTop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTop.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTop.ForeColor = System.Drawing.Color.Black;
            this.btnTop.Location = new System.Drawing.Point(13, 14);
            this.btnTop.Margin = new System.Windows.Forms.Padding(4);
            this.btnTop.Name = "btnTop";
            this.btnTop.NormalBackColor = System.Drawing.Color.LightGray;
            this.btnTop.NormalForeColor = System.Drawing.Color.Black;
            this.btnTop.Size = new System.Drawing.Size(1897, 128);
            this.btnTop.TabIndex = 1;
            this.btnTop.UseVisualStyleBackColor = false;
            // 
            // Frm_Notice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1925, 1075);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBottom);
            this.Controls.Add(this.btnBody);
            this.Controls.Add(this.btnTop);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_Notice";
            this.Text = "Notice";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Notice_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Notice_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_Notice_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_Notice_MouseMove);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private CButton btnTop;
		private CButton btnBody;
		private CButton btnBottom;
		private System.Windows.Forms.Timer timerSecond;
		private RoundLabel RL_LIFT_UP;
		private System.Windows.Forms.Panel panel1;
		private RoundLabel BTN_VEP_STATUS;
		private RoundLabel BTN_MOTOR_STOP;
		private RoundLabel BTN_DOOR_CLOSE;
		private RoundLabel BTN_AUTO;
		private RoundLabel BTN_POSITION;
	}
}