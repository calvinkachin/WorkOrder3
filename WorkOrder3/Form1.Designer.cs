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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.workOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWorkOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWorkOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadWorkOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTechNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pMTestValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defineUploadPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.grpClosure = new System.Windows.Forms.GroupBox();
            this.chkWarranty = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.chkAutoUpdateCheckOut = new System.Windows.Forms.CheckBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.txtMiscCost = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtRepairCost = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtLabourHours = new System.Windows.Forms.TextBox();
            this.txtTravelCost = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTravelHours = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtLabourCost = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.picTechSignature = new System.Windows.Forms.PictureBox();
            this.chkTechSignature = new System.Windows.Forms.CheckBox();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.picSignature = new System.Windows.Forms.PictureBox();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.chkSignature = new System.Windows.Forms.CheckBox();
            this.grpReport = new System.Windows.Forms.GroupBox();
            this.btnAddToReport = new System.Windows.Forms.Button();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.colSerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWorkType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComplaint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTechReport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRepairCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRFU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTestedFunctions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdditionalTests = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFailureMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQAInformation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grpCustomerInformation = new System.Windows.Forms.GroupBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerSite = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpWorkOrderInformation = new System.Windows.Forms.GroupBox();
            this.lblWorkOrderNumber = new System.Windows.Forms.Label();
            this.tmrCheckOut = new System.Windows.Forms.Timer(this.components);
            this.menuStripMain.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.grpClosure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTechSignature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSignature)).BeginInit();
            this.grpReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.grpCustomerInformation.SuspendLayout();
            this.grpWorkOrderInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workOrdersToolStripMenuItem,
            this.editToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.uploadToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1279, 28);
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
            this.workOrdersToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.workOrdersToolStripMenuItem.Text = "File";
            // 
            // newWorkOrderToolStripMenuItem
            // 
            this.newWorkOrderToolStripMenuItem.Name = "newWorkOrderToolStripMenuItem";
            this.newWorkOrderToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.newWorkOrderToolStripMenuItem.Text = "New";
            this.newWorkOrderToolStripMenuItem.Click += new System.EventHandler(this.newWorkOrderToolStripMenuItem_Click);
            // 
            // saveWorkOrderToolStripMenuItem
            // 
            this.saveWorkOrderToolStripMenuItem.Name = "saveWorkOrderToolStripMenuItem";
            this.saveWorkOrderToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.saveWorkOrderToolStripMenuItem.Text = "Save";
            this.saveWorkOrderToolStripMenuItem.Click += new System.EventHandler(this.saveWorkOrderToolStripMenuItem_Click);
            // 
            // loadWorkOrderToolStripMenuItem
            // 
            this.loadWorkOrderToolStripMenuItem.Name = "loadWorkOrderToolStripMenuItem";
            this.loadWorkOrderToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.loadWorkOrderToolStripMenuItem.Text = "Load";
            this.loadWorkOrderToolStripMenuItem.Click += new System.EventHandler(this.loadWorkOrderToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeTechNameToolStripMenuItem,
            this.pMTestValuesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // changeTechNameToolStripMenuItem
            // 
            this.changeTechNameToolStripMenuItem.Name = "changeTechNameToolStripMenuItem";
            this.changeTechNameToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.changeTechNameToolStripMenuItem.Text = "Change Tech Name";
            this.changeTechNameToolStripMenuItem.Click += new System.EventHandler(this.changeTechNameToolStripMenuItem_Click);
            // 
            // pMTestValuesToolStripMenuItem
            // 
            this.pMTestValuesToolStripMenuItem.Name = "pMTestValuesToolStripMenuItem";
            this.pMTestValuesToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.pMTestValuesToolStripMenuItem.Text = "Additional PM Tests";
            this.pMTestValuesToolStripMenuItem.Click += new System.EventHandler(this.pMTestValuesToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.presetsToolStripMenuItem});
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // presetsToolStripMenuItem
            // 
            this.presetsToolStripMenuItem.Name = "presetsToolStripMenuItem";
            this.presetsToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.presetsToolStripMenuItem.Text = "Presets";
            this.presetsToolStripMenuItem.Click += new System.EventHandler(this.presetsToolStripMenuItem_Click);
            // 
            // uploadToolStripMenuItem
            // 
            this.uploadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defineUploadPathToolStripMenuItem});
            this.uploadToolStripMenuItem.Enabled = false;
            this.uploadToolStripMenuItem.Name = "uploadToolStripMenuItem";
            this.uploadToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.uploadToolStripMenuItem.Text = "Upload";
            // 
            // defineUploadPathToolStripMenuItem
            // 
            this.defineUploadPathToolStripMenuItem.Enabled = false;
            this.defineUploadPathToolStripMenuItem.Name = "defineUploadPathToolStripMenuItem";
            this.defineUploadPathToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.defineUploadPathToolStripMenuItem.Text = "Upload to Kanban";
            this.defineUploadPathToolStripMenuItem.Click += new System.EventHandler(this.defineUploadPathToolStripMenuItem_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.AutoScroll = true;
            this.pnlMain.AutoScrollMargin = new System.Drawing.Size(0, 250);
            this.pnlMain.AutoScrollMinSize = new System.Drawing.Size(0, 150);
            this.pnlMain.Controls.Add(this.grpClosure);
            this.pnlMain.Controls.Add(this.grpReport);
            this.pnlMain.Controls.Add(this.grpCustomerInformation);
            this.pnlMain.Location = new System.Drawing.Point(0, 98);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1279, 871);
            this.pnlMain.TabIndex = 1;
            // 
            // grpClosure
            // 
            this.grpClosure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpClosure.Controls.Add(this.chkWarranty);
            this.grpClosure.Controls.Add(this.label21);
            this.grpClosure.Controls.Add(this.chkAutoUpdateCheckOut);
            this.grpClosure.Controls.Add(this.lblTotalCost);
            this.grpClosure.Controls.Add(this.txtMiscCost);
            this.grpClosure.Controls.Add(this.label20);
            this.grpClosure.Controls.Add(this.txtRepairCost);
            this.grpClosure.Controls.Add(this.label19);
            this.grpClosure.Controls.Add(this.txtLabourHours);
            this.grpClosure.Controls.Add(this.txtTravelCost);
            this.grpClosure.Controls.Add(this.label18);
            this.grpClosure.Controls.Add(this.txtTravelHours);
            this.grpClosure.Controls.Add(this.label17);
            this.grpClosure.Controls.Add(this.label15);
            this.grpClosure.Controls.Add(this.txtLabourCost);
            this.grpClosure.Controls.Add(this.label14);
            this.grpClosure.Controls.Add(this.label13);
            this.grpClosure.Controls.Add(this.label8);
            this.grpClosure.Controls.Add(this.picTechSignature);
            this.grpClosure.Controls.Add(this.chkTechSignature);
            this.grpClosure.Controls.Add(this.dtpCheckIn);
            this.grpClosure.Controls.Add(this.picSignature);
            this.grpClosure.Controls.Add(this.btnGenerateReport);
            this.grpClosure.Controls.Add(this.label16);
            this.grpClosure.Controls.Add(this.dtpCheckOut);
            this.grpClosure.Controls.Add(this.chkSignature);
            this.grpClosure.Location = new System.Drawing.Point(25, 974);
            this.grpClosure.Margin = new System.Windows.Forms.Padding(4);
            this.grpClosure.Name = "grpClosure";
            this.grpClosure.Padding = new System.Windows.Forms.Padding(4);
            this.grpClosure.Size = new System.Drawing.Size(1187, 573);
            this.grpClosure.TabIndex = 3;
            this.grpClosure.TabStop = false;
            this.grpClosure.Text = "Closure";
            // 
            // chkWarranty
            // 
            this.chkWarranty.AutoSize = true;
            this.chkWarranty.ForeColor = System.Drawing.Color.Red;
            this.chkWarranty.Location = new System.Drawing.Point(188, 451);
            this.chkWarranty.Margin = new System.Windows.Forms.Padding(4);
            this.chkWarranty.Name = "chkWarranty";
            this.chkWarranty.Size = new System.Drawing.Size(207, 21);
            this.chkWarranty.TabIndex = 36;
            this.chkWarranty.Text = "All Covered Under Warranty";
            this.chkWarranty.UseVisualStyleBackColor = true;
            this.chkWarranty.CheckedChanged += new System.EventHandler(this.chkWarranty_CheckedChanged);
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Yellow;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(97, 514);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(158, 37);
            this.label21.TabIndex = 35;
            this.label21.Text = "Total ($):";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkAutoUpdateCheckOut
            // 
            this.chkAutoUpdateCheckOut.AutoSize = true;
            this.chkAutoUpdateCheckOut.Checked = true;
            this.chkAutoUpdateCheckOut.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoUpdateCheckOut.Location = new System.Drawing.Point(411, 69);
            this.chkAutoUpdateCheckOut.Name = "chkAutoUpdateCheckOut";
            this.chkAutoUpdateCheckOut.Size = new System.Drawing.Size(212, 21);
            this.chkAutoUpdateCheckOut.TabIndex = 34;
            this.chkAutoUpdateCheckOut.Text = "Auto update Check Out Time";
            this.chkAutoUpdateCheckOut.UseVisualStyleBackColor = true;
            this.chkAutoUpdateCheckOut.CheckedChanged += new System.EventHandler(this.chkAutoUpdateCheckOut_CheckedChanged);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.BackColor = System.Drawing.Color.Yellow;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(261, 514);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(171, 37);
            this.lblTotalCost.TabIndex = 33;
            this.lblTotalCost.Text = "-";
            this.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMiscCost
            // 
            this.txtMiscCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiscCost.Location = new System.Drawing.Point(295, 391);
            this.txtMiscCost.Name = "txtMiscCost";
            this.txtMiscCost.Size = new System.Drawing.Size(100, 27);
            this.txtMiscCost.TabIndex = 8;
            this.txtMiscCost.Text = "0";
            this.txtMiscCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMiscCost.TextChanged += new System.EventHandler(this.txtMiscCost_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(110, 396);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(145, 20);
            this.label20.TabIndex = 31;
            this.label20.Text = "Misc. Costs ($):";
            // 
            // txtRepairCost
            // 
            this.txtRepairCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepairCost.Location = new System.Drawing.Point(295, 336);
            this.txtRepairCost.Name = "txtRepairCost";
            this.txtRepairCost.Size = new System.Drawing.Size(100, 27);
            this.txtRepairCost.TabIndex = 7;
            this.txtRepairCost.Text = "0";
            this.txtRepairCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRepairCost.TextChanged += new System.EventHandler(this.txtRepairCost_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(100, 339);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(155, 20);
            this.label19.TabIndex = 29;
            this.label19.Text = "Repair Costs ($):";
            // 
            // txtLabourHours
            // 
            this.txtLabourHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabourHours.Location = new System.Drawing.Point(295, 140);
            this.txtLabourHours.Name = "txtLabourHours";
            this.txtLabourHours.Size = new System.Drawing.Size(100, 27);
            this.txtLabourHours.TabIndex = 3;
            this.txtLabourHours.Text = "0";
            this.txtLabourHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLabourHours.TextChanged += new System.EventHandler(this.txtLabourHours_TextChanged);
            // 
            // txtTravelCost
            // 
            this.txtTravelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTravelCost.Location = new System.Drawing.Point(295, 270);
            this.txtTravelCost.Name = "txtTravelCost";
            this.txtTravelCost.Size = new System.Drawing.Size(100, 27);
            this.txtTravelCost.TabIndex = 6;
            this.txtTravelCost.Text = "75.00";
            this.txtTravelCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTravelCost.TextChanged += new System.EventHandler(this.txtTravelCost_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(33, 273);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(222, 20);
            this.label18.TabIndex = 26;
            this.label18.Text = "Travel Cost per Hour ($):";
            // 
            // txtTravelHours
            // 
            this.txtTravelHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTravelHours.Location = new System.Drawing.Point(295, 237);
            this.txtTravelHours.Name = "txtTravelHours";
            this.txtTravelHours.Size = new System.Drawing.Size(100, 27);
            this.txtTravelHours.TabIndex = 5;
            this.txtTravelHours.Text = "0";
            this.txtTravelHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTravelHours.TextChanged += new System.EventHandler(this.txtTravelHours_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(75, 240);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(180, 20);
            this.label17.TabIndex = 24;
            this.label17.Text = "Travel time (Hours):";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(32, 476);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(400, 17);
            this.label15.TabIndex = 23;
            this.label15.Text = "_________________________________________________";
            // 
            // txtLabourCost
            // 
            this.txtLabourCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabourCost.Location = new System.Drawing.Point(295, 174);
            this.txtLabourCost.Name = "txtLabourCost";
            this.txtLabourCost.Size = new System.Drawing.Size(100, 27);
            this.txtLabourCost.TabIndex = 4;
            this.txtLabourCost.Text = "151.00";
            this.txtLabourCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLabourCost.TextChanged += new System.EventHandler(this.txtLabourCost_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(37, 177);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(218, 20);
            this.label14.TabIndex = 21;
            this.label14.Text = "Labor Cost per Hour ($):";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(87, 143);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(168, 20);
            this.label13.TabIndex = 19;
            this.label13.Text = "Total Labor Hours:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(77, 29);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Check In";
            // 
            // picTechSignature
            // 
            this.picTechSignature.BackColor = System.Drawing.Color.White;
            this.picTechSignature.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picTechSignature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picTechSignature.Location = new System.Drawing.Point(509, 214);
            this.picTechSignature.Margin = new System.Windows.Forms.Padding(4);
            this.picTechSignature.Name = "picTechSignature";
            this.picTechSignature.Size = new System.Drawing.Size(383, 75);
            this.picTechSignature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTechSignature.TabIndex = 18;
            this.picTechSignature.TabStop = false;
            // 
            // chkTechSignature
            // 
            this.chkTechSignature.AutoSize = true;
            this.chkTechSignature.ForeColor = System.Drawing.Color.Red;
            this.chkTechSignature.Location = new System.Drawing.Point(900, 240);
            this.chkTechSignature.Margin = new System.Windows.Forms.Padding(4);
            this.chkTechSignature.Name = "chkTechSignature";
            this.chkTechSignature.Size = new System.Drawing.Size(164, 21);
            this.chkTechSignature.TabIndex = 17;
            this.chkTechSignature.Text = "Technician Signature";
            this.chkTechSignature.UseVisualStyleBackColor = true;
            this.chkTechSignature.CheckedChanged += new System.EventHandler(this.chkTechSignature_CheckedChanged);
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.CustomFormat = "dd/MMM/yyyy HH:mm";
            this.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckIn.Location = new System.Drawing.Point(194, 27);
            this.dtpCheckIn.Margin = new System.Windows.Forms.Padding(4);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(201, 22);
            this.dtpCheckIn.TabIndex = 1;
            // 
            // picSignature
            // 
            this.picSignature.BackColor = System.Drawing.Color.White;
            this.picSignature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSignature.Location = new System.Drawing.Point(509, 297);
            this.picSignature.Margin = new System.Windows.Forms.Padding(4);
            this.picSignature.Name = "picSignature";
            this.picSignature.Size = new System.Drawing.Size(383, 75);
            this.picSignature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSignature.TabIndex = 16;
            this.picSignature.TabStop = false;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateReport.Location = new System.Drawing.Point(509, 483);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(383, 68);
            this.btnGenerateReport.TabIndex = 9;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(64, 69);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 20);
            this.label16.TabIndex = 14;
            this.label16.Text = "Check Out";
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.CustomFormat = "dd/MMM/yyyy HH:mm";
            this.dtpCheckOut.Enabled = false;
            this.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckOut.Location = new System.Drawing.Point(196, 69);
            this.dtpCheckOut.Margin = new System.Windows.Forms.Padding(4);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(199, 22);
            this.dtpCheckOut.TabIndex = 2;
            this.dtpCheckOut.ValueChanged += new System.EventHandler(this.dtpCheckOut_ValueChanged);
            // 
            // chkSignature
            // 
            this.chkSignature.AutoSize = true;
            this.chkSignature.Location = new System.Drawing.Point(900, 324);
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
            this.grpReport.Controls.Add(this.btnAddToReport);
            this.grpReport.Controls.Add(this.dgvReport);
            this.grpReport.Location = new System.Drawing.Point(25, 303);
            this.grpReport.Margin = new System.Windows.Forms.Padding(4);
            this.grpReport.Name = "grpReport";
            this.grpReport.Padding = new System.Windows.Forms.Padding(4);
            this.grpReport.Size = new System.Drawing.Size(1187, 649);
            this.grpReport.TabIndex = 2;
            this.grpReport.TabStop = false;
            this.grpReport.Text = "Report";
            // 
            // btnAddToReport
            // 
            this.btnAddToReport.Location = new System.Drawing.Point(12, 23);
            this.btnAddToReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddToReport.Name = "btnAddToReport";
            this.btnAddToReport.Size = new System.Drawing.Size(208, 43);
            this.btnAddToReport.TabIndex = 18;
            this.btnAddToReport.Text = "Add Report Entries";
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
            this.colModel,
            this.colWorkType,
            this.colComplaint,
            this.colTechReport,
            this.colRepairCost,
            this.colRFU,
            this.colShock,
            this.colTestedFunctions,
            this.colAdditionalTests,
            this.colFailureMode,
            this.colQAInformation,
            this.colPhoto,
            this.colEdit,
            this.colRemove});
            this.dgvReport.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvReport.Location = new System.Drawing.Point(9, 74);
            this.dgvReport.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.Size = new System.Drawing.Size(1166, 567);
            this.dgvReport.TabIndex = 24;
            this.dgvReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReport_CellContentClick);
            // 
            // colSerialNumber
            // 
            this.colSerialNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSerialNumber.HeaderText = "Serial Number";
            this.colSerialNumber.MinimumWidth = 6;
            this.colSerialNumber.Name = "colSerialNumber";
            this.colSerialNumber.Width = 117;
            // 
            // colModel
            // 
            this.colModel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colModel.HeaderText = "Model";
            this.colModel.MinimumWidth = 6;
            this.colModel.Name = "colModel";
            this.colModel.Width = 75;
            // 
            // colWorkType
            // 
            this.colWorkType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colWorkType.HeaderText = "Work Type";
            this.colWorkType.MinimumWidth = 6;
            this.colWorkType.Name = "colWorkType";
            this.colWorkType.Width = 98;
            // 
            // colComplaint
            // 
            this.colComplaint.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colComplaint.HeaderText = "Complaint";
            this.colComplaint.MinimumWidth = 6;
            this.colComplaint.Name = "colComplaint";
            this.colComplaint.Width = 99;
            // 
            // colTechReport
            // 
            this.colTechReport.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTechReport.HeaderText = "Tech Report";
            this.colTechReport.MinimumWidth = 6;
            this.colTechReport.Name = "colTechReport";
            this.colTechReport.Width = 107;
            // 
            // colRepairCost
            // 
            this.colRepairCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colRepairCost.HeaderText = "Repair Cost";
            this.colRepairCost.MinimumWidth = 6;
            this.colRepairCost.Name = "colRepairCost";
            this.colRepairCost.Width = 102;
            // 
            // colRFU
            // 
            this.colRFU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colRFU.HeaderText = "RFU";
            this.colRFU.MinimumWidth = 6;
            this.colRFU.Name = "colRFU";
            this.colRFU.Width = 65;
            // 
            // colShock
            // 
            this.colShock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colShock.HeaderText = "Shock Values";
            this.colShock.MinimumWidth = 6;
            this.colShock.Name = "colShock";
            this.colShock.Width = 113;
            // 
            // colTestedFunctions
            // 
            this.colTestedFunctions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colTestedFunctions.HeaderText = "Tested Functions";
            this.colTestedFunctions.MinimumWidth = 6;
            this.colTestedFunctions.Name = "colTestedFunctions";
            this.colTestedFunctions.Width = 134;
            // 
            // colAdditionalTests
            // 
            this.colAdditionalTests.HeaderText = "Additional Tests";
            this.colAdditionalTests.MinimumWidth = 6;
            this.colAdditionalTests.Name = "colAdditionalTests";
            this.colAdditionalTests.Width = 127;
            // 
            // colFailureMode
            // 
            this.colFailureMode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colFailureMode.HeaderText = "Failure Mode";
            this.colFailureMode.MinimumWidth = 6;
            this.colFailureMode.Name = "colFailureMode";
            this.colFailureMode.Width = 109;
            // 
            // colQAInformation
            // 
            this.colQAInformation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colQAInformation.HeaderText = "Additional QA Information";
            this.colQAInformation.MinimumWidth = 6;
            this.colQAInformation.Name = "colQAInformation";
            this.colQAInformation.Width = 180;
            // 
            // colPhoto
            // 
            this.colPhoto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colPhoto.HeaderText = "Photo Path";
            this.colPhoto.MinimumWidth = 6;
            this.colPhoto.Name = "colPhoto";
            this.colPhoto.Width = 99;
            // 
            // colEdit
            // 
            this.colEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colEdit.HeaderText = "Edit";
            this.colEdit.MinimumWidth = 6;
            this.colEdit.Name = "colEdit";
            this.colEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colEdit.Width = 61;
            // 
            // colRemove
            // 
            this.colRemove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colRemove.HeaderText = "Remove";
            this.colRemove.MinimumWidth = 6;
            this.colRemove.Name = "colRemove";
            this.colRemove.Width = 66;
            // 
            // grpCustomerInformation
            // 
            this.grpCustomerInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCustomerInformation.Controls.Add(this.txtZipCode);
            this.grpCustomerInformation.Controls.Add(this.label12);
            this.grpCustomerInformation.Controls.Add(this.txtCountry);
            this.grpCustomerInformation.Controls.Add(this.label11);
            this.grpCustomerInformation.Controls.Add(this.txtProvince);
            this.grpCustomerInformation.Controls.Add(this.label10);
            this.grpCustomerInformation.Controls.Add(this.txtCity);
            this.grpCustomerInformation.Controls.Add(this.label9);
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
            this.grpCustomerInformation.Controls.Add(this.txtStreetAddress);
            this.grpCustomerInformation.Controls.Add(this.label3);
            this.grpCustomerInformation.Controls.Add(this.txtCustomerSite);
            this.grpCustomerInformation.Controls.Add(this.label2);
            this.grpCustomerInformation.Location = new System.Drawing.Point(25, 13);
            this.grpCustomerInformation.Margin = new System.Windows.Forms.Padding(4);
            this.grpCustomerInformation.Name = "grpCustomerInformation";
            this.grpCustomerInformation.Padding = new System.Windows.Forms.Padding(4);
            this.grpCustomerInformation.Size = new System.Drawing.Size(1187, 282);
            this.grpCustomerInformation.TabIndex = 0;
            this.grpCustomerInformation.TabStop = false;
            this.grpCustomerInformation.Text = "Customer Information";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(136, 222);
            this.txtZipCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(412, 22);
            this.txtZipCode.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 225);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = "Postal/Zip Code";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(136, 192);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(4);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(412, 22);
            this.txtCountry.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(70, 195);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "Country";
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(136, 162);
            this.txtProvince.Margin = new System.Windows.Forms.Padding(4);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(412, 22);
            this.txtProvince.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 165);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Province/State";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(136, 132);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(412, 22);
            this.txtCity.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(96, 133);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "City";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Preset";
            // 
            // cmbPreset
            // 
            this.cmbPreset.FormattingEnabled = true;
            this.cmbPreset.Location = new System.Drawing.Point(136, 21);
            this.cmbPreset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPreset.Name = "cmbPreset";
            this.cmbPreset.Size = new System.Drawing.Size(168, 24);
            this.cmbPreset.TabIndex = 2;
            this.cmbPreset.SelectedIndexChanged += new System.EventHandler(this.cmbPreset_SelectedIndexChanged);
            // 
            // txtPO
            // 
            this.txtPO.Location = new System.Drawing.Point(696, 220);
            this.txtPO.Margin = new System.Windows.Forms.Padding(4);
            this.txtPO.Name = "txtPO";
            this.txtPO.Size = new System.Drawing.Size(412, 22);
            this.txtPO.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(650, 225);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "PO#";
            // 
            // txtContactEmail
            // 
            this.txtContactEmail.Location = new System.Drawing.Point(696, 130);
            this.txtContactEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtContactEmail.Name = "txtContactEmail";
            this.txtContactEmail.Size = new System.Drawing.Size(412, 22);
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
            this.txtContactPhone.Location = new System.Drawing.Point(696, 98);
            this.txtContactPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtContactPhone.Name = "txtContactPhone";
            this.txtContactPhone.Size = new System.Drawing.Size(412, 22);
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
            this.txtContactName.Location = new System.Drawing.Point(696, 66);
            this.txtContactName.Margin = new System.Windows.Forms.Padding(4);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(412, 22);
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
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(136, 100);
            this.txtStreetAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(412, 22);
            this.txtStreetAddress.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Street Address";
            // 
            // txtCustomerSite
            // 
            this.txtCustomerSite.ForeColor = System.Drawing.Color.Black;
            this.txtCustomerSite.Location = new System.Drawing.Point(136, 66);
            this.txtCustomerSite.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerSite.Name = "txtCustomerSite";
            this.txtCustomerSite.Size = new System.Drawing.Size(412, 22);
            this.txtCustomerSite.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer Site";
            // 
            // grpWorkOrderInformation
            // 
            this.grpWorkOrderInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpWorkOrderInformation.Controls.Add(this.lblWorkOrderNumber);
            this.grpWorkOrderInformation.Location = new System.Drawing.Point(25, 29);
            this.grpWorkOrderInformation.Margin = new System.Windows.Forms.Padding(4);
            this.grpWorkOrderInformation.Name = "grpWorkOrderInformation";
            this.grpWorkOrderInformation.Padding = new System.Windows.Forms.Padding(4);
            this.grpWorkOrderInformation.Size = new System.Drawing.Size(1187, 61);
            this.grpWorkOrderInformation.TabIndex = 1;
            this.grpWorkOrderInformation.TabStop = false;
            this.grpWorkOrderInformation.Text = "Work Order Information";
            // 
            // lblWorkOrderNumber
            // 
            this.lblWorkOrderNumber.AutoSize = true;
            this.lblWorkOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkOrderNumber.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblWorkOrderNumber.Location = new System.Drawing.Point(16, 22);
            this.lblWorkOrderNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWorkOrderNumber.Name = "lblWorkOrderNumber";
            this.lblWorkOrderNumber.Size = new System.Drawing.Size(90, 32);
            this.lblWorkOrderNumber.TabIndex = 0;
            this.lblWorkOrderNumber.Text = "WO# ";
            // 
            // tmrCheckOut
            // 
            this.tmrCheckOut.Enabled = true;
            this.tmrCheckOut.Interval = 10000;
            this.tmrCheckOut.Tick += new System.EventHandler(this.tmrCheckOut_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 961);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStripMain);
            this.Controls.Add(this.grpWorkOrderInformation);
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
            ((System.ComponentModel.ISupportInitialize)(this.picTechSignature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSignature)).EndInit();
            this.grpReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.grpCustomerInformation.ResumeLayout(false);
            this.grpCustomerInformation.PerformLayout();
            this.grpWorkOrderInformation.ResumeLayout(false);
            this.grpWorkOrderInformation.PerformLayout();
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
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerSite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeTechNameToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.GroupBox grpReport;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.GroupBox grpClosure;
        private System.Windows.Forms.Button btnAddToReport;
        private System.Windows.Forms.PictureBox picSignature;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.CheckBox chkSignature;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presetsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPreset;
        private System.Windows.Forms.PictureBox picTechSignature;
        private System.Windows.Forms.CheckBox chkTechSignature;
        private System.Windows.Forms.ToolStripMenuItem pMTestValuesToolStripMenuItem;
        private System.Windows.Forms.Timer tmrCheckOut;
        private System.Windows.Forms.ToolStripMenuItem uploadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defineUploadPathToolStripMenuItem;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtLabourCost;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTravelCost;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtTravelHours;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtLabourHours;
        private System.Windows.Forms.TextBox txtMiscCost;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtRepairCost;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.CheckBox chkAutoUpdateCheckOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWorkType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComplaint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTechReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRepairCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRFU;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTestedFunctions;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdditionalTests;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFailureMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQAInformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhoto;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colRemove;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox chkWarranty;
    }
}

