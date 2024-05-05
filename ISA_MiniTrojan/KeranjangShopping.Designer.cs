namespace ISA_MiniTrojan
{
    partial class KeranjangShopping
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
            this.labelNoInvoice = new System.Windows.Forms.Label();
            this.dataGridViewKeranjang = new System.Windows.Forms.DataGridView();
            this.ColumnPilih = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CollumnNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnJumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.labelItems = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonBeli = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKeranjang)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNoInvoice
            // 
            this.labelNoInvoice.BackColor = System.Drawing.Color.Firebrick;
            this.labelNoInvoice.Font = new System.Drawing.Font("Magneto", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.labelNoInvoice.Location = new System.Drawing.Point(167, 26);
            this.labelNoInvoice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNoInvoice.Name = "labelNoInvoice";
            this.labelNoInvoice.Size = new System.Drawing.Size(322, 44);
            this.labelNoInvoice.TabIndex = 27;
            this.labelNoInvoice.Text = "Shopping Cart";
            this.labelNoInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewKeranjang
            // 
            this.dataGridViewKeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKeranjang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPilih,
            this.CollumnNama,
            this.ColumnHarga,
            this.ColumnJumlah});
            this.dataGridViewKeranjang.Location = new System.Drawing.Point(29, 91);
            this.dataGridViewKeranjang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewKeranjang.Name = "dataGridViewKeranjang";
            this.dataGridViewKeranjang.RowHeadersWidth = 51;
            this.dataGridViewKeranjang.RowTemplate.Height = 24;
            this.dataGridViewKeranjang.Size = new System.Drawing.Size(597, 231);
            this.dataGridViewKeranjang.TabIndex = 28;
            this.dataGridViewKeranjang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKeranjang_CellContentClick);
            // 
            // ColumnPilih
            // 
            this.ColumnPilih.FalseValue = "false";
            this.ColumnPilih.HeaderText = "Pilih";
            this.ColumnPilih.MinimumWidth = 6;
            this.ColumnPilih.Name = "ColumnPilih";
            this.ColumnPilih.TrueValue = "true";
            this.ColumnPilih.Width = 125;
            // 
            // CollumnNama
            // 
            this.CollumnNama.HeaderText = "Nama Produk";
            this.CollumnNama.MinimumWidth = 6;
            this.CollumnNama.Name = "CollumnNama";
            this.CollumnNama.ReadOnly = true;
            this.CollumnNama.Width = 125;
            // 
            // ColumnHarga
            // 
            this.ColumnHarga.HeaderText = "Harga Produk";
            this.ColumnHarga.MinimumWidth = 6;
            this.ColumnHarga.Name = "ColumnHarga";
            this.ColumnHarga.ReadOnly = true;
            this.ColumnHarga.Width = 125;
            // 
            // ColumnJumlah
            // 
            this.ColumnJumlah.HeaderText = "Jumlah";
            this.ColumnJumlah.MinimumWidth = 6;
            this.ColumnJumlah.Name = "ColumnJumlah";
            this.ColumnJumlah.ReadOnly = true;
            this.ColumnJumlah.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Firebrick;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.label1.Location = new System.Drawing.Point(536, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "Items";
            // 
            // labelItems
            // 
            this.labelItems.BackColor = System.Drawing.Color.Firebrick;
            this.labelItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.labelItems.Location = new System.Drawing.Point(514, 65);
            this.labelItems.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelItems.Name = "labelItems";
            this.labelItems.Size = new System.Drawing.Size(30, 24);
            this.labelItems.TabIndex = 30;
            this.labelItems.Text = "22";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Firebrick;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.label2.Location = new System.Drawing.Point(481, 324);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "Rp";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Firebrick;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.label3.Location = new System.Drawing.Point(368, 324);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 32;
            this.label3.Text = "Total Bayar :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.Color.Firebrick;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.labelTotal.Location = new System.Drawing.Point(511, 324);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(70, 24);
            this.labelTotal.TabIndex = 33;
            this.labelTotal.Text = "000000";
            // 
            // buttonBeli
            // 
            this.buttonBeli.AutoRoundedCorners = true;
            this.buttonBeli.BackColor = System.Drawing.Color.Transparent;
            this.buttonBeli.BorderColor = System.Drawing.Color.Firebrick;
            this.buttonBeli.BorderRadius = 17;
            this.buttonBeli.BorderThickness = 2;
            this.buttonBeli.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonBeli.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonBeli.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonBeli.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonBeli.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.buttonBeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBeli.ForeColor = System.Drawing.Color.Firebrick;
            this.buttonBeli.Location = new System.Drawing.Point(491, 374);
            this.buttonBeli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBeli.Name = "buttonBeli";
            this.buttonBeli.Size = new System.Drawing.Size(135, 37);
            this.buttonBeli.TabIndex = 36;
            this.buttonBeli.Text = "Purchase";
            this.buttonBeli.Click += new System.EventHandler(this.buttonBeli_Click);
            // 
            // KeranjangShopping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ISA_MiniTrojan.Properties.Resources.backgroundFix;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(655, 431);
            this.Controls.Add(this.buttonBeli);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelItems);
            this.Controls.Add(this.dataGridViewKeranjang);
            this.Controls.Add(this.labelNoInvoice);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "KeranjangShopping";
            this.Text = "KeranjangShopping";
            this.Load += new System.EventHandler(this.KeranjangShopping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKeranjang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNoInvoice;
        private System.Windows.Forms.DataGridView dataGridViewKeranjang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTotal;
        private Guna.UI2.WinForms.Guna2Button buttonBeli;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnPilih;
        private System.Windows.Forms.DataGridViewTextBoxColumn CollumnNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJumlah;
    }
}