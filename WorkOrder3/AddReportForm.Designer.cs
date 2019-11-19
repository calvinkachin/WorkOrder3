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
            this.chkTestedFunctions = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.grpFinish = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOtherModel = new System.Windows.Forms.TextBox();
            this.grpOtherWorkType.SuspendLayout();
            this.grpFailureEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShockValues)).BeginInit();
            this.grpShockValues.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.grpFinish.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkFailedPM
            // 
            this.chkFailedPM.AutoSize = true;
            this.chkFailedPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFailedPM.ForeColor = System.Drawing.Color.Red;
            this.chkFailedPM.Location = new System.Drawing.Point(47, 307);
            this.chkFailedPM.Name = "chkFailedPM";
            this.chkFailedPM.Size = new System.Drawing.Size(117, 28);
            this.chkFailedPM.TabIndex = 45;
            this.chkFailedPM.Text = "Failed PM";
            this.chkFailedPM.UseVisualStyleBackColor = true;
            this.chkFailedPM.Visible = false;
            // 
            // grpOtherWorkType
            // 
            this.grpOtherWorkType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOtherWorkType.Controls.Add(this.txtOtherWorkType);
            this.grpOtherWorkType.Location = new System.Drawing.Point(378, 13);
            this.grpOtherWorkType.Margin = new System.Windows.Forms.Padding(4);
            this.grpOtherWorkType.Name = "grpOtherWorkType";
            this.grpOtherWorkType.Padding = new System.Windows.Forms.Padding(4);
            this.grpOtherWorkType.Size = new System.Drawing.Size(204, 60);
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
            this.txtOtherWorkType.Size = new System.Drawing.Size(188, 22);
            this.txtOtherWorkType.TabIndex = 10;
            // 
            // grpFailureEvent
            // 
            this.grpFailureEvent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFailureEvent.Controls.Add(this.txtPatient);
            this.grpFailureEvent.Controls.Add(this.cmbFailureEvent);
            this.grpFailureEvent.Location = new System.Drawing.Point(12, 686);
            this.grpFailureEvent.Margin = new System.Windows.Forms.Padding(4);
            this.grpFailureEvent.Name = "grpFailureEvent";
            this.grpFailureEvent.Padding = new System.Windows.Forms.Padding(4);
            this.grpFailureEvent.Size = new System.Drawing.Size(589, 90);
            this.grpFailureEvent.TabIndex = 39;
            this.grpFailureEvent.TabStop = false;
            this.grpFailureEvent.Text = "Failure Event";
            this.grpFailureEvent.Visible = false;
            // 
            // txtPatient
            // 
            this.txtPatient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPatient.Location = new System.Drawing.Point(8, 54);
            this.txtPatient.Name = "txtPatient";
            this.txtPatient.Size = new System.Drawing.Size(574, 22);
            this.txtPatient.TabIndex = 17;
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
            this.cmbFailureEvent.Location = new System.Drawing.Point(8, 23);
            this.cmbFailureEvent.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFailureEvent.Name = "cmbFailureEvent";
            this.cmbFailureEvent.Size = new System.Drawing.Size(285, 24);
            this.cmbFailureEvent.TabIndex = 16;
            // 
            // btnAddToReport
            // 
            this.btnAddToReport.Location = new System.Drawing.Point(17, 22);
            this.btnAddToReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddToReport.Name = "btnAddToReport";
            this.btnAddToReport.Size = new System.Drawing.Size(256, 43);
            this.btnAddToReport.TabIndex = 41;
            this.btnAddToReport.Text = "Add to Report";
            this.btnAddToReport.UseVisualStyleBackColor = true;
            this.btnAddToReport.Click += new System.EventHandler(this.btnAddToReport_Click);
            // 
            // txtTechReport
            // 
            this.txtTechReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTechReport.Location = new System.Drawing.Point(115, 243);
            this.txtTechReport.Margin = new System.Windows.Forms.Padding(4);
            this.txtTechReport.Multiline = true;
            this.txtTechReport.Name = "txtTechReport";
            this.txtTechReport.Size = new System.Drawing.Size(459, 52);
            this.txtTechReport.TabIndex = 38;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(22, 247);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 17);
            this.label14.TabIndex = 43;
            this.label14.Text = "Tech Report";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(17, 157);
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
            this.cmbRFU.Location = new System.Drawing.Point(115, 157);
            this.cmbRFU.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRFU.Name = "cmbRFU";
            this.cmbRFU.Size = new System.Drawing.Size(255, 24);
            this.cmbRFU.TabIndex = 35;
            // 
            // txtComplaint
            // 
            this.txtComplaint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComplaint.Location = new System.Drawing.Point(115, 189);
            this.txtComplaint.Margin = new System.Windows.Forms.Padding(4);
            this.txtComplaint.Multiline = true;
            this.txtComplaint.Name = "txtComplaint";
            this.txtComplaint.Size = new System.Drawing.Size(459, 46);
            this.txtComplaint.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(21, 189);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 21);
            this.label12.TabIndex = 40;
            this.label12.Text = "Complaint";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSerial
            // 
            this.txtSerial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSerial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSerial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSerial.Location = new System.Drawing.Point(114, 97);
            this.txtSerial.Margin = new System.Windows.Forms.Padding(4);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(255, 22);
            this.txtSerial.TabIndex = 31;
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
            this.label9.Size = new System.Drawing.Size(90, 18);
            this.label9.TabIndex = 34;
            this.label9.Text = "Work Type";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.cmbWorkType.Location = new System.Drawing.Point(115, 34);
            this.cmbWorkType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbWorkType.Name = "cmbWorkType";
            this.cmbWorkType.Size = new System.Drawing.Size(255, 24);
            this.cmbWorkType.TabIndex = 30;
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
            this.dgvShockValues.Location = new System.Drawing.Point(19, 48);
            this.dgvShockValues.Name = "dgvShockValues";
            this.dgvShockValues.RowTemplate.Height = 24;
            this.dgvShockValues.Size = new System.Drawing.Size(314, 253);
            this.dgvShockValues.TabIndex = 46;
            // 
            // colLevel
            // 
            this.colLevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.colLevel.DefaultCellStyle = dataGridViewCellStyle1;
            this.colLevel.HeaderText = "Level";
            this.colLevel.Name = "colLevel";
            this.colLevel.ReadOnly = true;
            // 
            // colValue
            // 
            this.colValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colValue.HeaderText = "Value";
            this.colValue.Name = "colValue";
            this.colValue.Width = 73;
            // 
            // grpShockValues
            // 
            this.grpShockValues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpShockValues.Controls.Add(this.label3);
            this.grpShockValues.Controls.Add(this.label2);
            this.grpShockValues.Controls.Add(this.chkTestedFunctions);
            this.grpShockValues.Controls.Add(this.dgvShockValues);
            this.grpShockValues.Controls.Add(this.chkFailedPM);
            this.grpShockValues.Location = new System.Drawing.Point(12, 331);
            this.grpShockValues.Name = "grpShockValues";
            this.grpShockValues.Size = new System.Drawing.Size(589, 348);
            this.grpShockValues.TabIndex = 47;
            this.grpShockValues.TabStop = false;
            this.grpShockValues.Text = "PM";
            this.grpShockValues.Visible = false;
            // 
            // chkTestedFunctions
            // 
            this.chkTestedFunctions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTestedFunctions.CheckOnClick = true;
            this.chkTestedFunctions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTestedFunctions.FormattingEnabled = true;
            this.chkTestedFunctions.Location = new System.Drawing.Point(340, 51);
            this.chkTestedFunctions.Margin = new System.Windows.Forms.Padding(4);
            this.chkTestedFunctions.Name = "chkTestedFunctions";
            this.chkTestedFunctions.Size = new System.Drawing.Size(242, 251);
            this.chkTestedFunctions.TabIndex = 47;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(0, 50);
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(0, 75);
            this.panel1.Controls.Add(this.grpFinish);
            this.panel1.Controls.Add(this.grpInfo);
            this.panel1.Controls.Add(this.grpShockValues);
            this.panel1.Controls.Add(this.grpFailureEvent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 667);
            this.panel1.TabIndex = 48;
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
            // grpInfo
            // 
            this.grpInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInfo.Controls.Add(this.groupBox1);
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
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(589, 313);
            this.grpInfo.TabIndex = 50;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Work Information";
            // 
            // grpFinish
            // 
            this.grpFinish.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFinish.Controls.Add(this.btnAddToReport);
            this.grpFinish.Location = new System.Drawing.Point(12, 783);
            this.grpFinish.Name = "grpFinish";
            this.grpFinish.Size = new System.Drawing.Size(589, 77);
            this.grpFinish.TabIndex = 51;
            this.grpFinish.TabStop = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 17);
            this.label2.TabIndex = 50;
            this.label2.Text = "Shock/Pace Values";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(337, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Tested Functions";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Items.AddRange(new object[] {
            "AED-3",
            "AED-PLUS",
            "AED-PRO",
            "E-SERIES",
            "M-SERIES",
            "PROPAQ",
            "R-SERIES",
            "X-SERIES",
            "Other..."});
            this.cmbModel.Location = new System.Drawing.Point(114, 126);
            this.cmbModel.Margin = new System.Windows.Forms.Padding(4);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(255, 24);
            this.cmbModel.TabIndex = 50;
            this.cmbModel.SelectedIndexChanged += new System.EventHandler(this.cmbModel_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtOtherModel);
            this.groupBox1.Location = new System.Drawing.Point(377, 105);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(204, 60);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Other Model Type";
            this.groupBox1.Visible = false;
            // 
            // txtOtherModel
            // 
            this.txtOtherModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOtherModel.Location = new System.Drawing.Point(8, 23);
            this.txtOtherModel.Margin = new System.Windows.Forms.Padding(4);
            this.txtOtherModel.Name = "txtOtherModel";
            this.txtOtherModel.Size = new System.Drawing.Size(188, 22);
            this.txtOtherModel.TabIndex = 10;
            // 
            // AddReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 667);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddReportForm";
            this.Text = "Add Report";
            this.Load += new System.EventHandler(this.AddReportForm_Load);
            this.grpOtherWorkType.ResumeLayout(false);
            this.grpOtherWorkType.PerformLayout();
            this.grpFailureEvent.ResumeLayout(false);
            this.grpFailureEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShockValues)).EndInit();
            this.grpShockValues.ResumeLayout(false);
            this.grpShockValues.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.grpFinish.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.CheckedListBox chkTestedFunctions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpFinish;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOtherModel;
    }
}