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
    public partial class TambahStaff : Form
    {
        public TambahStaff()
        {
            InitializeComponent();
        }

        private void panelDepan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TambahStaff_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                User staff = new User();
                staff.Email = textBoxEmail.Text;
                staff.Username = textBoxUsername.Text;
                staff.Password = textBoxPassword.Text;
                staff.Nama = textBoxNama.Text;
                staff.Role = "Staff";

                User.Register(staff,"","");
                MessageBox.Show("tambah data berhasil");
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
