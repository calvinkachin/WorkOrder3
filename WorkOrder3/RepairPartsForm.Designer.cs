namespace WorkOrder3
{
    partial class RepairPartsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepairPartsForm));
            this.dgvSolution = new System.Windows.Forms.DataGridView();
            this.colPartNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOldSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOldRev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNewSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNewRev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvPartsSearch = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblProblemOf = new System.Windows.Forms.Label();
            this.lblStep1 = new System.Windows.Forms.Label();
            this.lblStep2 = new System.Windows.Forms.Label();
            this.colSearchPartNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colParameters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSearchPartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUse = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartsSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSolution
            // 
            this.dgvSolution.AllowUserToAddRows = false;
            this.dgvSolution.AllowUserToDeleteRows = false;
            this.dgvSolution.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSolution.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolution.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPartNum,
            this.colPartName,
            this.colOldSN,
            this.colOldRev,
            this.colNewSN,
            this.colNewRev,
            this.colRemove});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = " ";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSolution.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSolution.Location = new System.Drawing.Point(22, 380);
            this.dgvSolution.Name = "dgvSolution";
            this.dgvSolution.RowHeadersWidth = 51;
            this.dgvSolution.RowTemplate.Height = 24;
            this.dgvSolution.Size = new System.Drawing.Size(1080, 205);
            this.dgvSolution.TabIndex = 0;
            this.dgvSolution.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSolution_CellContentClick);
            // 
            // colPartNum
            // 
            this.colPartNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPartNum.HeaderText = "Part Num";
            this.colPartNum.MinimumWidth = 6;
            this.colPartNum.Name = "colPartNum";
            this.colPartNum.Width = 96;
            // 
            // colPartName
            // 
            this.colPartName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPartName.HeaderText = "Name";
            this.colPartName.MinimumWidth = 6;
            this.colPartName.Name = "colPartName";
            // 
            // colOldSN
            // 
            this.colOldSN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colOldSN.HeaderText = "Old SN";
            this.colOldSN.MinimumWidth = 6;
            this.colOldSN.Name = "colOldSN";
            this.colOldSN.Width = 82;
            // 
            // colOldRev
            // 
            this.colOldRev.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colOldRev.HeaderText = "Old Rev";
            this.colOldRev.MinimumWidth = 6;
            this.colOldRev.Name = "colOldRev";
            this.colOldRev.Width = 88;
            // 
            // colNewSN
            // 
            this.colNewSN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colNewSN.HeaderText = "New SN";
            this.colNewSN.MinimumWidth = 6;
            this.colNewSN.Name = "colNewSN";
            this.colNewSN.Width = 87;
            // 
            // colNewRev
            // 
            this.colNewRev.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colNewRev.HeaderText = "New Rev";
            this.colNewRev.MinimumWidth = 6;
            this.colNewRev.Name = "colNewRev";
            this.colNewRev.Width = 93;
            // 
            // colRemove
            // 
            this.colRemove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colRemove.HeaderText = "Remove";
            this.colRemove.MinimumWidth = 6;
            this.colRemove.Name = "colRemove";
            this.colRemove.Text = "Remove";
            this.colRemove.UseColumnTextForButtonValue = true;
            this.colRemove.Width = 66;
            // 
            // dgvPartsSearch
            // 
            this.dgvPartsSearch.AllowUserToAddRows = false;
            this.dgvPartsSearch.AllowUserToDeleteRows = false;
            this.dgvPartsSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPartsSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartsSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSearchPartNum,
            this.colParameters,
            this.colSearchPartName,
            this.colUse});
            this.dgvPartsSearch.Location = new System.Drawing.Point(63, 94);
            this.dgvPartsSearch.Name = "dgvPartsSearch";
            this.dgvPartsSearch.ReadOnly = true;
            this.dgvPartsSearch.RowHeadersWidth = 51;
            this.dgvPartsSearch.RowTemplate.Height = 24;
            this.dgvPartsSearch.Size = new System.Drawing.Size(993, 180);
            this.dgvPartsSearch.TabIndex = 1;
            this.dgvPartsSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPartsSearch_CellContentClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearch.Location = new System.Drawing.Point(159, 66);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(897, 22);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Parts Search";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.Location = new System.Drawing.Point(950, 601);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(152, 39);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblProblemOf
            // 
            this.lblProblemOf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProblemOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProblemOf.Location = new System.Drawing.Point(21, 335);
            this.lblProblemOf.Name = "lblProblemOf";
            this.lblProblemOf.Size = new System.Drawing.Size(1081, 42);
            this.lblProblemOf.TabIndex = 5;
            this.lblProblemOf.Text = "For the problem of... the following parts were replaced:";
            this.lblProblemOf.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblStep1
            // 
            this.lblStep1.AutoSize = true;
            this.lblStep1.BackColor = System.Drawing.Color.Yellow;
            this.lblStep1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStep1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStep1.Location = new System.Drawing.Point(20, 20);
            this.lblStep1.Name = "lblStep1";
            this.lblStep1.Size = new System.Drawing.Size(314, 29);
            this.lblStep1.TabIndex = 6;
            this.lblStep1.Text = "Step 1. Search and Use Part";
            // 
            // lblStep2
            // 
            this.lblStep2.AutoSize = true;
            this.lblStep2.BackColor = System.Drawing.Color.Yellow;
            this.lblStep2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStep2.Location = new System.Drawing.Point(20, 306);
            this.lblStep2.Name = "lblStep2";
            this.lblStep2.Size = new System.Drawing.Size(309, 29);
            this.lblStep2.TabIndex = 7;
            this.lblStep2.Text = "Step 2. Input Serial and Rev";
            // 
            // colSearchPartNum
            // 
            this.colSearchPartNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSearchPartNum.HeaderText = "Part Num";
            this.colSearchPartNum.MinimumWidth = 6;
            this.colSearchPartNum.Name = "colSearchPartNum";
            this.colSearchPartNum.ReadOnly = true;
            this.colSearchPartNum.Width = 96;
            // 
            // colParameters
            // 
            this.colParameters.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colParameters.HeaderText = "Param";
            this.colParameters.MinimumWidth = 6;
            this.colParameters.Name = "colParameters";
            this.colParameters.ReadOnly = true;
            this.colParameters.Width = 78;
            // 
            // colSearchPartName
            // 
            this.colSearchPartName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSearchPartName.HeaderText = "Name";
            this.colSearchPartName.MinimumWidth = 6;
            this.colSearchPartName.Name = "colSearchPartName";
            this.colSearchPartName.ReadOnly = true;
            this.colSearchPartName.Width = 74;
            // 
            // colUse
            // 
            this.colUse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colUse.HeaderText = "Use Part";
            this.colUse.MinimumWidth = 6;
            this.colUse.Name = "colUse";
            this.colUse.ReadOnly = true;
            this.colUse.Text = "Use Part";
            this.colUse.UseColumnTextForButtonValue = true;
            this.colUse.Width = 69;
            // 
            // RepairPartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1123, 653);
            this.Controls.Add(this.lblStep2);
            this.Controls.Add(this.lblStep1);
            this.Controls.Add(this.lblProblemOf);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvPartsSearch);
            this.Controls.Add(this.dgvSolution);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RepairPartsForm";
            this.Text = "RepairPartsForm";
            this.Load += new System.EventHandler(this.RepairPartsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartsSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSolution;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPartNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOldSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOldRev;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNewSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNewRev;
        private System.Windows.Forms.DataGridViewButtonColumn colRemove;
        private System.Windows.Forms.DataGridView dgvPartsSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblProblemOf;
        private System.Windows.Forms.Label lblStep1;
        private System.Windows.Forms.Label lblStep2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSearchPartNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParameters;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSearchPartName;
        private System.Windows.Forms.DataGridViewButtonColumn colUse;
    }
}