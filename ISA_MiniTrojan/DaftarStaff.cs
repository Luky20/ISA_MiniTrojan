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
    public partial class DaftarStaff : Form
    {
        Dashboard utama;
        List<User> listHasil;
        public DaftarStaff()
        {
            InitializeComponent();
        }

        private void DaftarStaff_Load(object sender, EventArgs e)
        {
            listHasil = User.BacaDataStaff();
            DisplayData();
            if (dataGridViewUser.ColumnCount == 6)
            {
                DataGridViewButtonColumn bcol1 = new DataGridViewButtonColumn();
                bcol1.HeaderText = "Aksi";
                bcol1.Text = "DELETE";
                bcol1.Name = "btnDeleteGrid";
                bcol1.UseColumnTextForButtonValue = true;
                dataGridViewUser.Columns.Add(bcol1);

                DataGridViewButtonColumn bcol2 = new DataGridViewButtonColumn();
                bcol2.HeaderText = "Aksi";
                bcol2.Text = "AKTIVASI";
                bcol2.Name = "btnAktivasi";
                bcol2.UseColumnTextForButtonValue = true;
                dataGridViewUser.Columns.Add(bcol2);
            }
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
            if (e.ColumnIndex == dataGridViewUser.Columns["btnDeleteGrid"].Index && e.RowIndex >= 0)
            {
                string kodeHapus = listHasil[e.RowIndex].Id.ToString();

                DialogResult hasil = MessageBox.Show(this, "anda yakin ingin menghapus konsumen id - " + kodeHapus + "?",
                    "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hasil == DialogResult.Yes)
                {
                    Boolean hapus = User.HapusData(listHasil[e.RowIndex]);
                    if (hapus == true)
                    {
                        MessageBox.Show("penghapusan data berhasil");
                        DaftarStaff_Load(dataGridViewUser, e);
                    }
                    else
                    {
                        MessageBox.Show("penghapusan data gagal");
                    }
                }
            }
            else if (e.ColumnIndex == dataGridViewUser.Columns["btnAktivasi"].Index)
            {
                DialogResult hasil = MessageBox.Show("Yakin mengaktifkan akun " + listHasil[e.RowIndex].Id.ToString() + " ?", "AKFITKAN", MessageBoxButtons.YesNo);
                if (hasil == DialogResult.Yes)
                {
                    if (User.AktivasiUser(listHasil[e.RowIndex]))
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
            else
            {
                MessageBox.Show("Data tidak ditemukan");
            }
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            TambahStaff form = new TambahStaff();
            form.Owner = this;
            form.ShowDialog();
        }
    }
}
