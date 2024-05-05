using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISA_MiniTrojan
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static User u;
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if(buttonLogin.Text == "Lanjut")
                {
                    if (User.CekUsername(textBoxUser.Text))
                    {
                        labelPassword.Visible = true;
                        textBoxPassword.Visible = true;
                        buttonBack.Visible = true;
                        textBoxUser.Enabled = false;
                        textBoxPassword.Focus();
                        buttonLogin.Text = "Login";
                    }                    
                }
                else
                {
                    u = User.UserLogin(textBoxUser.Text, textBoxPassword.Text);
                    MessageBox.Show("Login Berhasil");
                    textBoxUser.Clear();
                    textBoxPassword.Clear();
                    buttonBack_Click(sender, e);
                    Dashboard formDashboard = new Dashboard(u);
                    formDashboard.Owner = this;
                    formDashboard.Show();
                    this.Hide();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            labelPassword.Visible = false;
            textBoxPassword.Visible = false;
            buttonBack.Visible = false;
            textBoxUser.Enabled = true;

            buttonLogin.Text = "Lanjut";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            labelPassword.Visible = false;
            textBoxPassword.Visible = false;
            buttonBack.Visible = false;
            textBoxUser.Enabled = true;
            textBoxPassword.Clear();

            buttonLogin.Text = "Lanjut";

        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register fr = new Register();
            fr.ShowDialog();
        }
    }
}
