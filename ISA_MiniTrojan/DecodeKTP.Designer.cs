namespace ISA_MiniTrojan
{
    partial class DecodeKTP
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
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.textBoxNoKTP = new System.Windows.Forms.TextBox();
            this.labelNoKTP = new System.Windows.Forms.Label();
            this.pictureBoxKtp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKtp)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Location = new System.Drawing.Point(338, 338);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(312, 22);
            this.textBoxFilePath.TabIndex = 59;
            // 
            // buttonDecode
            // 
            this.buttonDecode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.buttonDecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold);
            this.buttonDecode.ForeColor = System.Drawing.Color.Firebrick;
            this.buttonDecode.Location = new System.Drawing.Point(322, 487);
            this.buttonDecode.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(157, 38);
            this.buttonDecode.TabIndex = 58;
            this.buttonDecode.Text = "Decode";
            this.buttonDecode.UseVisualStyleBackColor = false;
            this.buttonDecode.Click += new System.EventHandler(this.buttonDecode_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.buttonOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold);
            this.buttonOpenFile.ForeColor = System.Drawing.Color.Firebrick;
            this.buttonOpenFile.Location = new System.Drawing.Point(174, 327);
            this.buttonOpenFile.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(157, 38);
            this.buttonOpenFile.TabIndex = 56;
            this.buttonOpenFile.Text = "Open File";
            this.buttonOpenFile.UseVisualStyleBackColor = false;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // textBoxNoKTP
            // 
            this.textBoxNoKTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNoKTP.Location = new System.Drawing.Point(243, 416);
            this.textBoxNoKTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNoKTP.Name = "textBoxNoKTP";
            this.textBoxNoKTP.Size = new System.Drawing.Size(432, 29);
            this.textBoxNoKTP.TabIndex = 55;
            // 
            // labelNoKTP
            // 
            this.labelNoKTP.AutoSize = true;
            this.labelNoKTP.BackColor = System.Drawing.Color.Transparent;
            this.labelNoKTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoKTP.ForeColor = System.Drawing.Color.White;
            this.labelNoKTP.Location = new System.Drawing.Point(126, 418);
            this.labelNoKTP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNoKTP.Name = "labelNoKTP";
            this.labelNoKTP.Size = new System.Drawing.Size(107, 25);
            this.labelNoKTP.TabIndex = 54;
            this.labelNoKTP.Text = "No. KTP :";
            // 
            // pictureBoxKtp
            // 
            this.pictureBoxKtp.Location = new System.Drawing.Point(174, 13);
            this.pictureBoxKtp.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxKtp.Name = "pictureBoxKtp";
            this.pictureBoxKtp.Size = new System.Drawing.Size(476, 286);
            this.pictureBoxKtp.TabIndex = 53;
            this.pictureBoxKtp.TabStop = false;
            // 
            // DecodeKTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ISA_MiniTrojan.Properties.Resources.backgroundFix;
            this.ClientSize = new System.Drawing.Size(800, 587);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.buttonDecode);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.textBoxNoKTP);
            this.Controls.Add(this.labelNoKTP);
            this.Controls.Add(this.pictureBoxKtp);
            this.Name = "DecodeKTP";
            this.Text = "DecodeKTP";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKtp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.TextBox textBoxNoKTP;
        private System.Windows.Forms.Label labelNoKTP;
        private System.Windows.Forms.PictureBox pictureBoxKtp;
    }
}