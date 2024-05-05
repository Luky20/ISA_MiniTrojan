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
    public partial class Invoice : Form
    {        
        private User user;
        public List<Transaksi> listTransaksi;
        public Invoice(User u)
        {
            InitializeComponent();
            user = u;
        }
        private void Invoice_Load(object sender, EventArgs e)
        {
            if (user.Role=="KONSUMEN")
            {
                listTransaksi = Transaksi.BacaData("u.id", user.Id.ToString());
            }
            else
            {
                listTransaksi = Transaksi.BacaData();
            }
            DisplayData();
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            if(textBoxId.Text != "")
            {
                DisplayDataFilter(textBoxId.Text);
            }
            else
            {
                DisplayData();
            }
        }

        private void dataGridViewInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (listTransaksi.Count != 0 || listTransaksi != null)
            {
                Transaksi selectedTransaksi = listTransaksi[e.RowIndex];
                if (e.ColumnIndex == dataGridViewInvoice.Columns["btnDetail"].Index)
                {
                    DetailTransaksi form = new DetailTransaksi(selectedTransaksi);
                    form.Owner = this;                    
                    form.ShowDialog();                
                }
            }
        }

        private void DisplayData()
        {
            dataGridViewInvoice.Rows.Clear();
            foreach (Transaksi t in listTransaksi)
            {
                dataGridViewInvoice.Rows.Add(t.Id, t.Date, t.Total);
            }
        }

        private void DisplayDataFilter(string filterIdTransaksi)
        {
            dataGridViewInvoice.Rows.Clear();
            foreach (Transaksi t in listTransaksi)
            {
                if (t.Id.ToString().Contains(filterIdTransaksi))
                {
                    dataGridViewInvoice.Rows.Add(t.Id, t.Date.ToString("yyyy-MM-dd HH:mm:ss"), t.Total);
                }
            }
        }
    }
}
