using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISA_MiniTrojan
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        private void buttonUploadKTP_Click(object sender, EventArgs e)
        {
            //UploadKTP uploadKTP = new UploadKTP();
            //uploadKTP.Owner = this;
            //uploadKTP.ShowDialog();
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                User u = new User();
                u.Email = textBoxEmail.Text;
                u.Username = textBoxUsername.Text;
                u.Nama = textBoxNama.Text;
                u.Password = textBoxPassword.Text;
                u.Role = "KONSUMEN";

                //u.ImgKtp = upload ktp

                User.Register(u, pictureBox1.ImageLocation, textBoxNoKTP.Text);
                MessageBox.Show("Register Berhasil");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
