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
    public partial class DaftarUser : Form
    {
        Dashboard utama;
        List<User> listHasil;
        public DaftarUser()
        {
            InitializeComponent();
            utama = (Dashboard)this.Owner;
        }
        private void DaftarUser_Load(object sender, EventArgs e)
        {
            listHasil = User.BacaDataUser();
            DisplayData();

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            if (textBoxUsername.Text != "")
            {
                listHasil = User.BacaDataUser("username", textBoxUsername.Text);
            }
            else
            {
                listHasil = User.BacaDataUser("username", textBoxUsername.Text);
            }
            DisplayData();
        }

        private void DisplayData()
        {
            dataGridViewUser.Rows.Clear();
            foreach (User u in listHasil)
            {
                dataGridViewUser.Rows.Add(u.Id, u.Username, u.Email, u.Nama, u.Saldo, u.Sisa_percobaan_login);
            }
        }

        private void dataGridViewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            User selectedUser = listHasil[e.RowIndex];           
            if (e.ColumnIndex == dataGridViewUser.Columns["btnAktivasi"].Index)
            {
                DialogResult hasil = MessageBox.Show("Yakin mengaktifkan akun " + selectedUser.Id + " ?", "AKFITKAN", MessageBoxButtons.YesNo);
                if (hasil == DialogResult.Yes)
                {
                    if (User.AktivasiUser(selectedUser))
                    {
                        MessageBox.Show("aktivasi berhasil");
                    }
                    else
                    {
                        MessageBox.Show("aktivasi gagal");
                    }
                    DisplayData();
                }
            }
            else if (e.ColumnIndex == dataGridViewUser.Columns["btnTransaksi"].Index)
            {
                Invoice form = new Invoice(selectedUser);
                form.Owner = this;                
                form.ShowDialog();
                DisplayData();
            }
        }

    }
}
