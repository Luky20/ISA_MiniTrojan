using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Topup
    {
        private int id;
        private User user;
        private DateTime topup_date;
        private double nominal;
        private string status;
        private string topup_image;
        private User staff;

        public Topup(int id, User user, DateTime topup_date, double nominal, string status, string topup_image,User staff)
        {
            Id = id;
            User = user;
            Topup_date = topup_date;
            Nominal = nominal;
            Status = status;
            Topup_image = topup_image;
            Staff = staff;
        }

        public Topup()
        {
            Id = 0;
            User = new User();
            Topup_date = new DateTime();
            Nominal = 0;
            Status = "";
            Topup_image = "";
            Staff = new User();
        }

        public int Id { get => id; set => id = value; }
        public User User { get => user; set => user = value; }
        public DateTime Topup_date { get => topup_date; set => topup_date = value; }
        public double Nominal { get => nominal; set => nominal = value; }
        public string Status { get => status; set => status = value; }
        public string Topup_image { get => topup_image; set => topup_image = value; }
        public User Staff { get => staff; set => staff = value; }

        private static int GenerateId()
        {
            string sql = "select max(id) from topups";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            if (hasil.Read() == true)
            {
                if (hasil.GetValue(0) == DBNull.Value)
                {
                    return 1;
                }
                return int.Parse(hasil.GetValue(0).ToString()) + 1;
            }
            return 1;
        }

        public static List<Topup> BacaData(string kriteria1 = "", string nilaikriteria1 = "", string kriteria2 = "", string nilaikriteria2 = "")
        {
            string sql = "select * from topups ";
            if(kriteria1 != "")
            {
                sql += " where " + kriteria1 + " llike '%" + nilaikriteria1 + "%'";
                if(kriteria2 != "")
                {
                    sql += " and " + kriteria2 + " like '%" + nilaikriteria2 + "%'";
                }
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<Topup> listHasil = new List<Topup>();
            while (hasil.Read())
            {
                Topup topup = new Topup();
                topup.Id = hasil.GetInt32(0);
                topup.User.Id = hasil.GetInt32(1);
                topup.Topup_date = hasil.GetDateTime(2);
                topup.Nominal = hasil.GetDouble(3);
                topup.Status = hasil.GetString(4);
                topup.Topup_image = hasil.GetString(5);
                if(hasil.GetValue(6) != DBNull.Value)
                {
                    topup.Staff.Id = hasil.GetInt32(6);
                }       
                listHasil.Add(topup);
            }
            foreach(Topup t in listHasil)
            {
                t.User = User.BacaDataUserById(t.User.Id);
            }
            return listHasil;
        }

        public static bool TambahData(Topup topup,Image img)
        {
            topup.Id = GenerateId();
            topup.Topup_image = SimpanGambar(topup, img);
            topup.status = "PENDING";
            string sql = "INSERT INTO topups (id, users_id, topup_date, nominal, status, bukti_transfer) VALUES ('" + topup.Id + "', '" + topup.User.Id + "', now(), '" + topup.Nominal + "', '" + topup.Status + "','" + topup.Topup_image + "')";

            int jumlahDiubah = Koneksi.JalankanPerintahDML(sql);

            if(jumlahDiubah == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool TopUpSukses(Topup topup)
        {
            if(topup.status == "PENDING")
            {
                string sql = "update topups set status = 'SUKSES', staff_id = '" + topup.Staff.Id + "' where id = '" + topup.Id + "'"; 
                int jumlahDiubah = Koneksi.JalankanPerintahDML(sql);
                if (jumlahDiubah == 0)
                {
                    return false;
                }
                else
                {
                    string sql2 = "update users set saldo = '" + AES.Encrypt((topup.User.Saldo + topup.Nominal).ToString(), AES.key) + "' where id = '" + topup.User.Id +"'";
                    Koneksi.JalankanPerintahDML(sql2);
                    return true;
                }                
            }
            throw new Exception("hanya bisa update status topup pending");
        }

        public static bool TopUpGagal(Topup topup)
        {
            if (topup.status == "PENDING")
            {
                string sql = "update topups set status = 'Gagal', staff_id = '" + topup.Staff.Id + "' where id = '" + topup.Id + "'";
                int jumlahDiubah = Koneksi.JalankanPerintahDML(sql);
                if (jumlahDiubah == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            throw new Exception("hanya bisa update status topup pending");
        }

        public static string SimpanGambar(Topup t, Image image)
        {
            Configuration myConf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            ConfigurationSectionGroup userSettings = myConf.SectionGroups["userSettings"];

            var settingSection = userSettings.Sections["ISA_MiniTrojan.DbSettings"] as ClientSettingsSection;
            string path = settingSection.Settings.Get("topup_path").Value.ValueXml.InnerText;

            if (image != null)
            {
                image.Save(path + "\\topup_" + t.Id);
                return "topup_" + t.Id;

            }
            else
            {
                return "";
            }
        }

        public static Image BacaGambar(string cover_image)
        {
            Configuration myConf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            ConfigurationSectionGroup userSettings = myConf.SectionGroups["userSettings"];

            var settingSection = userSettings.Sections["ISA_MiniTrojan.DbSettings"] as ClientSettingsSection;
            string path = settingSection.Settings.Get("topup_path").Value.ValueXml.InnerText;
            try
            {
                Image coverImage = Image.FromFile(path + "\\" + cover_image);
                return coverImage;
            }
            catch
            {
                return null;
            }
        }
    }
}
