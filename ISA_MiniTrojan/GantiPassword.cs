using ISA_MiniTrojan.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
namespace ISA_MiniTrojan
{
    public partial class GantiPassword : Form
    {
        public GantiPassword()
        {
            InitializeComponent();
        }
        Dashboard form;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGanti_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBoxPasswordBaru.Text == textBoxConfirmPasswordBaru.Text)
                {
                    User.GantiPassword(form.user, textBoxPasswordLama.Text, textBoxPasswordBaru.Text);
                    MessageBox.Show("Ganti Password Berhasil");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cek kembali password anda");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonViewPassword_Click(object sender, EventArgs e)
        {
            if (textBoxPasswordBaru.UseSystemPasswordChar == false)
            {
                textBoxPasswordLama.UseSystemPasswordChar = true;
                textBoxPasswordBaru.UseSystemPasswordChar = true;
                textBoxConfirmPasswordBaru.UseSystemPasswordChar = true;
                buttonViewPassword.BackgroundImage = Resources._1;
            }
            else
            {
                textBoxPasswordLama.UseSystemPasswordChar = false;
                textBoxPasswordBaru.UseSystemPasswordChar = false;
                textBoxConfirmPasswordBaru.UseSystemPasswordChar = false;
                buttonViewPassword.BackgroundImage = Resources._2;
            }
        }

        private void GantiPassword_Load(object sender, EventArgs e)
        {
            form = (Dashboard)this.Owner.Owner;
        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
