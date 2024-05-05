namespace ISA_MiniTrojan
{
    partial class Shoping
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.labelDeskripsi = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelHargaTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.numericUpDownJumlah = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxBarang = new System.Windows.Forms.ComboBox();
            this.textBoxHarga = new System.Windows.Forms.TextBox();
            this.labelCinema = new System.Windows.Forms.Label();
            this.labelJudul = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJumlah)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Location = new System.Drawing.Point(175, 316);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(436, 226);
            this.panel5.TabIndex = 25;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(10)))));
            this.panel9.Controls.Add(this.buttonBuy);
            this.panel9.Controls.Add(this.labelDeskripsi);
            this.panel9.Controls.Add(this.label8);
            this.panel9.Controls.Add(this.labelTotal);
            this.panel9.Controls.Add(this.labelHargaTotal);
            this.panel9.Location = new System.Drawing.Point(5, 5);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(427, 217);
            this.panel9.TabIndex = 10;
            // 
            // buttonBuy
            // 
            this.buttonBuy.BackColor = System.Drawing.Color.Yellow;
            this.buttonBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuy.Location = new System.Drawing.Point(293, 181);
            this.buttonBuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(129, 30);
            this.buttonBuy.TabIndex = 43;
            this.buttonBuy.Text = "BUY";
            this.buttonBuy.UseVisualStyleBackColor = false;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // labelDeskripsi
            // 
            this.labelDeskripsi.AutoSize = true;
            this.labelDeskripsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeskripsi.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDeskripsi.Location = new System.Drawing.Point(11, 42);
            this.labelDeskripsi.Name = "labelDeskripsi";
            this.labelDeskripsi.Size = new System.Drawing.Size(70, 18);
            this.labelDeskripsi.TabIndex = 42;
            this.labelDeskripsi.Text = "Deskripsi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(11, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 18);
            this.label8.TabIndex = 41;
            this.label8.Text = "Deskripsi Barang";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.White;
            this.labelTotal.Location = new System.Drawing.Point(17, 185);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(56, 18);
            this.labelTotal.TabIndex = 34;
            this.labelTotal.Text = "Total :";
            // 
            // labelHargaTotal
            // 
            this.labelHargaTotal.AutoSize = true;
            this.labelHargaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHargaTotal.ForeColor = System.Drawing.Color.White;
            this.labelHargaTotal.Location = new System.Drawing.Point(135, 185);
            this.labelHargaTotal.Name = "labelHargaTotal";
            this.labelHargaTotal.Size = new System.Drawing.Size(63, 18);
            this.labelHargaTotal.TabIndex = 30;
            this.labelHargaTotal.Text = "Rp 00,-";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Location = new System.Drawing.Point(165, 43);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 206);
            this.panel1.TabIndex = 22;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(10)))));
            this.panel6.Controls.Add(this.numericUpDownJumlah);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.comboBoxBarang);
            this.panel6.Controls.Add(this.textBoxHarga);
            this.panel6.Controls.Add(this.labelCinema);
            this.panel6.Controls.Add(this.labelJudul);
            this.panel6.Location = new System.Drawing.Point(5, 5);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(427, 194);
            this.panel6.TabIndex = 9;
            // 
            // numericUpDownJumlah
            // 
            this.numericUpDownJumlah.Location = new System.Drawing.Point(93, 89);
            this.numericUpDownJumlah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownJumlah.Name = "numericUpDownJumlah";
            this.numericUpDownJumlah.Size = new System.Drawing.Size(196, 22);
            this.numericUpDownJumlah.TabIndex = 36;
            this.numericUpDownJumlah.ValueChanged += new System.EventHandler(this.numericUpDownJumlah_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 35;
            this.label1.Text = "Jumlah :";
            // 
            // comboBoxBarang
            // 
            this.comboBoxBarang.FormattingEnabled = true;
            this.comboBoxBarang.Location = new System.Drawing.Point(93, 15);
            this.comboBoxBarang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxBarang.Name = "comboBoxBarang";
            this.comboBoxBarang.Size = new System.Drawing.Size(196, 24);
            this.comboBoxBarang.TabIndex = 34;
            this.comboBoxBarang.SelectedIndexChanged += new System.EventHandler(this.comboBoxBarang_SelectedIndexChanged);
            // 
            // textBoxHarga
            // 
            this.textBoxHarga.Enabled = false;
            this.textBoxHarga.Location = new System.Drawing.Point(93, 52);
            this.textBoxHarga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxHarga.Name = "textBoxHarga";
            this.textBoxHarga.Size = new System.Drawing.Size(196, 22);
            this.textBoxHarga.TabIndex = 33;
            // 
            // labelCinema
            // 
            this.labelCinema.AutoSize = true;
            this.labelCinema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCinema.ForeColor = System.Drawing.Color.White;
            this.labelCinema.Location = new System.Drawing.Point(19, 52);
            this.labelCinema.Name = "labelCinema";
            this.labelCinema.Size = new System.Drawing.Size(63, 18);
            this.labelCinema.TabIndex = 24;
            this.labelCinema.Text = "Harga :";
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.ForeColor = System.Drawing.Color.White;
            this.labelJudul.Location = new System.Drawing.Point(17, 15);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(71, 18);
            this.labelJudul.TabIndex = 0;
            this.labelJudul.Text = "Barang :";
            // 
            // Shoping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.BackgroundImage = global::ISA_MiniTrojan.Properties.Resources.backgroundFix;
            this.ClientSize = new System.Drawing.Size(808, 576);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Shoping";
            this.Text = "Shoping";
            this.Load += new System.EventHandler(this.Shoping_Load);
            this.panel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJumlah)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label labelDeskripsi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelHargaTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label labelCinema;
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.TextBox textBoxHarga;
        private System.Windows.Forms.ComboBox comboBoxBarang;
        private System.Windows.Forms.NumericUpDown numericUpDownJumlah;
        private System.Windows.Forms.Label label1;
    }
}