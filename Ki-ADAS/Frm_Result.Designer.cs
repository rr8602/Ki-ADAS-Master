namespace Ki_ADAS
{
    partial class Frm_Result
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Result));
			this.seqList = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lblFrontLeftRadarAngle = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.lblFrontRightRadarAngle = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.lblRearLeftRadarAngle = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.lblRearRightRadarAngle = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.lblElevation = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblAzimuth = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lblRoll = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtPji = new System.Windows.Forms.TextBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.BTN_DATE = new System.Windows.Forms.Button();
			this.btnPJISearch = new KI_Controls.CButton();
			this.btnDateSearch = new KI_Controls.CButton();
			this.roundLabel2 = new KI_Controls.RoundLabel();
			this.SuspendLayout();
			// 
			// seqList
			// 
			this.seqList.Activation = System.Windows.Forms.ItemActivation.TwoClick;
			this.seqList.BackColor = System.Drawing.Color.SeaShell;
			this.seqList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.seqList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.seqList.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.seqList.FullRowSelect = true;
			this.seqList.GridLines = true;
			this.seqList.HideSelection = false;
			this.seqList.Location = new System.Drawing.Point(29, 111);
			this.seqList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.seqList.MultiSelect = false;
			this.seqList.Name = "seqList";
			this.seqList.Size = new System.Drawing.Size(727, 767);
			this.seqList.TabIndex = 159;
			this.seqList.UseCompatibleStateImageBehavior = false;
			this.seqList.View = System.Windows.Forms.View.Details;
			this.seqList.SelectedIndexChanged += new System.EventHandler(this.seqList_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "AcceptNo";
			this.columnHeader1.Width = 350;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "PJI";
			this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader2.Width = 300;
			// 
			// lblFrontLeftRadarAngle
			// 
			this.lblFrontLeftRadarAngle.BackColor = System.Drawing.Color.White;
			this.lblFrontLeftRadarAngle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFrontLeftRadarAngle.Location = new System.Drawing.Point(1051, 464);
			this.lblFrontLeftRadarAngle.Name = "lblFrontLeftRadarAngle";
			this.lblFrontLeftRadarAngle.Size = new System.Drawing.Size(171, 40);
			this.lblFrontLeftRadarAngle.TabIndex = 201;
			this.lblFrontLeftRadarAngle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(793, 464);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(225, 40);
			this.label11.TabIndex = 200;
			this.label11.Text = "[Radar] Front Left Angle";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblFrontRightRadarAngle
			// 
			this.lblFrontRightRadarAngle.BackColor = System.Drawing.Color.White;
			this.lblFrontRightRadarAngle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFrontRightRadarAngle.Location = new System.Drawing.Point(1051, 414);
			this.lblFrontRightRadarAngle.Name = "lblFrontRightRadarAngle";
			this.lblFrontRightRadarAngle.Size = new System.Drawing.Size(171, 40);
			this.lblFrontRightRadarAngle.TabIndex = 199;
			this.lblFrontRightRadarAngle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(793, 414);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(225, 40);
			this.label10.TabIndex = 198;
			this.label10.Text = "[Radar] Front Right Angle";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblRearLeftRadarAngle
			// 
			this.lblRearLeftRadarAngle.BackColor = System.Drawing.Color.White;
			this.lblRearLeftRadarAngle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRearLeftRadarAngle.Location = new System.Drawing.Point(1051, 353);
			this.lblRearLeftRadarAngle.Name = "lblRearLeftRadarAngle";
			this.lblRearLeftRadarAngle.Size = new System.Drawing.Size(171, 40);
			this.lblRearLeftRadarAngle.TabIndex = 197;
			this.lblRearLeftRadarAngle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(793, 351);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(241, 40);
			this.label12.TabIndex = 196;
			this.label12.Text = "[Radar] Rear Left Angle";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblRearRightRadarAngle
			// 
			this.lblRearRightRadarAngle.BackColor = System.Drawing.Color.White;
			this.lblRearRightRadarAngle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRearRightRadarAngle.Location = new System.Drawing.Point(1051, 303);
			this.lblRearRightRadarAngle.Name = "lblRearRightRadarAngle";
			this.lblRearRightRadarAngle.Size = new System.Drawing.Size(171, 40);
			this.lblRearRightRadarAngle.TabIndex = 195;
			this.lblRearRightRadarAngle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(793, 303);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(241, 40);
			this.label9.TabIndex = 194;
			this.label9.Text = "[Radar] Rear Right Angle";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblElevation
			// 
			this.lblElevation.BackColor = System.Drawing.Color.White;
			this.lblElevation.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblElevation.Location = new System.Drawing.Point(1051, 241);
			this.lblElevation.Name = "lblElevation";
			this.lblElevation.Size = new System.Drawing.Size(171, 40);
			this.lblElevation.TabIndex = 193;
			this.lblElevation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(793, 241);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(214, 40);
			this.label4.TabIndex = 192;
			this.label4.Text = "Front Camera Elevation";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblAzimuth
			// 
			this.lblAzimuth.BackColor = System.Drawing.Color.White;
			this.lblAzimuth.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAzimuth.Location = new System.Drawing.Point(1051, 193);
			this.lblAzimuth.Name = "lblAzimuth";
			this.lblAzimuth.Size = new System.Drawing.Size(171, 40);
			this.lblAzimuth.TabIndex = 191;
			this.lblAzimuth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(793, 193);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(214, 40);
			this.label7.TabIndex = 190;
			this.label7.Text = "Front Camera Azimuth";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblRoll
			// 
			this.lblRoll.BackColor = System.Drawing.Color.White;
			this.lblRoll.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRoll.Location = new System.Drawing.Point(1051, 146);
			this.lblRoll.Name = "lblRoll";
			this.lblRoll.Size = new System.Drawing.Size(171, 40);
			this.lblRoll.TabIndex = 189;
			this.lblRoll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(793, 146);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(214, 40);
			this.label8.TabIndex = 188;
			this.label8.Text = "Front Camera Roll";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtPji
			// 
			this.txtPji.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtPji.Location = new System.Drawing.Point(468, 45);
			this.txtPji.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtPji.Multiline = true;
			this.txtPji.Name = "txtPji";
			this.txtPji.Size = new System.Drawing.Size(181, 42);
			this.txtPji.TabIndex = 203;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CustomFormat = "yyyy-mm-dd";
			this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker1.Location = new System.Drawing.Point(42, 3);
			this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(224, 35);
			this.dateTimePicker1.TabIndex = 202;
			this.dateTimePicker1.Value = new System.DateTime(2025, 8, 12, 12, 1, 22, 0);
			this.dateTimePicker1.Visible = false;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// BTN_DATE
			// 
			this.BTN_DATE.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BTN_DATE.Location = new System.Drawing.Point(42, 48);
			this.BTN_DATE.Name = "BTN_DATE";
			this.BTN_DATE.Size = new System.Drawing.Size(204, 42);
			this.BTN_DATE.TabIndex = 208;
			this.BTN_DATE.Text = "-";
			this.BTN_DATE.UseVisualStyleBackColor = true;
			this.BTN_DATE.Click += new System.EventHandler(this.BTN_DATE_Click);
			// 
			// btnPJISearch
			// 
			this.btnPJISearch.BackColor = System.Drawing.Color.LightGray;
			this.btnPJISearch.BorderColor = System.Drawing.Color.Black;
			this.btnPJISearch.BorderSize = ((uint)(1u));
			this.btnPJISearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnPJISearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPJISearch.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPJISearch.ForeColor = System.Drawing.Color.Black;
			this.btnPJISearch.Location = new System.Drawing.Point(655, 45);
			this.btnPJISearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnPJISearch.Name = "btnPJISearch";
			this.btnPJISearch.NormalBackColor = System.Drawing.Color.LightGray;
			this.btnPJISearch.NormalForeColor = System.Drawing.Color.Black;
			this.btnPJISearch.Size = new System.Drawing.Size(101, 42);
			this.btnPJISearch.TabIndex = 207;
			this.btnPJISearch.Text = "Search";
			this.btnPJISearch.UseVisualStyleBackColor = false;
			// 
			// btnDateSearch
			// 
			this.btnDateSearch.BackColor = System.Drawing.Color.LightGray;
			this.btnDateSearch.BorderColor = System.Drawing.Color.Black;
			this.btnDateSearch.BorderSize = ((uint)(1u));
			this.btnDateSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnDateSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDateSearch.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDateSearch.ForeColor = System.Drawing.Color.Black;
			this.btnDateSearch.Location = new System.Drawing.Point(252, 48);
			this.btnDateSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnDateSearch.Name = "btnDateSearch";
			this.btnDateSearch.NormalBackColor = System.Drawing.Color.LightGray;
			this.btnDateSearch.NormalForeColor = System.Drawing.Color.Black;
			this.btnDateSearch.Size = new System.Drawing.Size(101, 42);
			this.btnDateSearch.TabIndex = 206;
			this.btnDateSearch.Text = "Search";
			this.btnDateSearch.UseVisualStyleBackColor = false;
			this.btnDateSearch.Click += new System.EventHandler(this.btnDateSearch_Click_1);
			// 
			// roundLabel2
			// 
			this.roundLabel2.BackColor = System.Drawing.Color.MidnightBlue;
			this.roundLabel2.BackgroundColor = System.Drawing.Color.MidnightBlue;
			this.roundLabel2.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.roundLabel2.BorderRadius = 6;
			this.roundLabel2.BorderSize = 0;
			this.roundLabel2.FlatAppearance.BorderSize = 0;
			this.roundLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.roundLabel2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.roundLabel2.ForeColor = System.Drawing.Color.White;
			this.roundLabel2.Location = new System.Drawing.Point(389, 45);
			this.roundLabel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.roundLabel2.Name = "roundLabel2";
			this.roundLabel2.Size = new System.Drawing.Size(73, 42);
			this.roundLabel2.TabIndex = 205;
			this.roundLabel2.Text = "PJI";
			this.roundLabel2.TextColor = System.Drawing.Color.White;
			this.roundLabel2.UseVisualStyleBackColor = false;
			// 
			// Frm_Result
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1749, 1191);
			this.Controls.Add(this.BTN_DATE);
			this.Controls.Add(this.btnPJISearch);
			this.Controls.Add(this.btnDateSearch);
			this.Controls.Add(this.roundLabel2);
			this.Controls.Add(this.txtPji);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.lblFrontLeftRadarAngle);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.lblFrontRightRadarAngle);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.lblRearLeftRadarAngle);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.lblRearRightRadarAngle);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.lblElevation);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblAzimuth);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lblRoll);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.seqList);
			this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Frm_Result";
			this.Text = "ㄱ";
			this.Load += new System.EventHandler(this.Frm_Result_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView seqList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.Label lblFrontLeftRadarAngle;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label lblFrontRightRadarAngle;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label lblRearLeftRadarAngle;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label lblRearRightRadarAngle;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label lblElevation;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblAzimuth;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblRoll;
		private System.Windows.Forms.Label label8;
		private KI_Controls.CButton btnPJISearch;
		private KI_Controls.CButton btnDateSearch;
		private KI_Controls.RoundLabel roundLabel2;
		private System.Windows.Forms.TextBox txtPji;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Button BTN_DATE;
	}
}