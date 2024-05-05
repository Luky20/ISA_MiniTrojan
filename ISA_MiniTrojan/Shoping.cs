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
    public partial class Shoping : Form
    {
        Dashboard formDashboard;
        List<Product> listOfProducts;
        Product selectedItem;
        public Shoping()
        {
            InitializeComponent();
        }

        private void Shoping_Load(object sender, EventArgs e)
        {
            formDashboard = this.Owner as Dashboard;
            listOfProducts = Product.BacaData();
            comboBoxBarang.DataSource = listOfProducts;
            comboBoxBarang.DisplayMember = "Name";


        }

        private void comboBoxBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItem = comboBoxBarang.SelectedItem as Product;   
            textBoxHarga.Text = selectedItem.Price.ToString();
            labelDeskripsi.Text = selectedItem.Description.ToString();
            labelHargaTotal.Text = (int.Parse(textBoxHarga.Text) * (int)numericUpDownJumlah.Value).ToString();
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            Keranjang k = new Keranjang();
            k.User = formDashboard.user;
            k.Product = selectedItem;
            k.Jumlah = (int)numericUpDownJumlah.Value;

            Keranjang.TambahData(k);
            MessageBox.Show("Product telah berhasil ditambahkan ke keranjang");
        }

        private void numericUpDownJumlah_ValueChanged(object sender, EventArgs e)
        {
            labelHargaTotal.Text = (int.Parse(textBoxHarga.Text) * (int)numericUpDownJumlah.Value).ToString();
        }
    }
}
