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
    public partial class Dashboard : Form
    {
        public User user;
        Form activeForm;
        public Dashboard(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            switch (user.Role)
            {
                case "ADMIN":
                    btnProduk.Visible = false;
                    btnKeranjang.Visible = false;
                    btnInvoice.Visible = false;                    
                    btnTopUp.Visible = false;

                    buttonDaftarKonsumen.Visible = true;
                    buttonDaftarInvoice.Visible = true;
                    buttonDaftarProduk.Visible = true;                    
                    buttonCekSteganography.Visible = true;
                    buttonDaftarStaff.Visible = true;     
                    buttonDaftarTopup.Visible = true;
                    break;
                case "STAFF":
                    btnProduk.Visible = false;
                    btnKeranjang.Visible = false;
                    btnInvoice.Visible = false;                    
                    btnTopUp.Visible = false;

                    buttonDaftarKonsumen.Visible = true;
                    buttonDaftarInvoice.Visible = true;
                    buttonDaftarProduk.Visible = true;
                    buttonCekSteganography.Visible = true;
                    buttonDaftarStaff.Visible = false;
                    buttonDaftarTopup.Visible = true;
                    break;
                case "KONSUMEN":
                    btnProduk.Visible = true;
                    btnKeranjang.Visible = true;
                    btnInvoice.Visible = true;                   
                    btnTopUp.Visible = true;

                    buttonDaftarKonsumen.Visible = false;
                    buttonDaftarInvoice.Visible = false;
                    buttonDaftarProduk.Visible = false;                    
                    buttonCekSteganography.Visible = false;
                    buttonDaftarStaff.Visible = false;
                    buttonDaftarTopup.Visible = false;
                    break;
            }
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            KeranjangShopping form = new KeranjangShopping();
            form.Owner = this;
            OpenForm(form);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            (this.Owner as Login).Show();
            this.Dispose();
        }

        private void OpenForm(Form form)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            Form form1 = Application.OpenForms[form.DataBindings.ToString()];
            if (form1 == null)
            {                
                activeForm = form;
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                this.panelForm.Controls.Add(form);
                this.panelForm.Tag = form;
                form.Show();
                form.BringToFront();

            }
            else
            {
                activeForm = form;
                form.Show();
                form.BringToFront();
            }

        }

        private void btnProduk_Click(object sender, EventArgs e)
        {
            Shoping form = new Shoping();
            form.Owner = this;
            OpenForm(form);

        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            buttonLogout_Click(sender, e);
        }

        private void buttonDaftarKonsumen_Click(object sender, EventArgs e)
        {
            DaftarUser form = new DaftarUser();
            form.Owner = this;
            OpenForm(form);            
        }

        private void buttonDaftarProduk_Click(object sender, EventArgs e)
        {
            DaftarProduct form = new DaftarProduct();
            form.Owner = this;
            OpenForm(form);
        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            Profile form = new Profile();
            form.Owner = this;
            form.ShowDialog();
        }
        private void buttonDaftarStaff_Click(object sender, EventArgs e)
        {
            DaftarStaff form = new DaftarStaff();
            form.Owner = this;
            OpenForm(form);
        }

        private void buttonDaftarStaff_Click_1(object sender, EventArgs e)
        {
            DaftarStaff form = new DaftarStaff();
            form.Owner = this;
            OpenForm(form);
        }

        private void buttonCekSteganography_Click(object sender, EventArgs e)
        {
            CekKTP form = new CekKTP();
            form.Owner = this;
            OpenForm(form);
        }

        private void btnTopUp_Click(object sender, EventArgs e)
        {
            TopUp form = new TopUp();
            form.Owner = this;
            OpenForm(form);
        }

        private void buttonDaftarTopup_Click(object sender, EventArgs e)
        {
            DaftarTopUp form = new DaftarTopUp();
            form.Owner = this;
            OpenForm(form);
        }

        private void buttonDaftarInvoice_Click(object sender, EventArgs e)
        {
            Invoice form = new Invoice(user);
            form.Owner = this;
            OpenForm(form);
        }

        private void btnInvoice_Click_1(object sender, EventArgs e)
        {
            Invoice form = new Invoice(user);
            form.Owner = this;
            OpenForm(form);
        }
    }
}
