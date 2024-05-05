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
    public partial class DaftarTopUp : Form
    {
        Dashboard dashboard;
        List<ClassLibrary.Topup> listTopup;
        public DaftarTopUp()
        {
            InitializeComponent();
        }

        private void TopUp_Load(object sender, EventArgs e)
        {
            dashboard = this.Owner as Dashboard;
            listTopup = Topup.BacaData();   
            DisplayData();
        }

        private void dataGridViewTopUp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Topup selectedTopup = listTopup[e.RowIndex];
            if (e.ColumnIndex == dataGridViewTopUp.Columns["btnDetail"].Index)
            {
                DetailTopUp detailTopUp = new DetailTopUp(selectedTopup);
                detailTopUp.Owner = this;
                detailTopUp.ShowDialog();
                DisplayData();
            }            
        }

        private void DisplayData()
        {
            dataGridViewTopUp.Rows.Clear();
            foreach (ClassLibrary.Topup tp in listTopup)
            {
                dataGridViewTopUp.Rows.Add(tp.Id, tp.User.Id, tp.Topup_date.ToString("yyyy-MM-dd HH:mm:ss"), tp.Nominal, tp.Status, tp.Staff.Id);
            }
        }
    }
}
