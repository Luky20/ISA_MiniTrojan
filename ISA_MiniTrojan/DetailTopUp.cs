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
    public partial class DetailTopUp : Form
    {
        Topup topup;
        Dashboard dashboard;
        public DetailTopUp(Topup t)
        {
            InitializeComponent();
            topup = t;       
            if(t.Status != "PENDING")
            {
                buttonSukses.Enabled = false;
                buttonGagal.Enabled = false;
            }
        }

        private void DetailTopUp_Load(object sender, EventArgs e)
        {
            dashboard = (Dashboard)this.Owner.Owner;
            textBoxId.Text = topup.Id.ToString();
            textBoxUserId.Text = topup.User.Id.ToString();
            textBoxTopupDate.Text = topup.Topup_date.ToString("yyyy-MM-dd HH:mm:ss");
            textBoxNominal.Text = topup.Nominal.ToString();
            textBoxStatus.Text = topup.Status;

            pictureBoxBuktiTransfer.Image = Topup.BacaGambar(topup.Topup_image);
        }

        private void buttonSukses_Click(object sender, EventArgs e)
        {
            try
            {
                topup.Staff = dashboard.user;
                Topup.TopUpSukses(topup);
                MessageBox.Show("Topup berhasil");
                this.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void buttonGagal_Click(object sender, EventArgs e)
        {
            try
            {
                topup.Staff = dashboard.user;
                Topup.TopUpGagal(topup);
                MessageBox.Show("Topup gagal");
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
