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
    public partial class DaftarProduct : Form
    {
        List<Product> listHasil;
        public DaftarProduct()
        {
            InitializeComponent();
        }        
        private void dataGridViewInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(listHasil.Count != 0 || listHasil != null)
            {
                Product selectedProduct = listHasil[e.RowIndex];
                if (e.ColumnIndex == dataGridViewProduct.Columns["btnUbah"].Index)
                {
                    EditProduk form = new EditProduk(selectedProduct);
                    form.Owner = this;
                    form.ShowDialog();
                }
                DisplayData();
            }
        }

        private void DaftarProduct_Load(object sender, EventArgs e)
        {          
            listHasil = Product.BacaData();
            DisplayData();
        }

        private void DisplayData()
        {
            dataGridViewProduct.Rows.Clear();
            foreach (Product p in listHasil)
            {
                dataGridViewProduct.Rows.Add(p.Id, p.Name, p.Price, p.Stock);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            TambahProduk form = new TambahProduk();
            form.Owner = this;
            form.ShowDialog();
            DisplayData();
        }
    }
}
