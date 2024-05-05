namespace ISA_MiniTrojan
{
    partial class CekKTP
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
            this.buttonDecode = new System.Windows.Forms.Button();
            this.textBoxHasilDecode = new System.Windows.Forms.TextBox();
            this.labelNoKTP = new System.Windows.Forms.Label();
            this.pictureBoxKtp = new System.Windows.Forms.PictureBox();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKtp)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDecode
            // 
            this.buttonDecode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.buttonDecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold);
            this.buttonDecode.ForeColor = System.Drawing.Color.Firebrick;
            this.buttonDecode.Location = new System.Drawing.Point(314, 442);
            this.buttonDecode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(157, 38);
            this.buttonDecode.TabIndex = 57;
            this.buttonDecode.Text = "Decode";
            this.buttonDecode.UseVisualStyleBackColor = false;
            this.buttonDecode.Click += new System.EventHandler(this.buttonDecode_Click);
            // 
            // textBoxHasilDecode
            // 
            this.textBoxHasilDecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHasilDecode.Location = new System.Drawing.Point(173, 494);
            this.textBoxHasilDecode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxHasilDecode.Name = "textBoxHasilDecode";
            this.textBoxHasilDecode.Size = new System.Drawing.Size(476, 29);
            this.textBoxHasilDecode.TabIndex = 55;
            // 
            // labelNoKTP
            // 
            this.labelNoKTP.AutoSize = true;
            this.labelNoKTP.BackColor = System.Drawing.Color.Transparent;
            this.labelNoKTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoKTP.ForeColor = System.Drawing.Color.White;
            this.labelNoKTP.Location = new System.Drawing.Point(13, 494);
            this.labelNoKTP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNoKTP.Name = "labelNoKTP";
            this.labelNoKTP.Size = new System.Drawing.Size(153, 25);
            this.labelNoKTP.TabIndex = 54;
            this.labelNoKTP.Text = "Hasil Decode :";
            // 
            // pictureBoxKtp
            // 
            this.pictureBoxKtp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxKtp.Location = new System.Drawing.Point(84, 88);
            this.pictureBoxKtp.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBoxKtp.Name = "pictureBoxKtp";
            this.pictureBoxKtp.Size = new System.Drawing.Size(635, 345);
            this.pictureBoxKtp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxKtp.TabIndex = 53;
            this.pictureBoxKtp.TabStop = false;
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(169, 57);
            this.comboBoxUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(480, 24);
            this.comboBoxUser.TabIndex = 58;
            this.comboBoxUser.SelectedIndexChanged += new System.EventHandler(this.comboBoxUser_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 59;
            this.label1.Text = "Pilih User :";
            // 
            // CekKTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ISA_MiniTrojan.Properties.Resources.backgroundFix;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 556);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxUser);
            this.Controls.Add(this.buttonDecode);
            this.Controls.Add(this.textBoxHasilDecode);
            this.Controls.Add(this.labelNoKTP);
            this.Controls.Add(this.pictureBoxKtp);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CekKTP";
            this.Text = "CekKTP";
            this.Load += new System.EventHandler(this.CekKTP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKtp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.TextBox textBoxHasilDecode;
        private System.Windows.Forms.Label labelNoKTP;
        private System.Windows.Forms.PictureBox pictureBoxKtp;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.Label label1;
    }
}