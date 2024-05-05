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
    public partial class EditProduk : Form
    {
        Product product;
        public EditProduk(Product p)
        {
            InitializeComponent();
            product = p;
        }

        private void EditProduk_Load(object sender, EventArgs e)
        {
            labelNama.Text = product.Name;
            textBoxHarga.Text = product.Price.ToString();
            textBoxStock.Text = product.Stock.ToString();
            labelDescription.Text = product.Description;
            // pictureBox1.Image = product.BacaGambar;
        }
        

        private void pictureBoxTambah_Click(object sender, EventArgs e)
        {
            try
            {
                product.Name = labelNama.Text;
                product.Price = int.Parse(textBoxHarga.Text);
                product.Stock = int.Parse(textBoxStock.Text);
                product.Description = labelDescription.Text;                

                Product.UbahData(product) ;
                MessageBox.Show("Ubah data Produk berhasil");               
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
