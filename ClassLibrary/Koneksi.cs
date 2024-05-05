using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;


namespace ClassLibrary
{
    public class Koneksi
    {
        private MySqlConnection koneksiDB;

        public Koneksi()
        {
            Configuration myConf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConfigurationSectionGroup userSetting = myConf.SectionGroups["userSettings"];

            var settingSection = userSetting.Sections["ISA_MiniTrojan.DbSettings"] as ClientSettingsSection;

            string DbServer = settingSection.Settings.Get("DbServer").Value.ValueXml.InnerText;
            string DbName = settingSection.Settings.Get("DbName").Value.ValueXml.InnerText;
            string DbUsername = settingSection.Settings.Get("DbUsername").Value.ValueXml.InnerText;
            string DbPassword = settingSection.Settings.Get("DbPassword").Value.ValueXml.InnerText;

            string strCon = "Server =" + DbServer + ";Database=" + DbName + ";Uid=" + DbUsername + ";Pwd=" + DbPassword;

            koneksiDB = new MySqlConnection
            {
                ConnectionString = strCon
            };

            this.Connect();
        }
        ~Koneksi()
        {
            KoneksiDB.Close();
        }
        public MySqlConnection KoneksiDB { get => koneksiDB; set => koneksiDB = value; }

        public void Connect()
        {
            if(KoneksiDB.State == System.Data.ConnectionState.Open)
            {
                KoneksiDB.Close();
            }
            KoneksiDB.Open();
        }
        public static MySqlDataReader JalankanPerintahQuery(string sql)
        {
            Koneksi k = new Koneksi();

            MySqlCommand c = new MySqlCommand(sql, k.KoneksiDB);

            MySqlDataReader hasil = c.ExecuteReader();
            return hasil;
        }

        public static MySqlDataReader JalankanPerintahQuery(string sql, Koneksi k)
        {
            MySqlCommand c = new MySqlCommand(sql, k.KoneksiDB);
            MySqlDataReader hasil = c.ExecuteReader();
            return hasil;
        }

        public static int JalankanPerintahDML(string sql)
        {
            Koneksi k = new Koneksi();

            MySqlCommand c = new MySqlCommand(sql, k.KoneksiDB);

            int rowAffected = c.ExecuteNonQuery();

            k.KoneksiDB.Close();

            return rowAffected;
        }

        public static int JalankanPerintahDML(string sql, Koneksi k)
        {
            MySqlCommand c = new MySqlCommand(sql, k.KoneksiDB);

            return c.ExecuteNonQuery();
        }
    }
}
