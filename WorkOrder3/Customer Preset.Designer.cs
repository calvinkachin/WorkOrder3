namespace WorkOrder3
{
    partial class Customer_Preset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Preset));
            this.grpCustomerInformation = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblSaved = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtUnitList = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPresetName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpCustomerInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCustomerInformation
            // 
            this.grpCustomerInformation.Controls.Add(this.label8);
            this.grpCustomerInformation.Controls.Add(this.btnBrowse);
            this.grpCustomerInformation.Controls.Add(this.lblSaved);
            this.grpCustomerInformation.Controls.Add(this.btnConfirm);
            this.grpCustomerInformation.Controls.Add(this.txtUnitList);
            this.grpCustomerInformation.Controls.Add(this.label7);
            this.grpCustomerInformation.Controls.Add(this.txtPresetName);
            this.grpCustomerInformation.Controls.Add(this.label1);
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
            this.grpCustomerInformation.Enabled = false;
            this.grpCustomerInformation.Location = new System.Drawing.Point(165, 10);
            this.grpCustomerInformation.Name = "grpCustomerInformation";
            this.grpCustomerInformation.Size = new System.Drawing.Size(453, 386);
            this.grpCustomerInformation.TabIndex = 1;
            this.grpCustomerInformation.TabStop = false;
            this.grpCustomerInformation.Text = "Customer Information";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(312, 26);
            this.label8.TabIndex = 19;
            this.label8.Text = "File must be text or csv. The file will be copied to the Units folder,\r\nand named" +
    " after the Customer Site.";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(314, 265);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(62, 24);
            this.btnBrowse.TabIndex = 18;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblSaved
            // 
            this.lblSaved.AutoSize = true;
            this.lblSaved.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblSaved.Location = new System.Drawing.Point(231, 342);
            this.lblSaved.Name = "lblSaved";
            this.lblSaved.Size = new System.Drawing.Size(84, 13);
            this.lblSaved.TabIndex = 17;
            this.lblSaved.Text = "Changes saved!";
            this.lblSaved.Visible = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(118, 334);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(99, 29);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtUnitList
            // 
            this.txtUnitList.Location = new System.Drawing.Point(118, 268);
            this.txtUnitList.Name = "txtUnitList";
            this.txtUnitList.Size = new System.Drawing.Size(192, 20);
            this.txtUnitList.TabIndex = 9;
            this.txtUnitList.TextChanged += new System.EventHandler(this.txtUnitList_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Customer Unit List";
            // 
            // txtPresetName
            // 
            this.txtPresetName.ForeColor = System.Drawing.Color.Black;
            this.txtPresetName.Location = new System.Drawing.Point(118, 37);
            this.txtPresetName.Name = "txtPresetName";
            this.txtPresetName.Size = new System.Drawing.Size(192, 20);
            this.txtPresetName.TabIndex = 3;
            this.txtPresetName.TextChanged += new System.EventHandler(this.txtPresetName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Preset Name*";
            // 
            // txtContactEmail
            // 
            this.txtContactEmail.Location = new System.Drawing.Point(118, 214);
            this.txtContactEmail.Name = "txtContactEmail";
            this.txtContactEmail.Size = new System.Drawing.Size(192, 20);
            this.txtContactEmail.TabIndex = 8;
            this.txtContactEmail.TextChanged += new System.EventHandler(this.txtContactEmail_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Contact Email";
            // 
            // txtContactPhone
            // 
            this.txtContactPhone.Location = new System.Drawing.Point(118, 188);
            this.txtContactPhone.Name = "txtContactPhone";
            this.txtContactPhone.Size = new System.Drawing.Size(192, 20);
            this.txtContactPhone.TabIndex = 7;
            this.txtContactPhone.TextChanged += new System.EventHandler(this.txtContactPhone_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Contact Phone";
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(118, 162);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(192, 20);
            this.txtContactName.TabIndex = 6;
            this.txtContactName.TextChanged += new System.EventHandler(this.txtContactName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Contact Name";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(118, 117);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(305, 20);
            this.txtAddress.TabIndex = 5;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address*";
            // 
            // txtCustomerSite
            // 
            this.txtCustomerSite.ForeColor = System.Drawing.Color.Black;
            this.txtCustomerSite.Location = new System.Drawing.Point(118, 91);
            this.txtCustomerSite.Name = "txtCustomerSite";
            this.txtCustomerSite.Size = new System.Drawing.Size(192, 20);
            this.txtCustomerSite.TabIndex = 4;
            this.txtCustomerSite.TextChanged += new System.EventHandler(this.txtCustomerSite_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer Site*";
            // 
            // lstCustomers
            // 
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.Location = new System.Drawing.Point(9, 10);
            this.lstCustomers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(152, 355);
            this.lstCustomers.TabIndex = 1;
            this.lstCustomers.SelectedIndexChanged += new System.EventHandler(this.lstCustomers_SelectedIndexChanged);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(9, 371);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(71, 24);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(88, 371);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(71, 24);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Customer_Preset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 406);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lstCustomers);
            this.Controls.Add(this.grpCustomerInformation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Customer_Preset";
            this.Text = "Customer_Preset";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Customer_Preset_FormClosing);
            this.Load += new System.EventHandler(this.Customer_Preset_Load);
            this.grpCustomerInformation.ResumeLayout(false);
            this.grpCustomerInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCustomerInformation;
        private System.Windows.Forms.TextBox txtPresetName;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.TextBox txtUnitList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblSaved;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label8;
    }
}