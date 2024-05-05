using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Transactions;
using System.Configuration;


namespace ClassLibrary
{
    public class User
    {
        public int id;
        public string email;
        public string username;
        public string password;
        public string nama;
        public string saldo;
        public string role;
        private string foto_ktp;
        public int sisa_percobaan_login;

        public User()
        {
            Id = 0;
            Email = "";
            Username = "";
            Password = "";
            Nama = "";
            Saldo = 0;
            Role = "";
            Foto_ktp = "";
            Sisa_percobaan_login = 3;
        }

        public User(int id, string email, string username, string password, string nama, double saldo, string role, int sisa_percobaan_login, List<Transaksi> listOfTransaction)
        {
            Id = id;
            Email = email;
            Username = username;
            Password = password;
            Nama = nama;
            Saldo = saldo;
            Role = role;
            Sisa_percobaan_login = sisa_percobaan_login;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }
        public string Email
        {
            get => AES.Decrypt(email, AES.key);
            set => email = AES.Encrypt(value, AES.key);
        }
        public string Username
        {
            get => AES.Decrypt(username, AES.key);
            set => username = AES.Encrypt(value, AES.key);
        }
        public string Password
        {
            get => password;
            set => password = SHA.ComputeHash(value);
        }
        public string Nama
        {
            get => AES.Decrypt(nama, AES.key);
            set => nama = AES.Encrypt(value, AES.key);
        }
        public double Saldo
        {
            get => double.Parse(AES.Decrypt(saldo, AES.key));
            set => saldo = AES.Encrypt(value.ToString(), AES.key);
        }
        public string Role
        {
            get => role;
            set => role = value;
        }
        public int Sisa_percobaan_login
        {
            get => sisa_percobaan_login;
            set => sisa_percobaan_login = value;
        }
        public string Foto_ktp
        {
            get => foto_ktp;
            set => foto_ktp = value;
        }

        public static bool CekUsername(string username)
        {
            string sql = "select username, sisa_percobaan_login from users where username =  '" + AES.Encrypt(username, AES.key) + "'";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            if (hasil.Read() == true)
            {
                if (hasil.GetInt16(1) == 0)
                {
                    throw new Exception("Akun tidak aktif");
                }
                else
                {
                    return true;
                }
            }
            else
            {
                throw new Exception("Username tidak ditemukan");
            }
        }
        public static User UserLogin(string username, string password)
        {
            string sql = "select * from users where username = '" + AES.Encrypt(username, AES.key) + "'";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            if (hasil.Read())
            {
                User u = new User();
                u.id = hasil.GetInt32(0);
                u.email = hasil.GetString(1);
                u.username = hasil.GetString(2);
                u.password = hasil.GetString(3);
                u.nama = hasil.GetString(4);
                u.saldo = hasil.GetString(5);
                u.Role = hasil.GetString(6);
                u.Sisa_percobaan_login = hasil.GetInt32(7);

                if (u.Sisa_percobaan_login == 0)
                {
                    throw new Exception("akun tidak aktif");
                }
                else if (u.Password == SHA.ComputeHash(password))
                {
                    string sql3 = "update users set sisa_percobaan_login = '3' where username = '" + AES.Encrypt(username, AES.key) + "'";
                    Koneksi.JalankanPerintahDML(sql3);
                    return u;
                }
                else
                {
                    string sql3 = "update users set sisa_percobaan_login = sisa_percobaan_login - 1 where username = '" + AES.Encrypt(username, AES.key) + "'";
                    Koneksi.JalankanPerintahDML(sql3);
                    throw new Exception("Password salah");
                }

            }
            throw new Exception("Username tidak ditemukan");

        }
        private static int GenerateIdUser()
        {
            string sql = "select max(id) from users";
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
        public static bool Register(User u, string photo_id_path, string noKtp)
        {
            u.Id = GenerateIdUser();     
            if(u.Role == "KONSUMEN")
            {
                u.Foto_ktp = SimpanGambar(u, photo_id_path, noKtp);
            }
            else
            {
                u.Foto_ktp = "";
            }
            string sql = "insert into users(id, email, username, password, nama, saldo, role, sisa_percobaan_login, photo_id_path) " +
                         "values ('" + u.id + "','" + u.email + "', '" + u.username + "','" + u.password +
                         "','" + u.nama + "','" + u.saldo + "','" + u.role + "','" + u.Sisa_percobaan_login  + "','"+ u.Foto_ktp +"')"; 
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
        public static User BacaDataUserById(int id)
        {
            string sql = "select * from users where role = 'KONSUMEN' and id = '" + id +"'";


            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            User u = new User();
            if (hasil.Read() == true)
            {             
                u.Id = int.Parse(hasil.GetValue(0).ToString());
                u.email = hasil.GetValue(1).ToString();
                u.username = hasil.GetValue(2).ToString();
                u.nama = hasil.GetValue(4).ToString();
                u.saldo = hasil.GetString(5);
                u.role = hasil.GetValue(6).ToString();
                u.Sisa_percobaan_login = hasil.GetInt16(7);
                u.Foto_ktp = hasil.GetValue(8).ToString();
                
            }
            return u;
        }

        public static List<User> BacaDataUser(string filter = "", string nilai = "")
        {
            string sql = "select * from users where role = 'KONSUMEN'";
            if (filter != "")
            {
                sql += " AND " + filter + " = '" + AES.Encrypt(nilai, AES.key) + "'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<User> listUser = new List<User>();
            while (hasil.Read() == true)
            {
                User user = new User();
                user.Id = int.Parse(hasil.GetValue(0).ToString());
                user.email = hasil.GetValue(1).ToString();
                user.username = hasil.GetValue(2).ToString();
                user.nama = hasil.GetValue(4).ToString();
                user.saldo = hasil.GetString(5);
                user.role = hasil.GetValue(6).ToString();
                user.Sisa_percobaan_login = hasil.GetInt16(7);
                user.Foto_ktp = hasil.GetValue(8).ToString();
                

                listUser.Add(user);
            }
            return listUser;
        }

        public static bool AktivasiUser(User user)
        {
            string sql = "update users set sisa_percobaan_login = 3 where id = '" + user.Id + "'";
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

        public static string SimpanGambar(User u, string filepath, string noKtp)
        {
            Configuration myConf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            ConfigurationSectionGroup userSetting = myConf.SectionGroups["userSettings"];

            var settingSection = userSetting.Sections["ISA_MiniTrojan.DbSettings"] as ClientSettingsSection;
            string path = settingSection.Settings.Get("photo_id_path").Value.ValueXml.InnerText;

            Bitmap img = new Bitmap(filepath);

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixel = img.GetPixel(i, j);

                    if (i < 1 && j < noKtp.Length)
                    {
                        Console.WriteLine("R = [" + i + "][" + j + "] = " + pixel.R);
                        Console.WriteLine("G = [" + i + "][" + j + "] = " + pixel.G);
                        Console.WriteLine("B = [" + i + "][" + j + "] = " + pixel.B);

                        char letter = Convert.ToChar(noKtp.Substring(j, 1));
                        int value = Convert.ToInt32(letter);
                        Console.WriteLine("letter : " + letter + " value : " + value);

                        img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, value));
                    }

                    if (i == img.Width - 1 && j == img.Height - 1)
                    {
                        img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, noKtp.Length));
                    }

                }
            }

            img.Save(path + "\\users_" + u.Id);
            return "users_" + u.Id;
        }
        public static Image BacaGambar(string fileKtp)
        {
            Configuration myConf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            ConfigurationSectionGroup userSetting = myConf.SectionGroups["userSettings"];

            var settingSection = userSetting.Sections["ISA_MiniTrojan.DbSettings"] as ClientSettingsSection;
            string path = settingSection.Settings.Get("photo_id_path").Value.ValueXml?.InnerText;
            try
            {                
                Image image_Ktp = Bitmap.FromFile(path + "\\" + fileKtp);
                return image_Ktp;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
        public static List<User> BacaDataStaff(string filter = "", string nilai = "")
        {
            string sql;
            if (filter == "")
            {
                sql = "select * from users where role = 'Staff'";
            }
            else
            {
                sql = "select * from users" +
                      " where " + filter + " like '%'" + nilai + "%' and role = 'Staff'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<User> listUser = new List<User>();
            while (hasil.Read() == true)
            {
                User user = new User();
                user.Id = int.Parse(hasil.GetValue(0).ToString());
                user.email = hasil.GetValue(1).ToString();
                user.username = hasil.GetValue(2).ToString();
                user.nama = hasil.GetValue(4).ToString();
                user.saldo = hasil.GetValue(5).ToString();
                user.Role = hasil.GetValue(6).ToString();
                user.Sisa_percobaan_login = hasil.GetInt16(7);

                listUser.Add(user);
            }
            return listUser;
        }
        public static bool HapusData(User u)
        {
            string sql = "DELETE FROM users WHERE id= '" + u.Id + "';";

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
        public static void GantiPassword(User u, string passwordLama, string passwordBaru)
        {
            if (UserLogin(u.Username, passwordLama) != null)
            {
                string sql = "Update users set password = SHA2('" + passwordBaru + "',512) where id = '" + u.Id + "'";
                Koneksi.JalankanPerintahDML(sql);
            }
            else
            {
                throw new Exception("Password Lama Salah");
            }

        }
        public static string Decode(Image image)
        {
            Bitmap img = new Bitmap(image);
            string message = "";

            Color lastpixel = img.GetPixel(img.Width - 1, img.Height - 1);
            int msgLength = lastpixel.B;

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixel = img.GetPixel(i, j);

                    if (i < 1 && j < msgLength)
                    {
                        int value = pixel.B;
                        char c = Convert.ToChar(value);
                        string letter = System.Text.Encoding.ASCII.GetString(new byte[] { Convert.ToByte(c) });

                        message = message + letter;
                    }
                }
            }

            return message;
        }
       
    }
}