namespace WorkOrder3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.workOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWorkOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWorkOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadWorkOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTechNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoCheckOutTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.grpClosure = new System.Windows.Forms.GroupBox();
            this.picSignature = new System.Windows.Forms.PictureBox();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.chkSignature = new System.Windows.Forms.CheckBox();
            this.grpReport = new System.Windows.Forms.GroupBox();
            this.grpOtherWorkType = new System.Windows.Forms.GroupBox();
            this.txtOtherWorkType = new System.Windows.Forms.TextBox();
            this.grpFailureEvent = new System.Windows.Forms.GroupBox();
            this.txtPatient = new System.Windows.Forms.TextBox();
            this.cmbFailureEvent = new System.Windows.Forms.ComboBox();
            this.btnAddToReport = new System.Windows.Forms.Button();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.colSerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPartNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWorkType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComplaint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTechReport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRFU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFailureMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQAInformation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtTechReport = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbRFU = new System.Windows.Forms.ComboBox();
            this.txtComplaint = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPartNumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbWorkType = new System.Windows.Forms.ComboBox();
            this.grpWorkOrderInformation = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.lblWorkOrderNumber = new System.Windows.Forms.Label();
            this.grpCustomerInformation = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPreset = new System.Windows.Forms.ComboBox();
            this.txtPO = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtContactEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContactPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerSite = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkFailedPM = new System.Windows.Forms.CheckBox();
            this.menuStripMain.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.grpClosure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSignature)).BeginInit();
            this.grpReport.SuspendLayout();
            this.grpOtherWorkType.SuspendLayout();
            this.grpFailureEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.grpWorkOrderInformation.SuspendLayout();
            this.grpCustomerInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workOrdersToolStripMenuItem,
            this.editToolStripMenuItem,
            this.customersToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(1111, 28);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // workOrdersToolStripMenuItem
            // 
            this.workOrdersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWorkOrderToolStripMenuItem,
            this.saveWorkOrderToolStripMenuItem,
            this.loadWorkOrderToolStripMenuItem});
            this.workOrdersToolStripMenuItem.Name = "workOrdersToolStripMenuItem";
            this.workOrdersToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.workOrdersToolStripMenuItem.Text = "File";
            // 
            // newWorkOrderToolStripMenuItem
            // 
            this.newWorkOrderToolStripMenuItem.Name = "newWorkOrderToolStripMenuItem";
            this.newWorkOrderToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.newWorkOrderToolStripMenuItem.Text = "New";
            // 
            // saveWorkOrderToolStripMenuItem
            // 
            this.saveWorkOrderToolStripMenuItem.Name = "saveWorkOrderToolStripMenuItem";
            this.saveWorkOrderToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.saveWorkOrderToolStripMenuItem.Text = "Save";
            this.saveWorkOrderToolStripMenuItem.Click += new System.EventHandler(this.saveWorkOrderToolStripMenuItem_Click);
            // 
            // loadWorkOrderToolStripMenuItem
            // 
            this.loadWorkOrderToolStripMenuItem.Name = "loadWorkOrderToolStripMenuItem";
            this.loadWorkOrderToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.loadWorkOrderToolStripMenuItem.Text = "Load";
            this.loadWorkOrderToolStripMenuItem.Click += new System.EventHandler(this.loadWorkOrderToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeTechNameToolStripMenuItem,
            this.autoCheckOutTimeToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // changeTechNameToolStripMenuItem
            // 
            this.changeTechNameToolStripMenuItem.Name = "changeTechNameToolStripMenuItem";
            this.changeTechNameToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.changeTechNameToolStripMenuItem.Text = "Change Tech Name";
            this.changeTechNameToolStripMenuItem.Click += new System.EventHandler(this.changeTechNameToolStripMenuItem_Click);
            // 
            // autoCheckOutTimeToolStripMenuItem
            // 
            this.autoCheckOutTimeToolStripMenuItem.Name = "autoCheckOutTimeToolStripMenuItem";
            this.autoCheckOutTimeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.autoCheckOutTimeToolStripMenuItem.Text = "Auto Check Out Time";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.presetsToolStripMenuItem});
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // presetsToolStripMenuItem
            // 
            this.presetsToolStripMenuItem.Name = "presetsToolStripMenuItem";
            this.presetsToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.presetsToolStripMenuItem.Text = "Presets";
            this.presetsToolStripMenuItem.Click += new System.EventHandler(this.presetsToolStripMenuItem_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.AutoScroll = true;
            this.pnlMain.AutoScrollMargin = new System.Drawing.Size(0, 50);
            this.pnlMain.AutoScrollMinSize = new System.Drawing.Size(0, 100);
            this.pnlMain.Controls.Add(this.grpClosure);
            this.pnlMain.Controls.Add(this.grpReport);
            this.pnlMain.Controls.Add(this.grpWorkOrderInformation);
            this.pnlMain.Controls.Add(this.grpCustomerInformation);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 28);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1111, 819);
            this.pnlMain.TabIndex = 1;
            // 
            // grpClosure
            // 
            this.grpClosure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpClosure.Controls.Add(this.picSignature);
            this.grpClosure.Controls.Add(this.btnGenerateReport);
            this.grpClosure.Controls.Add(this.label16);
            this.grpClosure.Controls.Add(this.dtpCheckOut);
            this.grpClosure.Controls.Add(this.chkSignature);
            this.grpClosure.Location = new System.Drawing.Point(4, 927);
            this.grpClosure.Margin = new System.Windows.Forms.Padding(4);
            this.grpClosure.Name = "grpClosure";
            this.grpClosure.Padding = new System.Windows.Forms.Padding(4);
            this.grpClosure.Size = new System.Drawing.Size(1066, 159);
            this.grpClosure.TabIndex = 3;
            this.grpClosure.TabStop = false;
            this.grpClosure.Text = "Closure";
            // 
            // picSignature
            // 
            this.picSignature.BackColor = System.Drawing.Color.White;
            this.picSignature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSignature.Location = new System.Drawing.Point(12, 23);
            this.picSignature.Margin = new System.Windows.Forms.Padding(4);
            this.picSignature.Name = "picSignature";
            this.picSignature.Size = new System.Drawing.Size(551, 99);
            this.picSignature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSignature.TabIndex = 16;
            this.picSignature.TabStop = false;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateReport.Location = new System.Drawing.Point(782, 114);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(276, 37);
            this.btnGenerateReport.TabIndex = 15;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(767, 27);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 17);
            this.label16.TabIndex = 14;
            this.label16.Text = "Check Out";
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpCheckOut.CustomFormat = "dd/MMM/yyyy HH:mm";
            this.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckOut.Location = new System.Drawing.Point(853, 23);
            this.dtpCheckOut.Margin = new System.Windows.Forms.Padding(4);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(204, 22);
            this.dtpCheckOut.TabIndex = 13;
            // 
            // chkSignature
            // 
            this.chkSignature.AutoSize = true;
            this.chkSignature.Location = new System.Drawing.Point(17, 130);
            this.chkSignature.Margin = new System.Windows.Forms.Padding(4);
            this.chkSignature.Name = "chkSignature";
            this.chkSignature.Size = new System.Drawing.Size(268, 21);
            this.chkSignature.TabIndex = 0;
            this.chkSignature.Text = "Include Customer Signature (optional)";
            this.chkSignature.UseVisualStyleBackColor = true;
            this.chkSignature.CheckedChanged += new System.EventHandler(this.chkSignature_CheckedChanged);
            // 
            // grpReport
            // 
            this.grpReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpReport.Controls.Add(this.chkFailedPM);
            this.grpReport.Controls.Add(this.grpOtherWorkType);
            this.grpReport.Controls.Add(this.grpFailureEvent);
            this.grpReport.Controls.Add(this.btnAddToReport);
            this.grpReport.Controls.Add(this.dgvReport);
            this.grpReport.Controls.Add(this.txtTechReport);
            this.grpReport.Controls.Add(this.label14);
            this.grpReport.Controls.Add(this.label13);
            this.grpReport.Controls.Add(this.cmbRFU);
            this.grpReport.Controls.Add(this.txtComplaint);
            this.grpReport.Controls.Add(this.label12);
            this.grpReport.Controls.Add(this.txtPartNumber);
            this.grpReport.Controls.Add(this.label11);
            this.grpReport.Controls.Add(this.txtSerial);
            this.grpReport.Controls.Add(this.label10);
            this.grpReport.Controls.Add(this.label9);
            this.grpReport.Controls.Add(this.cmbWorkType);
            this.grpReport.Location = new System.Drawing.Point(4, 270);
            this.grpReport.Margin = new System.Windows.Forms.Padding(4);
            this.grpReport.Name = "grpReport";
            this.grpReport.Padding = new System.Windows.Forms.Padding(4);
            this.grpReport.Size = new System.Drawing.Size(1066, 649);
            this.grpReport.TabIndex = 2;
            this.grpReport.TabStop = false;
            this.grpReport.Text = "Report";
            // 
            // grpOtherWorkType
            // 
            this.grpOtherWorkType.Controls.Add(this.txtOtherWorkType);
            this.grpOtherWorkType.Location = new System.Drawing.Point(12, 73);
            this.grpOtherWorkType.Margin = new System.Windows.Forms.Padding(4);
            this.grpOtherWorkType.Name = "grpOtherWorkType";
            this.grpOtherWorkType.Padding = new System.Windows.Forms.Padding(4);
            this.grpOtherWorkType.Size = new System.Drawing.Size(372, 60);
            this.grpOtherWorkType.TabIndex = 28;
            this.grpOtherWorkType.TabStop = false;
            this.grpOtherWorkType.Text = "Other Work Type";
            this.grpOtherWorkType.Visible = false;
            // 
            // txtOtherWorkType
            // 
            this.txtOtherWorkType.Location = new System.Drawing.Point(105, 23);
            this.txtOtherWorkType.Margin = new System.Windows.Forms.Padding(4);
            this.txtOtherWorkType.Name = "txtOtherWorkType";
            this.txtOtherWorkType.Size = new System.Drawing.Size(255, 22);
            this.txtOtherWorkType.TabIndex = 10;
            // 
            // grpFailureEvent
            // 
            this.grpFailureEvent.Controls.Add(this.txtPatient);
            this.grpFailureEvent.Controls.Add(this.cmbFailureEvent);
            this.grpFailureEvent.Location = new System.Drawing.Point(17, 408);
            this.grpFailureEvent.Margin = new System.Windows.Forms.Padding(4);
            this.grpFailureEvent.Name = "grpFailureEvent";
            this.grpFailureEvent.Padding = new System.Windows.Forms.Padding(4);
            this.grpFailureEvent.Size = new System.Drawing.Size(372, 178);
            this.grpFailureEvent.TabIndex = 16;
            this.grpFailureEvent.TabStop = false;
            this.grpFailureEvent.Text = "Failure Event";
            this.grpFailureEvent.Visible = false;
            // 
            // txtPatient
            // 
            this.txtPatient.Location = new System.Drawing.Point(100, 54);
            this.txtPatient.Multiline = true;
            this.txtPatient.Name = "txtPatient";
            this.txtPatient.Size = new System.Drawing.Size(255, 134);
            this.txtPatient.TabIndex = 17;
            this.txtPatient.Visible = false;
            // 
            // cmbFailureEvent
            // 
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
            this.cmbFailureEvent.Location = new System.Drawing.Point(100, 23);
            this.cmbFailureEvent.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFailureEvent.Name = "cmbFailureEvent";
            this.cmbFailureEvent.Size = new System.Drawing.Size(255, 24);
            this.cmbFailureEvent.TabIndex = 16;
            this.cmbFailureEvent.SelectedIndexChanged += new System.EventHandler(this.cmbFailureEvent_SelectedIndexChanged);
            // 
            // btnAddToReport
            // 
            this.btnAddToReport.Location = new System.Drawing.Point(117, 594);
            this.btnAddToReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddToReport.Name = "btnAddToReport";
            this.btnAddToReport.Size = new System.Drawing.Size(256, 43);
            this.btnAddToReport.TabIndex = 18;
            this.btnAddToReport.Text = "Add to Report";
            this.btnAddToReport.UseVisualStyleBackColor = true;
            this.btnAddToReport.Click += new System.EventHandler(this.btnAddToReport_Click);
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvReport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSerialNumber,
            this.colPartNumber,
            this.colWorkType,
            this.colComplaint,
            this.colTechReport,
            this.colRFU,
            this.colFailureMode,
            this.colQAInformation,
            this.colRemove});
            this.dgvReport.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvReport.Location = new System.Drawing.Point(397, 41);
            this.dgvReport.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.Size = new System.Drawing.Size(661, 596);
            this.dgvReport.TabIndex = 24;
            // 
            // colSerialNumber
            // 
            this.colSerialNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSerialNumber.HeaderText = "Serial Number";
            this.colSerialNumber.Name = "colSerialNumber";
            this.colSerialNumber.Width = 117;
            // 
            // colPartNumber
            // 
            this.colPartNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPartNumber.HeaderText = "Part Number";
            this.colPartNumber.Name = "colPartNumber";
            this.colPartNumber.Width = 108;
            // 
            // colWorkType
            // 
            this.colWorkType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colWorkType.HeaderText = "Work Type";
            this.colWorkType.Name = "colWorkType";
            this.colWorkType.Width = 98;
            // 
            // colComplaint
            // 
            this.colComplaint.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colComplaint.HeaderText = "Complaint";
            this.colComplaint.Name = "colComplaint";
            this.colComplaint.Width = 99;
            // 
            // colTechReport
            // 
            this.colTechReport.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTechReport.HeaderText = "Tech Report";
            this.colTechReport.Name = "colTechReport";
            this.colTechReport.Width = 107;
            // 
            // colRFU
            // 
            this.colRFU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colRFU.HeaderText = "RFU";
            this.colRFU.Name = "colRFU";
            this.colRFU.Width = 65;
            // 
            // colFailureMode
            // 
            this.colFailureMode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colFailureMode.HeaderText = "Failure Mode";
            this.colFailureMode.Name = "colFailureMode";
            this.colFailureMode.Width = 109;
            // 
            // colQAInformation
            // 
            this.colQAInformation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colQAInformation.HeaderText = "Additional QA Information";
            this.colQAInformation.Name = "colQAInformation";
            this.colQAInformation.Width = 180;
            // 
            // colRemove
            // 
            this.colRemove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colRemove.HeaderText = "Remove";
            this.colRemove.Name = "colRemove";
            this.colRemove.Width = 66;
            // 
            // txtTechReport
            // 
            this.txtTechReport.Location = new System.Drawing.Point(117, 328);
            this.txtTechReport.Margin = new System.Windows.Forms.Padding(4);
            this.txtTechReport.Multiline = true;
            this.txtTechReport.Name = "txtTechReport";
            this.txtTechReport.Size = new System.Drawing.Size(255, 52);
            this.txtTechReport.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 332);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 17);
            this.label14.TabIndex = 20;
            this.label14.Text = "Tech Report";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 224);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 17);
            this.label13.TabIndex = 19;
            this.label13.Text = "RFU Status";
            // 
            // cmbRFU
            // 
            this.cmbRFU.FormattingEnabled = true;
            this.cmbRFU.Items.AddRange(new object[] {
            "Ready",
            "Not Ready",
            "None",
            "Unknown"});
            this.cmbRFU.Location = new System.Drawing.Point(117, 220);
            this.cmbRFU.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRFU.Name = "cmbRFU";
            this.cmbRFU.Size = new System.Drawing.Size(255, 24);
            this.cmbRFU.TabIndex = 13;
            // 
            // txtComplaint
            // 
            this.txtComplaint.Location = new System.Drawing.Point(117, 274);
            this.txtComplaint.Margin = new System.Windows.Forms.Padding(4);
            this.txtComplaint.Multiline = true;
            this.txtComplaint.Name = "txtComplaint";
            this.txtComplaint.Size = new System.Drawing.Size(255, 46);
            this.txtComplaint.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(43, 278);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "Complaint";
            // 
            // txtPartNumber
            // 
            this.txtPartNumber.Location = new System.Drawing.Point(117, 186);
            this.txtPartNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPartNumber.Name = "txtPartNumber";
            this.txtPartNumber.Size = new System.Drawing.Size(255, 22);
            this.txtPartNumber.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 190);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "Part Num";
            // 
            // txtSerial
            // 
            this.txtSerial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSerial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSerial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSerial.Location = new System.Drawing.Point(117, 152);
            this.txtSerial.Margin = new System.Windows.Forms.Padding(4);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(255, 22);
            this.txtSerial.TabIndex = 11;
            this.txtSerial.Leave += new System.EventHandler(this.txtSerial_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 155);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Serial Num";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 44);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Work Type";
            // 
            // cmbWorkType
            // 
            this.cmbWorkType.FormattingEnabled = true;
            this.cmbWorkType.Items.AddRange(new object[] {
            "PM",
            "Defib Evaluation",
            "Software Upgrade",
            "Config Change",
            "Training",
            "PR Visit",
            "Other..."});
            this.cmbWorkType.Location = new System.Drawing.Point(117, 41);
            this.cmbWorkType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbWorkType.Name = "cmbWorkType";
            this.cmbWorkType.Size = new System.Drawing.Size(255, 24);
            this.cmbWorkType.TabIndex = 9;
            this.cmbWorkType.SelectedIndexChanged += new System.EventHandler(this.cmbWorkType_SelectedIndexChanged);
            // 
            // grpWorkOrderInformation
            // 
            this.grpWorkOrderInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpWorkOrderInformation.Controls.Add(this.label8);
            this.grpWorkOrderInformation.Controls.Add(this.dtpCheckIn);
            this.grpWorkOrderInformation.Controls.Add(this.lblWorkOrderNumber);
            this.grpWorkOrderInformation.Location = new System.Drawing.Point(0, 12);
            this.grpWorkOrderInformation.Margin = new System.Windows.Forms.Padding(4);
            this.grpWorkOrderInformation.Name = "grpWorkOrderInformation";
            this.grpWorkOrderInformation.Padding = new System.Windows.Forms.Padding(4);
            this.grpWorkOrderInformation.Size = new System.Drawing.Size(1070, 53);
            this.grpWorkOrderInformation.TabIndex = 1;
            this.grpWorkOrderInformation.TabStop = false;
            this.grpWorkOrderInformation.Text = "Work Order Information";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(778, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Check In";
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpCheckIn.CustomFormat = "dd/MMM/yyyy HH:mm";
            this.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckIn.Location = new System.Drawing.Point(853, 20);
            this.dtpCheckIn.Margin = new System.Windows.Forms.Padding(4);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(204, 22);
            this.dtpCheckIn.TabIndex = 1;
            // 
            // lblWorkOrderNumber
            // 
            this.lblWorkOrderNumber.AutoSize = true;
            this.lblWorkOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkOrderNumber.Location = new System.Drawing.Point(16, 20);
            this.lblWorkOrderNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWorkOrderNumber.Name = "lblWorkOrderNumber";
            this.lblWorkOrderNumber.Size = new System.Drawing.Size(68, 25);
            this.lblWorkOrderNumber.TabIndex = 0;
            this.lblWorkOrderNumber.Text = "WO# ";
            // 
            // grpCustomerInformation
            // 
            this.grpCustomerInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCustomerInformation.Controls.Add(this.label1);
            this.grpCustomerInformation.Controls.Add(this.cmbPreset);
            this.grpCustomerInformation.Controls.Add(this.txtPO);
            this.grpCustomerInformation.Controls.Add(this.label7);
            this.grpCustomerInformation.Controls.Add(this.txtContactEmail);
            this.grpCustomerInformation.Controls.Add(this.label5);
            this.grpCustomerInformation.Controls.Add(this.txtContactPhone);
            this.grpCustomerInformation.Controls.Add(this.label6);
            this.grpCustomerInformation.Controls.Add(this.txtContactName);
            this.grpCustomerInformation.Controls.Add(this.label4);
            this.grpCustomerInformation.Controls.Add(this.txtAddress);
            this.grpCustomerInformation.Controls.Add(this.label3);
            this.grpCustomerInformation.Controls.Add(this.txtCustomerSite);
            this.grpCustomerInformation.Controls.Add(this.label2);
            this.grpCustomerInformation.Location = new System.Drawing.Point(4, 72);
            this.grpCustomerInformation.Margin = new System.Windows.Forms.Padding(4);
            this.grpCustomerInformation.Name = "grpCustomerInformation";
            this.grpCustomerInformation.Padding = new System.Windows.Forms.Padding(4);
            this.grpCustomerInformation.Size = new System.Drawing.Size(1066, 190);
            this.grpCustomerInformation.TabIndex = 0;
            this.grpCustomerInformation.TabStop = false;
            this.grpCustomerInformation.Text = "Customer Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Preset";
            // 
            // cmbPreset
            // 
            this.cmbPreset.FormattingEnabled = true;
            this.cmbPreset.Location = new System.Drawing.Point(117, 22);
            this.cmbPreset.Name = "cmbPreset";
            this.cmbPreset.Size = new System.Drawing.Size(168, 24);
            this.cmbPreset.TabIndex = 2;
            this.cmbPreset.SelectedIndexChanged += new System.EventHandler(this.cmbPreset_SelectedIndexChanged);
            // 
            // txtPO
            // 
            this.txtPO.Location = new System.Drawing.Point(117, 131);
            this.txtPO.Margin = new System.Windows.Forms.Padding(4);
            this.txtPO.Name = "txtPO";
            this.txtPO.Size = new System.Drawing.Size(255, 22);
            this.txtPO.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 135);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "PO#";
            // 
            // txtContactEmail
            // 
            this.txtContactEmail.Location = new System.Drawing.Point(696, 131);
            this.txtContactEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtContactEmail.Name = "txtContactEmail";
            this.txtContactEmail.Size = new System.Drawing.Size(255, 22);
            this.txtContactEmail.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(596, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Contact Email";
            // 
            // txtContactPhone
            // 
            this.txtContactPhone.Location = new System.Drawing.Point(696, 99);
            this.txtContactPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtContactPhone.Name = "txtContactPhone";
            this.txtContactPhone.Size = new System.Drawing.Size(255, 22);
            this.txtContactPhone.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(592, 103);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Contact Phone";
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(696, 67);
            this.txtContactName.Margin = new System.Windows.Forms.Padding(4);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(255, 22);
            this.txtContactName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(592, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Contact Name";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(117, 99);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(412, 22);
            this.txtAddress.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // txtCustomerSite
            // 
            this.txtCustomerSite.ForeColor = System.Drawing.Color.Black;
            this.txtCustomerSite.Location = new System.Drawing.Point(117, 67);
            this.txtCustomerSite.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerSite.Name = "txtCustomerSite";
            this.txtCustomerSite.Size = new System.Drawing.Size(255, 22);
            this.txtCustomerSite.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer Site";
            // 
            // chkFailedPM
            // 
            this.chkFailedPM.AutoSize = true;
            this.chkFailedPM.Location = new System.Drawing.Point(117, 387);
            this.chkFailedPM.Name = "chkFailedPM";
            this.chkFailedPM.Size = new System.Drawing.Size(92, 21);
            this.chkFailedPM.TabIndex = 29;
            this.chkFailedPM.Text = "Failed PM";
            this.chkFailedPM.UseVisualStyleBackColor = true;
            this.chkFailedPM.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 847);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Work Order 3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.grpClosure.ResumeLayout(false);
            this.grpClosure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSignature)).EndInit();
            this.grpReport.ResumeLayout(false);
            this.grpReport.PerformLayout();
            this.grpOtherWorkType.ResumeLayout(false);
            this.grpOtherWorkType.PerformLayout();
            this.grpFailureEvent.ResumeLayout(false);
            this.grpFailureEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.grpWorkOrderInformation.ResumeLayout(false);
            this.grpWorkOrderInformation.PerformLayout();
            this.grpCustomerInformation.ResumeLayout(false);
            this.grpCustomerInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem workOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWorkOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveWorkOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadWorkOrderToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox grpWorkOrderInformation;
        private System.Windows.Forms.Label lblWorkOrderNumber;
        private System.Windows.Forms.GroupBox grpCustomerInformation;
        private System.Windows.Forms.TextBox txtPO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtContactEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContactPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerSite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeTechNameToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.GroupBox grpReport;
        private System.Windows.Forms.ComboBox cmbFailureEvent;
        private System.Windows.Forms.TextBox txtTechReport;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbRFU;
        private System.Windows.Forms.TextBox txtComplaint;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPartNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbWorkType;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.TextBox txtOtherWorkType;
        private System.Windows.Forms.GroupBox grpClosure;
        private System.Windows.Forms.Button btnAddToReport;
        private System.Windows.Forms.PictureBox picSignature;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.CheckBox chkSignature;
        private System.Windows.Forms.ToolStripMenuItem autoCheckOutTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presetsToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpOtherWorkType;
        private System.Windows.Forms.GroupBox grpFailureEvent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPreset;
        private System.Windows.Forms.TextBox txtPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPartNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWorkType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComplaint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTechReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRFU;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFailureMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQAInformation;
        private System.Windows.Forms.DataGridViewButtonColumn colRemove;
        private System.Windows.Forms.CheckBox chkFailedPM;
    }
}

