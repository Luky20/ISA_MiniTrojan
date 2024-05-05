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
    public partial class TambahProduk : Form
    {
        public TambahProduk()
        {
            InitializeComponent();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TambahProduk_Load(object sender, EventArgs e)
        {
            
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product();
                p.Name = textBoxNama.Text;
                p.Price = int.Parse(textBoxHarga.Text);
                p.Stock = (int)numericUpDownStock.Value;
                p.Description = textBoxDeskripsi.Text;
                Product.TambahData(p);
                MessageBox.Show("tambah data berhasil");                
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("gagal tambah data. Pesan kesalahan : " + ex.Message, "informasi");
            }
        }
    }
}
