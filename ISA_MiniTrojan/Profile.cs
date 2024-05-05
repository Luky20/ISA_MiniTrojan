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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }
        Dashboard utama;
        private void Profile_Load(object sender, EventArgs e)
        {
            utama = (Dashboard)this.Owner;
            labelUsername.Text = utama.user.Username;
            labelEmail.Text = utama.user.Email;
            labelName.Text = utama.user.Nama;
            labelSaldo.Text = utama.user.Saldo.ToString();

            if (utama.user.Foto_ktp != null)
            {
                labelKtp.Text = "Terverifikasi";
            }
            else
            {
                labelKtp.Text = "Belum Terverifikasi";
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            GantiPassword form = new GantiPassword();
            form.Owner = this;
            form.ShowDialog();
        }
    }
}
