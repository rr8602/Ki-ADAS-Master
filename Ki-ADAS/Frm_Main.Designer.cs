namespace Ki_ADAS
{
    partial class Frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label19 = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.seqList = new System.Windows.Forms.ListView();
            this.label30 = new System.Windows.Forms.Label();
            this.lb_Message = new System.Windows.Forms.ListBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_model = new System.Windows.Forms.Label();
            this.lbl_wheelbase = new System.Windows.Forms.Label();
            this.lbl_pji = new System.Windows.Forms.Label();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.GB_GenInfo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblElevation = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAzimuth = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblRoll = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblRearRightRadarAngle = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblRearLeftRadarAngle = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblFrontRightRadarAngle = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblFrontLeftRadarAngle = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSimulator = new System.Windows.Forms.Button();
            this.GB_GenInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "AcceptNo";
            this.columnHeader1.Text = "AcceptNo";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Tag = "PJI";
            this.columnHeader2.Text = "PJI";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Tag = "Model";
            this.columnHeader3.Text = "Model";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 295;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Yellow;
            this.label19.Location = new System.Drawing.Point(-484, -300);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(802, 94);
            this.label19.TabIndex = 162;
            this.label19.Text = "Vehicle List";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.Color.Cornsilk;
            this.lbl_title.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(318, -300);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(966, 96);
            this.lbl_title.TabIndex = 159;
            this.lbl_title.Text = "PROCESS INFO";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Cornsilk;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1015, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(759, 46);
            this.label1.TabIndex = 164;
            this.label1.Text = "Process Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seqList
            // 
            this.seqList.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.seqList.BackColor = System.Drawing.Color.SeaShell;
            this.seqList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seqList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.seqList.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seqList.FullRowSelect = true;
            this.seqList.GridLines = true;
            this.seqList.HideSelection = false;
            this.seqList.Location = new System.Drawing.Point(1, 55);
            this.seqList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.seqList.MultiSelect = false;
            this.seqList.Name = "seqList";
            this.seqList.OwnerDraw = true;
            this.seqList.Size = new System.Drawing.Size(996, 659);
            this.seqList.TabIndex = 170;
            this.seqList.UseCompatibleStateImageBehavior = false;
            this.seqList.View = System.Windows.Forms.View.Details;
            this.seqList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.seqList_MouseClick);
            // 
            // label30
            // 
            this.label30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label30.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.Yellow;
            this.label30.Location = new System.Drawing.Point(2, 5);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(995, 46);
            this.label30.TabIndex = 167;
            this.label30.Text = "Vehicle List";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Message
            // 
            this.lb_Message.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Message.FormattingEnabled = true;
            this.lb_Message.ItemHeight = 27;
            this.lb_Message.Location = new System.Drawing.Point(1, 722);
            this.lb_Message.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_Message.Name = "lb_Message";
            this.lb_Message.Size = new System.Drawing.Size(996, 166);
            this.lb_Message.TabIndex = 163;
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnStart.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.Location = new System.Drawing.Point(1011, 720);
            this.BtnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(745, 80);
            this.BtnStart.TabIndex = 172;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.BackColor = System.Drawing.Color.Gray;
            this.BtnStop.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStop.Location = new System.Drawing.Point(1011, 804);
            this.BtnStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(745, 84);
            this.BtnStop.TabIndex = 173;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = false;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(15, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(181, 42);
            this.label13.TabIndex = 11;
            this.label13.Text = "Model";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 42);
            this.label2.TabIndex = 12;
            this.label2.Text = "Wheelbase";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 42);
            this.label5.TabIndex = 15;
            this.label5.Text = "PJI";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 42);
            this.label6.TabIndex = 16;
            this.label6.Text = "Barcode";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_model
            // 
            this.lbl_model.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_model.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_model.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_model.Location = new System.Drawing.Point(202, 30);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(413, 47);
            this.lbl_model.TabIndex = 17;
            this.lbl_model.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_wheelbase
            // 
            this.lbl_wheelbase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_wheelbase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_wheelbase.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wheelbase.Location = new System.Drawing.Point(202, 85);
            this.lbl_wheelbase.Name = "lbl_wheelbase";
            this.lbl_wheelbase.Size = new System.Drawing.Size(413, 47);
            this.lbl_wheelbase.TabIndex = 18;
            this.lbl_wheelbase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_pji
            // 
            this.lbl_pji.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_pji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_pji.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pji.Location = new System.Drawing.Point(202, 138);
            this.lbl_pji.Name = "lbl_pji";
            this.lbl_pji.Size = new System.Drawing.Size(413, 47);
            this.lbl_pji.TabIndex = 21;
            this.lbl_pji.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_barcode
            // 
            this.txt_barcode.BackColor = System.Drawing.SystemColors.Window;
            this.txt_barcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_barcode.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_barcode.Location = new System.Drawing.Point(202, 192);
            this.txt_barcode.Margin = new System.Windows.Forms.Padding(0);
            this.txt_barcode.Multiline = true;
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Size = new System.Drawing.Size(413, 47);
            this.txt_barcode.TabIndex = 22;
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.Silver;
            this.btn_register.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.Color.Teal;
            this.btn_register.Location = new System.Drawing.Point(630, 192);
            this.btn_register.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(111, 49);
            this.btn_register.TabIndex = 168;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // GB_GenInfo
            // 
            this.GB_GenInfo.Controls.Add(this.btn_register);
            this.GB_GenInfo.Controls.Add(this.txt_barcode);
            this.GB_GenInfo.Controls.Add(this.lbl_pji);
            this.GB_GenInfo.Controls.Add(this.lbl_wheelbase);
            this.GB_GenInfo.Controls.Add(this.lbl_model);
            this.GB_GenInfo.Controls.Add(this.label6);
            this.GB_GenInfo.Controls.Add(this.label5);
            this.GB_GenInfo.Controls.Add(this.label2);
            this.GB_GenInfo.Controls.Add(this.label13);
            this.GB_GenInfo.Font = new System.Drawing.Font("Arial", 15F);
            this.GB_GenInfo.Location = new System.Drawing.Point(1015, 44);
            this.GB_GenInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GB_GenInfo.Name = "GB_GenInfo";
            this.GB_GenInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GB_GenInfo.Size = new System.Drawing.Size(759, 263);
            this.GB_GenInfo.TabIndex = 165;
            this.GB_GenInfo.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Cornsilk;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1016, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(759, 46);
            this.label3.TabIndex = 164;
            this.label3.Text = "Result Information";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblElevation
            // 
            this.lblElevation.BackColor = System.Drawing.Color.White;
            this.lblElevation.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElevation.Location = new System.Drawing.Point(1284, 513);
            this.lblElevation.Name = "lblElevation";
            this.lblElevation.Size = new System.Drawing.Size(463, 40);
            this.lblElevation.TabIndex = 179;
            this.lblElevation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1026, 513);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 40);
            this.label4.TabIndex = 178;
            this.label4.Text = "Front Camera Elevation";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAzimuth
            // 
            this.lblAzimuth.BackColor = System.Drawing.Color.White;
            this.lblAzimuth.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAzimuth.Location = new System.Drawing.Point(1284, 465);
            this.lblAzimuth.Name = "lblAzimuth";
            this.lblAzimuth.Size = new System.Drawing.Size(463, 40);
            this.lblAzimuth.TabIndex = 177;
            this.lblAzimuth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1026, 465);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(260, 40);
            this.label7.TabIndex = 176;
            this.label7.Text = "Front Camera Azimuth";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRoll
            // 
            this.lblRoll.BackColor = System.Drawing.Color.White;
            this.lblRoll.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoll.Location = new System.Drawing.Point(1284, 418);
            this.lblRoll.Name = "lblRoll";
            this.lblRoll.Size = new System.Drawing.Size(463, 40);
            this.lblRoll.TabIndex = 175;
            this.lblRoll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1026, 418);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 40);
            this.label8.TabIndex = 174;
            this.label8.Text = "Front Camera Roll";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRearRightRadarAngle
            // 
            this.lblRearRightRadarAngle.BackColor = System.Drawing.Color.White;
            this.lblRearRightRadarAngle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRearRightRadarAngle.Location = new System.Drawing.Point(1284, 570);
            this.lblRearRightRadarAngle.Name = "lblRearRightRadarAngle";
            this.lblRearRightRadarAngle.Size = new System.Drawing.Size(110, 40);
            this.lblRearRightRadarAngle.TabIndex = 181;
            this.lblRearRightRadarAngle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1026, 570);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(241, 40);
            this.label9.TabIndex = 180;
            this.label9.Text = "[Radar] Rear Right Angle";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRearLeftRadarAngle
            // 
            this.lblRearLeftRadarAngle.BackColor = System.Drawing.Color.White;
            this.lblRearLeftRadarAngle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRearLeftRadarAngle.Location = new System.Drawing.Point(1284, 620);
            this.lblRearLeftRadarAngle.Name = "lblRearLeftRadarAngle";
            this.lblRearLeftRadarAngle.Size = new System.Drawing.Size(110, 40);
            this.lblRearLeftRadarAngle.TabIndex = 183;
            this.lblRearLeftRadarAngle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1026, 618);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(241, 40);
            this.label12.TabIndex = 182;
            this.label12.Text = "[Radar] Rear Left Angle";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFrontRightRadarAngle
            // 
            this.lblFrontRightRadarAngle.BackColor = System.Drawing.Color.White;
            this.lblFrontRightRadarAngle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrontRightRadarAngle.Location = new System.Drawing.Point(1633, 570);
            this.lblFrontRightRadarAngle.Name = "lblFrontRightRadarAngle";
            this.lblFrontRightRadarAngle.Size = new System.Drawing.Size(110, 40);
            this.lblFrontRightRadarAngle.TabIndex = 185;
            this.lblFrontRightRadarAngle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1406, 570);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(225, 40);
            this.label10.TabIndex = 184;
            this.label10.Text = "[Radar] Front Right Angle";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFrontLeftRadarAngle
            // 
            this.lblFrontLeftRadarAngle.BackColor = System.Drawing.Color.White;
            this.lblFrontLeftRadarAngle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrontLeftRadarAngle.Location = new System.Drawing.Point(1633, 620);
            this.lblFrontLeftRadarAngle.Name = "lblFrontLeftRadarAngle";
            this.lblFrontLeftRadarAngle.Size = new System.Drawing.Size(110, 40);
            this.lblFrontLeftRadarAngle.TabIndex = 187;
            this.lblFrontLeftRadarAngle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1406, 620);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(225, 40);
            this.label11.TabIndex = 186;
            this.label11.Text = "[Radar] Front Left Angle";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(1017, 384);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 290);
            this.groupBox1.TabIndex = 188;
            this.groupBox1.TabStop = false;
            // 
            // BtnSimulator
            // 
            this.BtnSimulator.Location = new System.Drawing.Point(1015, 683);
            this.BtnSimulator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSimulator.Name = "BtnSimulator";
            this.BtnSimulator.Size = new System.Drawing.Size(150, 31);
            this.BtnSimulator.TabIndex = 189;
            this.BtnSimulator.Text = "Simulator";
            this.BtnSimulator.UseVisualStyleBackColor = true;
            this.BtnSimulator.Click += new System.EventHandler(this.BtnSimulator_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1788, 934);
            this.Controls.Add(this.BtnSimulator);
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
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seqList);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.lb_Message);
            this.Controls.Add(this.GB_GenInfo);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_Main";
            this.Text = "Frm_Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Main_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.GB_GenInfo.ResumeLayout(false);
            this.GB_GenInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView seqList;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.ListBox lb_Message;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lbl_model;
		private System.Windows.Forms.Label lbl_wheelbase;
		private System.Windows.Forms.Label lbl_pji;
		private System.Windows.Forms.TextBox txt_barcode;
		private System.Windows.Forms.Button btn_register;
		private System.Windows.Forms.GroupBox GB_GenInfo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblElevation;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblAzimuth;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblRoll;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lblRearRightRadarAngle;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label lblRearLeftRadarAngle;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label lblFrontRightRadarAngle;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label lblFrontLeftRadarAngle;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnSimulator;
    }
}