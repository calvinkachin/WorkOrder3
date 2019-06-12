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
            this.loadWorkOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWorkOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.grpCustomerInformation = new System.Windows.Forms.GroupBox();
            this.grpWorkOrderInformation = new System.Windows.Forms.GroupBox();
            this.lblWorkOrderNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerSite = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContactEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContactPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPO = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTechNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.grpReport = new System.Windows.Forms.GroupBox();
            this.cmbWorkType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPartNumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtComplaint = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbRFU = new System.Windows.Forms.ComboBox();
            this.txtTechReport = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbFailureEvent = new System.Windows.Forms.ComboBox();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.colSerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPartNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWorkType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComplaint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTechReport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRFU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFailureMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQAInformation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtOtherWorkType = new System.Windows.Forms.TextBox();
            this.grpClosure = new System.Windows.Forms.GroupBox();
            this.btnAddToReport = new System.Windows.Forms.Button();
            this.colRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.chkSignature = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.picSignature = new System.Windows.Forms.PictureBox();
            this.autoCheckOutTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpFailureEvent = new System.Windows.Forms.GroupBox();
            this.grpOtherWorkType = new System.Windows.Forms.GroupBox();
            this.menuStripMain.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.grpCustomerInformation.SuspendLayout();
            this.grpWorkOrderInformation.SuspendLayout();
            this.grpReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.grpClosure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSignature)).BeginInit();
            this.grpFailureEvent.SuspendLayout();
            this.grpOtherWorkType.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workOrdersToolStripMenuItem,
            this.editToolStripMenuItem,
            this.customersToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(833, 24);
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
            this.workOrdersToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.workOrdersToolStripMenuItem.Text = "File";
            // 
            // newWorkOrderToolStripMenuItem
            // 
            this.newWorkOrderToolStripMenuItem.Name = "newWorkOrderToolStripMenuItem";
            this.newWorkOrderToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.newWorkOrderToolStripMenuItem.Text = "New Work Order";
            // 
            // loadWorkOrderToolStripMenuItem
            // 
            this.loadWorkOrderToolStripMenuItem.Name = "loadWorkOrderToolStripMenuItem";
            this.loadWorkOrderToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.loadWorkOrderToolStripMenuItem.Text = "Load Work Order";
            // 
            // saveWorkOrderToolStripMenuItem
            // 
            this.saveWorkOrderToolStripMenuItem.Name = "saveWorkOrderToolStripMenuItem";
            this.saveWorkOrderToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.saveWorkOrderToolStripMenuItem.Text = "Save Work Order";
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
            this.pnlMain.Location = new System.Drawing.Point(0, 24);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(833, 664);
            this.pnlMain.TabIndex = 1;
            // 
            // grpCustomerInformation
            // 
            this.grpCustomerInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.grpCustomerInformation.Location = new System.Drawing.Point(3, 49);
            this.grpCustomerInformation.Name = "grpCustomerInformation";
            this.grpCustomerInformation.Size = new System.Drawing.Size(810, 112);
            this.grpCustomerInformation.TabIndex = 0;
            this.grpCustomerInformation.TabStop = false;
            this.grpCustomerInformation.Text = "Customer Information";
            // 
            // grpWorkOrderInformation
            // 
            this.grpWorkOrderInformation.Controls.Add(this.label8);
            this.grpWorkOrderInformation.Controls.Add(this.dtpCheckIn);
            this.grpWorkOrderInformation.Controls.Add(this.lblWorkOrderNumber);
            this.grpWorkOrderInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpWorkOrderInformation.Location = new System.Drawing.Point(0, 0);
            this.grpWorkOrderInformation.Name = "grpWorkOrderInformation";
            this.grpWorkOrderInformation.Size = new System.Drawing.Size(816, 43);
            this.grpWorkOrderInformation.TabIndex = 1;
            this.grpWorkOrderInformation.TabStop = false;
            this.grpWorkOrderInformation.Text = "Work Order Information";
            // 
            // lblWorkOrderNumber
            // 
            this.lblWorkOrderNumber.AutoSize = true;
            this.lblWorkOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkOrderNumber.Location = new System.Drawing.Point(12, 16);
            this.lblWorkOrderNumber.Name = "lblWorkOrderNumber";
            this.lblWorkOrderNumber.Size = new System.Drawing.Size(48, 20);
            this.lblWorkOrderNumber.TabIndex = 0;
            this.lblWorkOrderNumber.Text = "WO: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer Site";
            // 
            // txtCustomerSite
            // 
            this.txtCustomerSite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerSite.ForeColor = System.Drawing.Color.Black;
            this.txtCustomerSite.Location = new System.Drawing.Point(88, 23);
            this.txtCustomerSite.Name = "txtCustomerSite";
            this.txtCustomerSite.Size = new System.Drawing.Size(192, 20);
            this.txtCustomerSite.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(88, 49);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(310, 20);
            this.txtAddress.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(522, 23);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(192, 20);
            this.txtContactName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Contact Name";
            // 
            // txtContactEmail
            // 
            this.txtContactEmail.Location = new System.Drawing.Point(522, 75);
            this.txtContactEmail.Name = "txtContactEmail";
            this.txtContactEmail.Size = new System.Drawing.Size(192, 20);
            this.txtContactEmail.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Contact Email";
            // 
            // txtContactPhone
            // 
            this.txtContactPhone.Location = new System.Drawing.Point(522, 49);
            this.txtContactPhone.Name = "txtContactPhone";
            this.txtContactPhone.Size = new System.Drawing.Size(192, 20);
            this.txtContactPhone.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(444, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Contact Phone";
            // 
            // txtPO
            // 
            this.txtPO.Location = new System.Drawing.Point(88, 75);
            this.txtPO.Name = "txtPO";
            this.txtPO.Size = new System.Drawing.Size(192, 20);
            this.txtPO.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "PO#";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeTechNameToolStripMenuItem,
            this.autoCheckOutTimeToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // changeTechNameToolStripMenuItem
            // 
            this.changeTechNameToolStripMenuItem.Name = "changeTechNameToolStripMenuItem";
            this.changeTechNameToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.changeTechNameToolStripMenuItem.Text = "Change Tech Name";
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpCheckIn.CustomFormat = "dd/MMM/yyyy HH:mm";
            this.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckIn.Location = new System.Drawing.Point(653, 16);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(154, 20);
            this.dtpCheckIn.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(597, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Check In";
            // 
            // grpReport
            // 
            this.grpReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.grpReport.Location = new System.Drawing.Point(3, 167);
            this.grpReport.Name = "grpReport";
            this.grpReport.Size = new System.Drawing.Size(810, 561);
            this.grpReport.TabIndex = 2;
            this.grpReport.TabStop = false;
            this.grpReport.Text = "Report";
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
            this.cmbWorkType.Location = new System.Drawing.Point(88, 33);
            this.cmbWorkType.Name = "cmbWorkType";
            this.cmbWorkType.Size = new System.Drawing.Size(192, 21);
            this.cmbWorkType.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Work Type";
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(88, 115);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(192, 20);
            this.txtSerial.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Serial Num";
            // 
            // txtPartNumber
            // 
            this.txtPartNumber.Location = new System.Drawing.Point(88, 143);
            this.txtPartNumber.Name = "txtPartNumber";
            this.txtPartNumber.Size = new System.Drawing.Size(192, 20);
            this.txtPartNumber.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Part Num";
            // 
            // txtComplaint
            // 
            this.txtComplaint.Location = new System.Drawing.Point(88, 205);
            this.txtComplaint.Multiline = true;
            this.txtComplaint.Name = "txtComplaint";
            this.txtComplaint.Size = new System.Drawing.Size(192, 80);
            this.txtComplaint.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 208);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Complaint";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 174);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
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
            this.cmbRFU.Location = new System.Drawing.Point(88, 171);
            this.cmbRFU.Name = "cmbRFU";
            this.cmbRFU.Size = new System.Drawing.Size(192, 21);
            this.cmbRFU.TabIndex = 18;
            // 
            // txtTechReport
            // 
            this.txtTechReport.Location = new System.Drawing.Point(88, 291);
            this.txtTechReport.Multiline = true;
            this.txtTechReport.Name = "txtTechReport";
            this.txtTechReport.Size = new System.Drawing.Size(192, 75);
            this.txtTechReport.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 294);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Tech Report";
            // 
            // cmbFailureEvent
            // 
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
            this.cmbFailureEvent.Location = new System.Drawing.Point(75, 19);
            this.cmbFailureEvent.Name = "cmbFailureEvent";
            this.cmbFailureEvent.Size = new System.Drawing.Size(192, 21);
            this.cmbFailureEvent.TabIndex = 22;
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
            this.dgvReport.Location = new System.Drawing.Point(298, 33);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.Size = new System.Drawing.Size(506, 522);
            this.dgvReport.TabIndex = 24;
            // 
            // colSerialNumber
            // 
            this.colSerialNumber.HeaderText = "Serial Number";
            this.colSerialNumber.Name = "colSerialNumber";
            this.colSerialNumber.Width = 90;
            // 
            // colPartNumber
            // 
            this.colPartNumber.HeaderText = "Part Number";
            this.colPartNumber.Name = "colPartNumber";
            this.colPartNumber.Width = 84;
            // 
            // colWorkType
            // 
            this.colWorkType.HeaderText = "Work Type";
            this.colWorkType.Name = "colWorkType";
            this.colWorkType.Width = 78;
            // 
            // colComplaint
            // 
            this.colComplaint.HeaderText = "Complaint";
            this.colComplaint.Name = "colComplaint";
            this.colComplaint.Width = 78;
            // 
            // colTechReport
            // 
            this.colTechReport.HeaderText = "Tech Report";
            this.colTechReport.Name = "colTechReport";
            this.colTechReport.Width = 85;
            // 
            // colRFU
            // 
            this.colRFU.HeaderText = "RFU";
            this.colRFU.Name = "colRFU";
            this.colRFU.Width = 54;
            // 
            // colFailureMode
            // 
            this.colFailureMode.HeaderText = "Failure Mode";
            this.colFailureMode.Name = "colFailureMode";
            this.colFailureMode.Width = 86;
            // 
            // colQAInformation
            // 
            this.colQAInformation.HeaderText = "Additional QA Information";
            this.colQAInformation.Name = "colQAInformation";
            this.colQAInformation.Width = 138;
            // 
            // txtOtherWorkType
            // 
            this.txtOtherWorkType.Location = new System.Drawing.Point(79, 19);
            this.txtOtherWorkType.Name = "txtOtherWorkType";
            this.txtOtherWorkType.Size = new System.Drawing.Size(192, 20);
            this.txtOtherWorkType.TabIndex = 26;
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
            this.grpClosure.Location = new System.Drawing.Point(3, 734);
            this.grpClosure.Name = "grpClosure";
            this.grpClosure.Size = new System.Drawing.Size(810, 129);
            this.grpClosure.TabIndex = 3;
            this.grpClosure.TabStop = false;
            this.grpClosure.Text = "Closure";
            // 
            // btnAddToReport
            // 
            this.btnAddToReport.Location = new System.Drawing.Point(88, 450);
            this.btnAddToReport.Name = "btnAddToReport";
            this.btnAddToReport.Size = new System.Drawing.Size(192, 35);
            this.btnAddToReport.TabIndex = 12;
            this.btnAddToReport.Text = "Add to Report";
            this.btnAddToReport.UseVisualStyleBackColor = true;
            // 
            // colRemove
            // 
            this.colRemove.HeaderText = "Remove";
            this.colRemove.Name = "colRemove";
            this.colRemove.Width = 53;
            // 
            // chkSignature
            // 
            this.chkSignature.AutoSize = true;
            this.chkSignature.Location = new System.Drawing.Point(13, 106);
            this.chkSignature.Name = "chkSignature";
            this.chkSignature.Size = new System.Drawing.Size(202, 17);
            this.chkSignature.TabIndex = 0;
            this.chkSignature.Text = "Include Customer Signature (optional)";
            this.chkSignature.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(586, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Check Out";
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpCheckOut.CustomFormat = "dd/MMM/yyyy HH:mm";
            this.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckOut.Location = new System.Drawing.Point(650, 19);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(154, 20);
            this.dtpCheckOut.TabIndex = 13;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateReport.Location = new System.Drawing.Point(597, 93);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(207, 30);
            this.btnGenerateReport.TabIndex = 15;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            // 
            // picSignature
            // 
            this.picSignature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSignature.Location = new System.Drawing.Point(9, 19);
            this.picSignature.Name = "picSignature";
            this.picSignature.Size = new System.Drawing.Size(414, 81);
            this.picSignature.TabIndex = 16;
            this.picSignature.TabStop = false;
            // 
            // autoCheckOutTimeToolStripMenuItem
            // 
            this.autoCheckOutTimeToolStripMenuItem.Name = "autoCheckOutTimeToolStripMenuItem";
            this.autoCheckOutTimeToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.autoCheckOutTimeToolStripMenuItem.Text = "Auto Check Out Time";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.presetsToolStripMenuItem});
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // presetsToolStripMenuItem
            // 
            this.presetsToolStripMenuItem.Name = "presetsToolStripMenuItem";
            this.presetsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.presetsToolStripMenuItem.Text = "Presets";
            // 
            // grpFailureEvent
            // 
            this.grpFailureEvent.Controls.Add(this.cmbFailureEvent);
            this.grpFailureEvent.Location = new System.Drawing.Point(13, 372);
            this.grpFailureEvent.Name = "grpFailureEvent";
            this.grpFailureEvent.Size = new System.Drawing.Size(279, 53);
            this.grpFailureEvent.TabIndex = 27;
            this.grpFailureEvent.TabStop = false;
            this.grpFailureEvent.Text = "Failure Event";
            // 
            // grpOtherWorkType
            // 
            this.grpOtherWorkType.Controls.Add(this.txtOtherWorkType);
            this.grpOtherWorkType.Location = new System.Drawing.Point(9, 61);
            this.grpOtherWorkType.Name = "grpOtherWorkType";
            this.grpOtherWorkType.Size = new System.Drawing.Size(279, 49);
            this.grpOtherWorkType.TabIndex = 28;
            this.grpOtherWorkType.TabStop = false;
            this.grpOtherWorkType.Text = "Other Work Type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 688);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "Form1";
            this.Text = "Work Order 3";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.grpCustomerInformation.ResumeLayout(false);
            this.grpCustomerInformation.PerformLayout();
            this.grpWorkOrderInformation.ResumeLayout(false);
            this.grpWorkOrderInformation.PerformLayout();
            this.grpReport.ResumeLayout(false);
            this.grpReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.grpClosure.ResumeLayout(false);
            this.grpClosure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSignature)).EndInit();
            this.grpFailureEvent.ResumeLayout(false);
            this.grpOtherWorkType.ResumeLayout(false);
            this.grpOtherWorkType.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPartNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWorkType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComplaint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTechReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRFU;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFailureMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQAInformation;
        private System.Windows.Forms.TextBox txtOtherWorkType;
        private System.Windows.Forms.GroupBox grpClosure;
        private System.Windows.Forms.Button btnAddToReport;
        private System.Windows.Forms.DataGridViewButtonColumn colRemove;
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
    }
}

