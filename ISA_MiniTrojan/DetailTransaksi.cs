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
    public partial class DetailTransaksi : Form
    {
        private Transaksi transaksi;
        public DetailTransaksi(Transaksi t)
        {
            InitializeComponent();
            transaksi = t;
        }        
        
        private void DetailTransaksi_Load(object sender, EventArgs e)
        { 
            dataGridViewInvoice.Rows.Clear();
            labelNama.Text = transaksi.User.Nama;
            labelId.Text = transaksi.Id.ToString();
            labelTanggal.Text = transaksi.Date.ToString("yyyy-MMMM-dd HH:mm:ss");
            labelNominal.Text = transaksi.Total.ToString();

            foreach (ClassLibrary.DetailTransaksi dt in transaksi.DetailTransaksiList)
            {
                dataGridViewInvoice.Rows.Add(dt.Product.Name, dt.Quantity, dt.Harga);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            Laporan.PrintLaporan1(transaksi.Id);
        }
    }
}
