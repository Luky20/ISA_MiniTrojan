using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISA_MiniTrojan
{
    public partial class KeranjangShopping : Form
    {
        public KeranjangShopping()
        {
            InitializeComponent();
        }
        Dashboard utama;
        List<Keranjang> listKeranjang;
        double total = 0;
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void KeranjangShopping_Load(object sender, EventArgs e)
        {
            utama = (Dashboard)this.Owner;
            listKeranjang = Keranjang.BacaData("u.id", utama.user.Id.ToString());
 
            DisplayData();
            labelItems.Text = listKeranjang.Count.ToString();

        }

        private void DisplayData()
        {
            dataGridViewKeranjang.Rows.Clear();
            foreach (Keranjang k in listKeranjang)
            {
                dataGridViewKeranjang.Rows.Add(false, k.Product.Name, k.Product.Price, k.Jumlah);
            }
        }

        private void dataGridViewKeranjang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewKeranjang.Columns["ColumnPilih"].Index)
            {
                total = 0;
                for (int i = 0; i < dataGridViewKeranjang.Rows.Count - 1; i++)
                {
                    if (dataGridViewKeranjang[0, i].Value.ToString() == "true")
                    {
                        total += listKeranjang[i].Product.Price * listKeranjang[i].Jumlah;
                    }
                }
                labelTotal.Text = total.ToString();
            }            
        }

        private void buttonBeli_Click(object sender, EventArgs e)
        {
                Transaksi tampung = new Transaksi();
                tampung.User = utama.user;
                for (int i = 0; i < dataGridViewKeranjang.Rows.Count - 1; i++)
                {
                    if (dataGridViewKeranjang[0, i].Value.ToString() == "true")
                    {
                        ClassLibrary.DetailTransaksi tampungDetail = new ClassLibrary.DetailTransaksi();
                        tampungDetail.Product = listKeranjang[i].Product;
                        tampungDetail.Quantity = listKeranjang[i].Jumlah;
                        tampungDetail.Harga = listKeranjang[i].Product.Price;
                        tampungDetail.Transactions = tampung;
                        tampung.Total += listKeranjang[i].Product.Price * listKeranjang[i].Jumlah;
                        tampung.DetailTransaksiList.Add(tampungDetail);
                    }
                }
                Transaksi.TambahData(tampung);
                MessageBox.Show("Produk berhasil dibeli");

                KeranjangShopping_Load(this, e);
        
            //try{
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
