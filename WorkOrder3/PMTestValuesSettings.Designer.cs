namespace WorkOrder3
{
    partial class PMTestValuesSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PMTestValuesSettings));
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTestedFunctions = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.colAdditionalTest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestedFunctions)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(30, 47);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(208, 24);
            this.cmbModel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Model";
            // 
            // dgvTestedFunctions
            // 
            this.dgvTestedFunctions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestedFunctions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAdditionalTest});
            this.dgvTestedFunctions.Location = new System.Drawing.Point(30, 114);
            this.dgvTestedFunctions.Name = "dgvTestedFunctions";
            this.dgvTestedFunctions.RowTemplate.Height = 24;
            this.dgvTestedFunctions.Size = new System.Drawing.Size(698, 322);
            this.dgvTestedFunctions.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tested Functions";
            // 
            // colAdditionalTest
            // 
            this.colAdditionalTest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAdditionalTest.HeaderText = "Test Name (Acceptable Value Range)";
            this.colAdditionalTest.Name = "colAdditionalTest";
            // 
            // PMTestValuesSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 458);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvTestedFunctions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbModel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PMTestValuesSettings";
            this.Text = "Additional Test Values";
            this.Load += new System.EventHandler(this.PMTestValuesSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestedFunctions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTestedFunctions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdditionalTest;
    }
}