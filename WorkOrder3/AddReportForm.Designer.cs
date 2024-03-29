﻿namespace WorkOrder3
{
    partial class AddReportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddReportForm));
            this.chkFailedPM = new System.Windows.Forms.CheckBox();
            this.grpOtherWorkType = new System.Windows.Forms.GroupBox();
            this.txtOtherWorkType = new System.Windows.Forms.TextBox();
            this.grpFailureEvent = new System.Windows.Forms.GroupBox();
            this.txtPatient = new System.Windows.Forms.TextBox();
            this.cmbFailureEvent = new System.Windows.Forms.ComboBox();
            this.btnAddToReport = new System.Windows.Forms.Button();
            this.txtTechReport = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbRFU = new System.Windows.Forms.ComboBox();
            this.txtComplaint = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbWorkType = new System.Windows.Forms.ComboBox();
            this.dgvShockValues = new System.Windows.Forms.DataGridView();
            this.colLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpShockValues = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvAdditionalTesting = new System.Windows.Forms.DataGridView();
            this.colAdditionalTest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTestValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTestedFunctions = new System.Windows.Forms.DataGridView();
            this.colFunction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTested = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpRepair = new System.Windows.Forms.GroupBox();
            this.btnAddProblemLine = new System.Windows.Forms.Button();
            this.dgvRepair = new System.Windows.Forms.DataGridView();
            this.colProblem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colEditResolution = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colResolution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemoveProblem = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grpPicture = new System.Windows.Forms.GroupBox();
            this.btnCapture = new System.Windows.Forms.Button();
            this.btnTakePicture = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPicturePath = new System.Windows.Forms.TextBox();
            this.btnBrowsePicture = new System.Windows.Forms.Button();
            this.grpFinish = new System.Windows.Forms.GroupBox();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.grpOtherModel = new System.Windows.Forms.GroupBox();
            this.txtOtherModel = new System.Windows.Forms.TextBox();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpOtherWorkType.SuspendLayout();
            this.grpFailureEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShockValues)).BeginInit();
            this.grpShockValues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdditionalTesting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestedFunctions)).BeginInit();
            this.panel1.SuspendLayout();
            this.grpRepair.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepair)).BeginInit();
            this.grpPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpFinish.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.grpOtherModel.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkFailedPM
            // 
            this.chkFailedPM.AutoSize = true;
            this.chkFailedPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFailedPM.ForeColor = System.Drawing.Color.Red;
            this.chkFailedPM.Location = new System.Drawing.Point(398, 19);
            this.chkFailedPM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkFailedPM.Name = "chkFailedPM";
            this.chkFailedPM.Size = new System.Drawing.Size(117, 28);
            this.chkFailedPM.TabIndex = 45;
            this.chkFailedPM.TabStop = false;
            this.chkFailedPM.Text = "Failed PM";
            this.chkFailedPM.UseVisualStyleBackColor = true;
            this.chkFailedPM.Visible = false;
            this.chkFailedPM.CheckedChanged += new System.EventHandler(this.chkFailedPM_CheckedChanged);
            // 
            // grpOtherWorkType
            // 
            this.grpOtherWorkType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOtherWorkType.Controls.Add(this.txtOtherWorkType);
            this.grpOtherWorkType.Location = new System.Drawing.Point(379, 14);
            this.grpOtherWorkType.Margin = new System.Windows.Forms.Padding(4);
            this.grpOtherWorkType.Name = "grpOtherWorkType";
            this.grpOtherWorkType.Padding = new System.Windows.Forms.Padding(4);
            this.grpOtherWorkType.Size = new System.Drawing.Size(655, 60);
            this.grpOtherWorkType.TabIndex = 44;
            this.grpOtherWorkType.TabStop = false;
            this.grpOtherWorkType.Text = "Other Work Type";
            this.grpOtherWorkType.Visible = false;
            // 
            // txtOtherWorkType
            // 
            this.txtOtherWorkType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOtherWorkType.Location = new System.Drawing.Point(8, 23);
            this.txtOtherWorkType.Margin = new System.Windows.Forms.Padding(4);
            this.txtOtherWorkType.Name = "txtOtherWorkType";
            this.txtOtherWorkType.Size = new System.Drawing.Size(639, 22);
            this.txtOtherWorkType.TabIndex = 2;
            // 
            // grpFailureEvent
            // 
            this.grpFailureEvent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFailureEvent.Controls.Add(this.txtPatient);
            this.grpFailureEvent.Controls.Add(this.cmbFailureEvent);
            this.grpFailureEvent.Location = new System.Drawing.Point(12, 1470);
            this.grpFailureEvent.Margin = new System.Windows.Forms.Padding(4);
            this.grpFailureEvent.Name = "grpFailureEvent";
            this.grpFailureEvent.Padding = new System.Windows.Forms.Padding(4);
            this.grpFailureEvent.Size = new System.Drawing.Size(1040, 90);
            this.grpFailureEvent.TabIndex = 3;
            this.grpFailureEvent.TabStop = false;
            this.grpFailureEvent.Text = "Failure Event";
            this.grpFailureEvent.Visible = false;
            // 
            // txtPatient
            // 
            this.txtPatient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPatient.Location = new System.Drawing.Point(17, 54);
            this.txtPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPatient.Name = "txtPatient";
            this.txtPatient.Size = new System.Drawing.Size(1015, 22);
            this.txtPatient.TabIndex = 17;
            this.txtPatient.TabStop = false;
            this.txtPatient.Visible = false;
            // 
            // cmbFailureEvent
            // 
            this.cmbFailureEvent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFailureEvent.DropDownWidth = 350;
            this.cmbFailureEvent.FormattingEnabled = true;
            this.cmbFailureEvent.Items.AddRange(new object[] {
            "During patient treatment",
            "During biomed testing or routine PM",
            "During shift check",
            "During the incoming inspection of the product",
            "During training by facility staff",
            "During training by ZOLL",
            "Other (Explained in the Service Request)",
            "Unknown"});
            this.cmbFailureEvent.Location = new System.Drawing.Point(17, 23);
            this.cmbFailureEvent.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFailureEvent.Name = "cmbFailureEvent";
            this.cmbFailureEvent.Size = new System.Drawing.Size(1015, 24);
            this.cmbFailureEvent.TabIndex = 12;
            // 
            // btnAddToReport
            // 
            this.btnAddToReport.Location = new System.Drawing.Point(17, 22);
            this.btnAddToReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddToReport.Name = "btnAddToReport";
            this.btnAddToReport.Size = new System.Drawing.Size(322, 76);
            this.btnAddToReport.TabIndex = 14;
            this.btnAddToReport.Text = "Add to Report";
            this.btnAddToReport.UseVisualStyleBackColor = true;
            this.btnAddToReport.Click += new System.EventHandler(this.btnAddToReport_Click);
            // 
            // txtTechReport
            // 
            this.txtTechReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTechReport.Location = new System.Drawing.Point(115, 242);
            this.txtTechReport.Margin = new System.Windows.Forms.Padding(4);
            this.txtTechReport.Multiline = true;
            this.txtTechReport.Name = "txtTechReport";
            this.txtTechReport.Size = new System.Drawing.Size(908, 65);
            this.txtTechReport.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(21, 247);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 48);
            this.label14.TabIndex = 43;
            this.label14.Text = "Tech Report";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(17, 158);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 21);
            this.label13.TabIndex = 42;
            this.label13.Text = "RFU Status";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbRFU
            // 
            this.cmbRFU.FormattingEnabled = true;
            this.cmbRFU.Items.AddRange(new object[] {
            "Ready",
            "Not Ready",
            "None",
            "Unknown"});
            this.cmbRFU.Location = new System.Drawing.Point(115, 158);
            this.cmbRFU.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRFU.Name = "cmbRFU";
            this.cmbRFU.Size = new System.Drawing.Size(255, 24);
            this.cmbRFU.TabIndex = 6;
            // 
            // txtComplaint
            // 
            this.txtComplaint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComplaint.Location = new System.Drawing.Point(115, 190);
            this.txtComplaint.Margin = new System.Windows.Forms.Padding(4);
            this.txtComplaint.Multiline = true;
            this.txtComplaint.Name = "txtComplaint";
            this.txtComplaint.Size = new System.Drawing.Size(908, 46);
            this.txtComplaint.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(21, 190);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 21);
            this.label12.TabIndex = 40;
            this.label12.Text = "Complaint";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSerial
            // 
            this.txtSerial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSerial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSerial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSerial.Location = new System.Drawing.Point(115, 97);
            this.txtSerial.Margin = new System.Windows.Forms.Padding(4);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(255, 22);
            this.txtSerial.TabIndex = 3;
            this.txtSerial.Leave += new System.EventHandler(this.txtSerial_Leave_1);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(17, 97);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 20);
            this.label10.TabIndex = 33;
            this.label10.Text = "Serial Num";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(17, 36);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 18);
            this.label9.TabIndex = 34;
            this.label9.Text = "Work Type";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbWorkType
            // 
            this.cmbWorkType.FormattingEnabled = true;
            this.cmbWorkType.Items.AddRange(new object[] {
            "PM",
            "Repair",
            "Repair and PM",
            "Defib Evaluation",
            "Software Upgrade",
            "Config Change",
            "Training",
            "PR Visit",
            "Other..."});
            this.cmbWorkType.Location = new System.Drawing.Point(115, 34);
            this.cmbWorkType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbWorkType.Name = "cmbWorkType";
            this.cmbWorkType.Size = new System.Drawing.Size(255, 24);
            this.cmbWorkType.TabIndex = 1;
            this.cmbWorkType.SelectedIndexChanged += new System.EventHandler(this.cmbWorkType_SelectedIndexChanged);
            // 
            // dgvShockValues
            // 
            this.dgvShockValues.AllowUserToAddRows = false;
            this.dgvShockValues.AllowUserToDeleteRows = false;
            this.dgvShockValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShockValues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLevel,
            this.colValue});
            this.dgvShockValues.Location = new System.Drawing.Point(19, 54);
            this.dgvShockValues.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvShockValues.Name = "dgvShockValues";
            this.dgvShockValues.RowHeadersWidth = 51;
            this.dgvShockValues.RowTemplate.Height = 24;
            this.dgvShockValues.Size = new System.Drawing.Size(496, 274);
            this.dgvShockValues.TabIndex = 9;
            // 
            // colLevel
            // 
            this.colLevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.colLevel.DefaultCellStyle = dataGridViewCellStyle1;
            this.colLevel.HeaderText = "Level";
            this.colLevel.MinimumWidth = 6;
            this.colLevel.Name = "colLevel";
            this.colLevel.ReadOnly = true;
            // 
            // colValue
            // 
            this.colValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colValue.HeaderText = "Value";
            this.colValue.MinimumWidth = 6;
            this.colValue.Name = "colValue";
            this.colValue.Width = 73;
            // 
            // grpShockValues
            // 
            this.grpShockValues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpShockValues.Controls.Add(this.label4);
            this.grpShockValues.Controls.Add(this.dgvAdditionalTesting);
            this.grpShockValues.Controls.Add(this.dgvTestedFunctions);
            this.grpShockValues.Controls.Add(this.label3);
            this.grpShockValues.Controls.Add(this.label2);
            this.grpShockValues.Controls.Add(this.dgvShockValues);
            this.grpShockValues.Controls.Add(this.chkFailedPM);
            this.grpShockValues.Location = new System.Drawing.Point(12, 617);
            this.grpShockValues.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpShockValues.Name = "grpShockValues";
            this.grpShockValues.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpShockValues.Size = new System.Drawing.Size(1040, 847);
            this.grpShockValues.TabIndex = 2;
            this.grpShockValues.TabStop = false;
            this.grpShockValues.Text = "PM";
            this.grpShockValues.Visible = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(13, 633);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(435, 17);
            this.label4.TabIndex = 53;
            this.label4.Text = "Additional Testing (If applicable)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvAdditionalTesting
            // 
            this.dgvAdditionalTesting.AllowUserToDeleteRows = false;
            this.dgvAdditionalTesting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdditionalTesting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAdditionalTest,
            this.colTestValue});
            this.dgvAdditionalTesting.Location = new System.Drawing.Point(17, 654);
            this.dgvAdditionalTesting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAdditionalTesting.Name = "dgvAdditionalTesting";
            this.dgvAdditionalTesting.RowHeadersWidth = 51;
            this.dgvAdditionalTesting.RowTemplate.Height = 24;
            this.dgvAdditionalTesting.Size = new System.Drawing.Size(583, 159);
            this.dgvAdditionalTesting.TabIndex = 11;
            // 
            // colAdditionalTest
            // 
            this.colAdditionalTest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAdditionalTest.HeaderText = "Test Name and Range";
            this.colAdditionalTest.MinimumWidth = 6;
            this.colAdditionalTest.Name = "colAdditionalTest";
            // 
            // colTestValue
            // 
            this.colTestValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTestValue.HeaderText = "Value";
            this.colTestValue.MinimumWidth = 6;
            this.colTestValue.Name = "colTestValue";
            this.colTestValue.Width = 73;
            // 
            // dgvTestedFunctions
            // 
            this.dgvTestedFunctions.AllowUserToAddRows = false;
            this.dgvTestedFunctions.AllowUserToDeleteRows = false;
            this.dgvTestedFunctions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestedFunctions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFunction,
            this.colTested});
            this.dgvTestedFunctions.Location = new System.Drawing.Point(19, 368);
            this.dgvTestedFunctions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTestedFunctions.Name = "dgvTestedFunctions";
            this.dgvTestedFunctions.RowHeadersWidth = 51;
            this.dgvTestedFunctions.RowTemplate.Height = 24;
            this.dgvTestedFunctions.Size = new System.Drawing.Size(496, 241);
            this.dgvTestedFunctions.TabIndex = 10;
            // 
            // colFunction
            // 
            this.colFunction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.colFunction.DefaultCellStyle = dataGridViewCellStyle2;
            this.colFunction.HeaderText = "Function";
            this.colFunction.MinimumWidth = 6;
            this.colFunction.Name = "colFunction";
            this.colFunction.ReadOnly = true;
            // 
            // colTested
            // 
            this.colTested.FalseValue = "False";
            this.colTested.HeaderText = "Tested?";
            this.colTested.MinimumWidth = 6;
            this.colTested.Name = "colTested";
            this.colTested.TrueValue = "True";
            this.colTested.Width = 125;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 348);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(399, 18);
            this.label3.TabIndex = 51;
            this.label3.Text = "Tested Functions";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 18);
            this.label2.TabIndex = 50;
            this.label2.Text = "Shock/Pace Values";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(0, 50);
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(0, 75);
            this.panel1.Controls.Add(this.grpRepair);
            this.panel1.Controls.Add(this.grpPicture);
            this.panel1.Controls.Add(this.grpFinish);
            this.panel1.Controls.Add(this.grpInfo);
            this.panel1.Controls.Add(this.grpShockValues);
            this.panel1.Controls.Add(this.grpFailureEvent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 667);
            this.panel1.TabIndex = 48;
            // 
            // grpRepair
            // 
            this.grpRepair.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRepair.Controls.Add(this.btnAddProblemLine);
            this.grpRepair.Controls.Add(this.dgvRepair);
            this.grpRepair.Location = new System.Drawing.Point(12, 330);
            this.grpRepair.Name = "grpRepair";
            this.grpRepair.Size = new System.Drawing.Size(1040, 282);
            this.grpRepair.TabIndex = 6;
            this.grpRepair.TabStop = false;
            this.grpRepair.Text = "Repair";
            // 
            // btnAddProblemLine
            // 
            this.btnAddProblemLine.Location = new System.Drawing.Point(20, 204);
            this.btnAddProblemLine.Name = "btnAddProblemLine";
            this.btnAddProblemLine.Size = new System.Drawing.Size(182, 46);
            this.btnAddProblemLine.TabIndex = 1;
            this.btnAddProblemLine.Text = "Add Line";
            this.btnAddProblemLine.UseVisualStyleBackColor = true;
            this.btnAddProblemLine.Click += new System.EventHandler(this.btnAddProblemLine_Click);
            // 
            // dgvRepair
            // 
            this.dgvRepair.AllowUserToAddRows = false;
            this.dgvRepair.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRepair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepair.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProblem,
            this.colStatus,
            this.colEditResolution,
            this.colResolution,
            this.colRemoveProblem});
            this.dgvRepair.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvRepair.Location = new System.Drawing.Point(19, 33);
            this.dgvRepair.Name = "dgvRepair";
            this.dgvRepair.RowHeadersWidth = 51;
            this.dgvRepair.RowTemplate.Height = 24;
            this.dgvRepair.Size = new System.Drawing.Size(1005, 165);
            this.dgvRepair.TabIndex = 0;
            this.dgvRepair.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRepair_CellContentClick);
            // 
            // colProblem
            // 
            this.colProblem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProblem.HeaderText = "Problem";
            this.colProblem.MinimumWidth = 6;
            this.colProblem.Name = "colProblem";
            // 
            // colStatus
            // 
            this.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colStatus.HeaderText = "Status";
            this.colStatus.Items.AddRange(new object[] {
            "verified",
            "observed but not verified",
            "observed in the data file but not verified",
            "observed in the error log but not verified",
            "not observed",
            "replaced as part of the repair process"});
            this.colStatus.MinimumWidth = 70;
            this.colStatus.Name = "colStatus";
            this.colStatus.Width = 70;
            // 
            // colEditResolution
            // 
            this.colEditResolution.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colEditResolution.HeaderText = "Edit Resolution";
            this.colEditResolution.MinimumWidth = 6;
            this.colEditResolution.Name = "colEditResolution";
            this.colEditResolution.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEditResolution.Text = "Edit Resolution";
            this.colEditResolution.UseColumnTextForButtonValue = true;
            this.colEditResolution.Width = 98;
            // 
            // colResolution
            // 
            this.colResolution.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colResolution.HeaderText = "Resolution";
            this.colResolution.MinimumWidth = 6;
            this.colResolution.Name = "colResolution";
            this.colResolution.ReadOnly = true;
            this.colResolution.Width = 104;
            // 
            // colRemoveProblem
            // 
            this.colRemoveProblem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colRemoveProblem.HeaderText = "Remove";
            this.colRemoveProblem.MinimumWidth = 6;
            this.colRemoveProblem.Name = "colRemoveProblem";
            this.colRemoveProblem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colRemoveProblem.Text = "Remove";
            this.colRemoveProblem.UseColumnTextForButtonValue = true;
            this.colRemoveProblem.Width = 66;
            // 
            // grpPicture
            // 
            this.grpPicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPicture.Controls.Add(this.btnCapture);
            this.grpPicture.Controls.Add(this.btnTakePicture);
            this.grpPicture.Controls.Add(this.pictureBox1);
            this.grpPicture.Controls.Add(this.txtPicturePath);
            this.grpPicture.Controls.Add(this.btnBrowsePicture);
            this.grpPicture.Location = new System.Drawing.Point(12, 1566);
            this.grpPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPicture.Name = "grpPicture";
            this.grpPicture.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPicture.Size = new System.Drawing.Size(1040, 96);
            this.grpPicture.TabIndex = 4;
            this.grpPicture.TabStop = false;
            this.grpPicture.Text = "Add Picture (Optional)";
            // 
            // btnCapture
            // 
            this.btnCapture.Enabled = false;
            this.btnCapture.Location = new System.Drawing.Point(341, 60);
            this.btnCapture.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(151, 28);
            this.btnCapture.TabIndex = 44;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Visible = false;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // btnTakePicture
            // 
            this.btnTakePicture.Location = new System.Drawing.Point(156, 60);
            this.btnTakePicture.Margin = new System.Windows.Forms.Padding(4);
            this.btnTakePicture.Name = "btnTakePicture";
            this.btnTakePicture.Size = new System.Drawing.Size(183, 28);
            this.btnTakePicture.TabIndex = 43;
            this.btnTakePicture.Text = "Start Camera";
            this.btnTakePicture.UseVisualStyleBackColor = true;
            this.btnTakePicture.Visible = false;
            this.btnTakePicture.Click += new System.EventHandler(this.btnTakePicture_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 95);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(747, 491);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // txtPicturePath
            // 
            this.txtPicturePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPicturePath.Location = new System.Drawing.Point(17, 30);
            this.txtPicturePath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPicturePath.Name = "txtPicturePath";
            this.txtPicturePath.Size = new System.Drawing.Size(1012, 22);
            this.txtPicturePath.TabIndex = 13;
            // 
            // btnBrowsePicture
            // 
            this.btnBrowsePicture.Location = new System.Drawing.Point(17, 60);
            this.btnBrowsePicture.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowsePicture.Name = "btnBrowsePicture";
            this.btnBrowsePicture.Size = new System.Drawing.Size(131, 27);
            this.btnBrowsePicture.TabIndex = 41;
            this.btnBrowsePicture.TabStop = false;
            this.btnBrowsePicture.Text = "Browse";
            this.btnBrowsePicture.UseVisualStyleBackColor = true;
            this.btnBrowsePicture.Click += new System.EventHandler(this.btnBrowsePicture_Click);
            // 
            // grpFinish
            // 
            this.grpFinish.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFinish.Controls.Add(this.btnAddToReport);
            this.grpFinish.Location = new System.Drawing.Point(12, 1678);
            this.grpFinish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpFinish.Name = "grpFinish";
            this.grpFinish.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpFinish.Size = new System.Drawing.Size(1040, 117);
            this.grpFinish.TabIndex = 5;
            this.grpFinish.TabStop = false;
            // 
            // grpInfo
            // 
            this.grpInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInfo.Controls.Add(this.grpOtherModel);
            this.grpInfo.Controls.Add(this.cmbModel);
            this.grpInfo.Controls.Add(this.label9);
            this.grpInfo.Controls.Add(this.label1);
            this.grpInfo.Controls.Add(this.txtSerial);
            this.grpInfo.Controls.Add(this.cmbRFU);
            this.grpInfo.Controls.Add(this.label10);
            this.grpInfo.Controls.Add(this.txtTechReport);
            this.grpInfo.Controls.Add(this.label12);
            this.grpInfo.Controls.Add(this.label13);
            this.grpInfo.Controls.Add(this.txtComplaint);
            this.grpInfo.Controls.Add(this.grpOtherWorkType);
            this.grpInfo.Controls.Add(this.cmbWorkType);
            this.grpInfo.Controls.Add(this.label14);
            this.grpInfo.Location = new System.Drawing.Point(12, 12);
            this.grpInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpInfo.Size = new System.Drawing.Size(1040, 313);
            this.grpInfo.TabIndex = 1;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Work Information";
            // 
            // grpOtherModel
            // 
            this.grpOtherModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOtherModel.Controls.Add(this.txtOtherModel);
            this.grpOtherModel.Location = new System.Drawing.Point(377, 105);
            this.grpOtherModel.Margin = new System.Windows.Forms.Padding(4);
            this.grpOtherModel.Name = "grpOtherModel";
            this.grpOtherModel.Padding = new System.Windows.Forms.Padding(4);
            this.grpOtherModel.Size = new System.Drawing.Size(655, 60);
            this.grpOtherModel.TabIndex = 45;
            this.grpOtherModel.TabStop = false;
            this.grpOtherModel.Text = "Other Model";
            this.grpOtherModel.Visible = false;
            // 
            // txtOtherModel
            // 
            this.txtOtherModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOtherModel.Location = new System.Drawing.Point(8, 23);
            this.txtOtherModel.Margin = new System.Windows.Forms.Padding(4);
            this.txtOtherModel.Name = "txtOtherModel";
            this.txtOtherModel.Size = new System.Drawing.Size(639, 22);
            this.txtOtherModel.TabIndex = 5;
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Items.AddRange(new object[] {
            "AED-3",
            "AED-PLUS",
            "AED-PRO",
            "E-SERIES",
            "G3",
            "G5",
            "M-SERIES",
            "PROPAQ",
            "R-SERIES",
            "X-SERIES",
            "VENTILATOR",
            "Other..."});
            this.cmbModel.Location = new System.Drawing.Point(115, 126);
            this.cmbModel.Margin = new System.Windows.Forms.Padding(4);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(255, 24);
            this.cmbModel.TabIndex = 4;
            this.cmbModel.SelectedIndexChanged += new System.EventHandler(this.cmbModel_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(17, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Model";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 667);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddReportForm";
            this.Text = "Add Report";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddReportForm_FormClosing);
            this.Load += new System.EventHandler(this.AddReportForm_Load);
            this.grpOtherWorkType.ResumeLayout(false);
            this.grpOtherWorkType.PerformLayout();
            this.grpFailureEvent.ResumeLayout(false);
            this.grpFailureEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShockValues)).EndInit();
            this.grpShockValues.ResumeLayout(false);
            this.grpShockValues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdditionalTesting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestedFunctions)).EndInit();
            this.panel1.ResumeLayout(false);
            this.grpRepair.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepair)).EndInit();
            this.grpPicture.ResumeLayout(false);
            this.grpPicture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpFinish.ResumeLayout(false);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.grpOtherModel.ResumeLayout(false);
            this.grpOtherModel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkFailedPM;
        private System.Windows.Forms.GroupBox grpOtherWorkType;
        private System.Windows.Forms.TextBox txtOtherWorkType;
        private System.Windows.Forms.GroupBox grpFailureEvent;
        private System.Windows.Forms.TextBox txtPatient;
        private System.Windows.Forms.ComboBox cmbFailureEvent;
        private System.Windows.Forms.Button btnAddToReport;
        private System.Windows.Forms.TextBox txtTechReport;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbRFU;
        private System.Windows.Forms.TextBox txtComplaint;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbWorkType;
        private System.Windows.Forms.DataGridView dgvShockValues;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
        private System.Windows.Forms.GroupBox grpShockValues;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpFinish;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.GroupBox grpOtherModel;
        private System.Windows.Forms.TextBox txtOtherModel;
        private System.Windows.Forms.DataGridView dgvTestedFunctions;
        private System.Windows.Forms.GroupBox grpPicture;
        private System.Windows.Forms.TextBox txtPicturePath;
        private System.Windows.Forms.Button btnBrowsePicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTakePicture;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvAdditionalTesting;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdditionalTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTestValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFunction;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colTested;
        private System.Windows.Forms.GroupBox grpRepair;
        private System.Windows.Forms.DataGridView dgvRepair;
        private System.Windows.Forms.Button btnAddProblemLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProblem;
        private System.Windows.Forms.DataGridViewComboBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewButtonColumn colEditResolution;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResolution;
        private System.Windows.Forms.DataGridViewButtonColumn colRemoveProblem;
    }
}