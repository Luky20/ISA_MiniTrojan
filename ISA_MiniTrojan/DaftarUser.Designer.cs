namespace ISA_MiniTrojan
{
    partial class DaftarUser
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSisaPercobaanLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTransaksi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAktivasi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.labelNoInvoice = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoRoundedCorners = true;
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 19;
            this.guna2Panel1.Controls.Add(this.textBoxUsername);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(2)))), ((int)(((byte)(3)))));
            this.guna2Panel1.Location = new System.Drawing.Point(17, 80);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(699, 41);
            this.guna2Panel1.TabIndex = 42;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(203, 9);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(460, 23);
            this.textBoxUsername.TabIndex = 19;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Search Username";
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnUsername,
            this.ColumnEmail,
            this.ColumnNama,
            this.ColumnSaldo,
            this.ColumnSisaPercobaanLogin,
            this.btnTransaksi,
            this.btnAktivasi});
            this.dataGridViewUser.Location = new System.Drawing.Point(17, 132);
            this.dataGridViewUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.RowHeadersWidth = 51;
            this.dataGridViewUser.RowTemplate.Height = 24;
            this.dataGridViewUser.Size = new System.Drawing.Size(699, 288);
            this.dataGridViewUser.TabIndex = 41;
            this.dataGridViewUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUser_CellContentClick);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.MinimumWidth = 6;
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Width = 125;
            // 
            // ColumnUsername
            // 
            this.ColumnUsername.HeaderText = "Username";
            this.ColumnUsername.MinimumWidth = 6;
            this.ColumnUsername.Name = "ColumnUsername";
            this.ColumnUsername.ReadOnly = true;
            this.ColumnUsername.Width = 125;
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.HeaderText = "Email";
            this.ColumnEmail.MinimumWidth = 6;
            this.ColumnEmail.Name = "ColumnEmail";
            this.ColumnEmail.ReadOnly = true;
            this.ColumnEmail.Width = 125;
            // 
            // ColumnNama
            // 
            this.ColumnNama.HeaderText = "Nama";
            this.ColumnNama.MinimumWidth = 6;
            this.ColumnNama.Name = "ColumnNama";
            this.ColumnNama.ReadOnly = true;
            this.ColumnNama.Width = 125;
            // 
            // ColumnSaldo
            // 
            this.ColumnSaldo.HeaderText = "Saldo";
            this.ColumnSaldo.MinimumWidth = 6;
            this.ColumnSaldo.Name = "ColumnSaldo";
            this.ColumnSaldo.ReadOnly = true;
            this.ColumnSaldo.Width = 125;
            // 
            // ColumnSisaPercobaanLogin
            // 
            this.ColumnSisaPercobaanLogin.HeaderText = "Sisa Percobaan Login";
            this.ColumnSisaPercobaanLogin.MinimumWidth = 6;
            this.ColumnSisaPercobaanLogin.Name = "ColumnSisaPercobaanLogin";
            this.ColumnSisaPercobaanLogin.ReadOnly = true;
            this.ColumnSisaPercobaanLogin.Width = 125;
            // 
            // btnTransaksi
            // 
            this.btnTransaksi.HeaderText = "Transaksi";
            this.btnTransaksi.MinimumWidth = 6;
            this.btnTransaksi.Name = "btnTransaksi";
            this.btnTransaksi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnTransaksi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnTransaksi.Text = "Lihat";
            this.btnTransaksi.UseColumnTextForButtonValue = true;
            this.btnTransaksi.Width = 125;
            // 
            // btnAktivasi
            // 
            this.btnAktivasi.HeaderText = "Aksi";
            this.btnAktivasi.MinimumWidth = 6;
            this.btnAktivasi.Name = "btnAktivasi";
            this.btnAktivasi.Text = "Aktivasi";
            this.btnAktivasi.UseColumnTextForButtonValue = true;
            this.btnAktivasi.Width = 125;
            // 
            // labelNoInvoice
            // 
            this.labelNoInvoice.BackColor = System.Drawing.Color.Firebrick;
            this.labelNoInvoice.Font = new System.Drawing.Font("Magneto", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.labelNoInvoice.Location = new System.Drawing.Point(212, 23);
            this.labelNoInvoice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNoInvoice.Name = "labelNoInvoice";
            this.labelNoInvoice.Size = new System.Drawing.Size(314, 44);
            this.labelNoInvoice.TabIndex = 43;
            this.labelNoInvoice.Text = "Daftar User";
            this.labelNoInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DaftarUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ISA_MiniTrojan.Properties.Resources.backgroundFix;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(735, 464);
            this.Controls.Add(this.labelNoInvoice);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.dataGridViewUser);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DaftarUser";
            this.Text = "DaftarUser";
            this.Load += new System.EventHandler(this.DaftarUser_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSisaPercobaanLogin;
        private System.Windows.Forms.DataGridViewButtonColumn btnTransaksi;
        private System.Windows.Forms.DataGridViewButtonColumn btnAktivasi;
        private System.Windows.Forms.Label labelNoInvoice;
    }
}