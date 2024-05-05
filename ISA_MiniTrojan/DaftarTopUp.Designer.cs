namespace ISA_MiniTrojan
{
    partial class DaftarTopUp
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
            this.dataGridViewTopUp = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTopUpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNominal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStaffId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.labelNoInvoice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTopUp)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTopUp
            // 
            this.dataGridViewTopUp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTopUp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnUserId,
            this.ColumnTopUpDate,
            this.ColumnNominal,
            this.ColumnStatus,
            this.ColumnStaffId,
            this.btnDetail});
            this.dataGridViewTopUp.Location = new System.Drawing.Point(9, 54);
            this.dataGridViewTopUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewTopUp.Name = "dataGridViewTopUp";
            this.dataGridViewTopUp.RowHeadersWidth = 51;
            this.dataGridViewTopUp.RowTemplate.Height = 24;
            this.dataGridViewTopUp.Size = new System.Drawing.Size(542, 283);
            this.dataGridViewTopUp.TabIndex = 0;
            this.dataGridViewTopUp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTopUp_CellContentClick);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "ID";
            this.ColumnId.MinimumWidth = 6;
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Width = 125;
            // 
            // ColumnUserId
            // 
            this.ColumnUserId.HeaderText = "User Id";
            this.ColumnUserId.MinimumWidth = 6;
            this.ColumnUserId.Name = "ColumnUserId";
            this.ColumnUserId.ReadOnly = true;
            this.ColumnUserId.Width = 125;
            // 
            // ColumnTopUpDate
            // 
            this.ColumnTopUpDate.HeaderText = "Topup Date";
            this.ColumnTopUpDate.MinimumWidth = 6;
            this.ColumnTopUpDate.Name = "ColumnTopUpDate";
            this.ColumnTopUpDate.ReadOnly = true;
            this.ColumnTopUpDate.Width = 125;
            // 
            // ColumnNominal
            // 
            this.ColumnNominal.HeaderText = "Nominal";
            this.ColumnNominal.MinimumWidth = 6;
            this.ColumnNominal.Name = "ColumnNominal";
            this.ColumnNominal.ReadOnly = true;
            this.ColumnNominal.Width = 125;
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.HeaderText = "Status";
            this.ColumnStatus.MinimumWidth = 6;
            this.ColumnStatus.Name = "ColumnStatus";
            this.ColumnStatus.ReadOnly = true;
            this.ColumnStatus.Width = 125;
            // 
            // ColumnStaffId
            // 
            this.ColumnStaffId.HeaderText = "Staff ID";
            this.ColumnStaffId.MinimumWidth = 6;
            this.ColumnStaffId.Name = "ColumnStaffId";
            this.ColumnStaffId.ReadOnly = true;
            this.ColumnStaffId.Width = 125;
            // 
            // btnDetail
            // 
            this.btnDetail.HeaderText = "Aksi";
            this.btnDetail.MinimumWidth = 6;
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.ReadOnly = true;
            this.btnDetail.Text = "Detail";
            this.btnDetail.UseColumnTextForButtonValue = true;
            this.btnDetail.Width = 125;
            // 
            // labelNoInvoice
            // 
            this.labelNoInvoice.BackColor = System.Drawing.Color.Firebrick;
            this.labelNoInvoice.Font = new System.Drawing.Font("Magneto", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.labelNoInvoice.Location = new System.Drawing.Point(129, 8);
            this.labelNoInvoice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNoInvoice.Name = "labelNoInvoice";
            this.labelNoInvoice.Size = new System.Drawing.Size(314, 44);
            this.labelNoInvoice.TabIndex = 38;
            this.labelNoInvoice.Text = "Daftar Top-Up";
            this.labelNoInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DaftarTopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ISA_MiniTrojan.Properties.Resources.backgroundFix;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(560, 387);
            this.Controls.Add(this.labelNoInvoice);
            this.Controls.Add(this.dataGridViewTopUp);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DaftarTopUp";
            this.Text = "TopUp";
            this.Load += new System.EventHandler(this.TopUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTopUp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTopUp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTopUpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNominal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStaffId;
        private System.Windows.Forms.DataGridViewButtonColumn btnDetail;
        private System.Windows.Forms.Label labelNoInvoice;
    }
}