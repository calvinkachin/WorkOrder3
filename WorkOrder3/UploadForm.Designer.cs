namespace WorkOrder3
{
    partial class UploadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadForm));
            this.txtUploadPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvWorkOrders = new System.Windows.Forms.DataGridView();
            this.colWorkOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTasks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.cmbDestinationColumn = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUploadPath
            // 
            this.txtUploadPath.Location = new System.Drawing.Point(16, 47);
            this.txtUploadPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUploadPath.Name = "txtUploadPath";
            this.txtUploadPath.Size = new System.Drawing.Size(436, 22);
            this.txtUploadPath.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(461, 44);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(100, 28);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kanban Path*";
            // 
            // dgvWorkOrders
            // 
            this.dgvWorkOrders.AllowUserToAddRows = false;
            this.dgvWorkOrders.AllowUserToDeleteRows = false;
            this.dgvWorkOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWorkOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colWorkOrder,
            this.colCustomer,
            this.colDate,
            this.colItems,
            this.colTasks,
            this.colCheck});
            this.dgvWorkOrders.Location = new System.Drawing.Point(15, 179);
            this.dgvWorkOrders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvWorkOrders.Name = "dgvWorkOrders";
            this.dgvWorkOrders.Size = new System.Drawing.Size(843, 226);
            this.dgvWorkOrders.TabIndex = 3;
            // 
            // colWorkOrder
            // 
            this.colWorkOrder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colWorkOrder.HeaderText = "Work Order";
            this.colWorkOrder.Name = "colWorkOrder";
            // 
            // colCustomer
            // 
            this.colCustomer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCustomer.HeaderText = "Customer";
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.Width = 97;
            // 
            // colDate
            // 
            this.colDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Width = 67;
            // 
            // colItems
            // 
            this.colItems.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colItems.HeaderText = "Items";
            this.colItems.Name = "colItems";
            this.colItems.Width = 70;
            // 
            // colTasks
            // 
            this.colTasks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTasks.HeaderText = "Tasks to be Created";
            this.colTasks.Name = "colTasks";
            this.colTasks.Width = 88;
            // 
            // colCheck
            // 
            this.colCheck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCheck.FalseValue = "False";
            this.colCheck.HeaderText = "Upload?";
            this.colCheck.Name = "colCheck";
            this.colCheck.TrueValue = "True";
            this.colCheck.Width = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Work Orders Available for Upload";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(16, 448);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(220, 57);
            this.btnUpload.TabIndex = 5;
            this.btnUpload.Text = "Upload and Archive";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // cmbDestinationColumn
            // 
            this.cmbDestinationColumn.FormattingEnabled = true;
            this.cmbDestinationColumn.Location = new System.Drawing.Point(15, 102);
            this.cmbDestinationColumn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDestinationColumn.Name = "cmbDestinationColumn";
            this.cmbDestinationColumn.Size = new System.Drawing.Size(436, 24);
            this.cmbDestinationColumn.TabIndex = 6;
            this.cmbDestinationColumn.SelectedIndexChanged += new System.EventHandler(this.cmbDestinationColumn_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Upload Destination*";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(459, 105);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(236, 17);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Please select an Upload Destination";
            // 
            // UploadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 530);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbDestinationColumn);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvWorkOrders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtUploadPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UploadForm";
            this.Text = "UploadForm";
            this.Load += new System.EventHandler(this.UploadForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUploadPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvWorkOrders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.ComboBox cmbDestinationColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWorkOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTasks;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCheck;
        private System.Windows.Forms.Label lblStatus;
    }
}