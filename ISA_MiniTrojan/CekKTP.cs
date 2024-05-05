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
    public partial class CekKTP : Form
    {
        public CekKTP()
        {
            InitializeComponent();
        }
        List<User> listOfUsers;
        private void comboBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxUser.SelectedIndex != -1)
            {
                User selectedUser = (User)(comboBoxUser.SelectedItem);
                pictureBoxKtp.Image = User.BacaGambar(selectedUser.Foto_ktp);
                
            }
        }

        private void buttonDecode_Click(object sender, EventArgs e)
        {
            textBoxHasilDecode.Text = User.Decode(pictureBoxKtp.Image);
        }

        private void CekKTP_Load(object sender, EventArgs e)
        {
            listOfUsers = User.BacaDataUser();
            comboBoxUser.DataSource = listOfUsers;
            comboBoxUser.DisplayMember = "nama";
        }
    }
}
