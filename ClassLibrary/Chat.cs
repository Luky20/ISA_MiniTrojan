using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Chat
    {
        private int id;
        private User konsumen;
        private User admin;
        private DateTime date;
        private string pesan;
        private bool is_konsumen_penerima;

        public Chat(int id, User konsumen, User admin, DateTime date, string pesan, bool is_konsumen_penerima)
        {
            Id = id;
            Konsumen = konsumen;
            Admin = admin;
            Date = date;
            Pesan = pesan;
            Is_konsumen_penerima = is_konsumen_penerima;
        }

        public Chat()
        {
            id = 1;
            Konsumen = new User();
            Admin = new User();
            Date = new DateTime();
            Pesan = "";
            Is_konsumen_penerima = false;
        }

        public int Id { get => id; set => id = value; }
        public User Konsumen { get => konsumen; set => konsumen = value; }
        public User Admin { get => admin; set => admin = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Pesan { get => pesan; set => pesan = value; }
        public bool Is_konsumen_penerima { get => is_konsumen_penerima; set => is_konsumen_penerima = value; }

        public static List<Chat> BacaChatKonsumen(User konsumen)
        {
            string sql;
            sql = "select * from chats " +
                  "where konsumen = " + konsumen.Id +
                  " order by date asc";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<Chat> listChat = new List<Chat>();
            while (hasil.Read() == true)
            {
                Chat c = new Chat();
                c.Id = hasil.GetInt32(0);
                c.Konsumen.Id = hasil.GetInt32(1);
                c.Admin.Id = hasil.GetInt32(2);
                c.Date = hasil.GetDateTime(3);
                c.Pesan = hasil.GetString(4);
                c.Is_konsumen_penerima = hasil.GetBoolean(5);                                                                               
                listChat.Add(c);
            }
            return listChat ;
        }
        private static int GenerateId()
        {
            string sql = "select max(id) from chats";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            if (hasil.Read() == true)
            {
                return int.Parse(hasil.GetValue(0).ToString()) + 1;
            }
            return 1;
        }
        public static bool TambahChatKonsumen(User konsumen, String pesan)
        {
            int id = GenerateId();
            string sql = "insert into chats(id, konsumen, date, pesan, is_konsumen_penerima) " +
                         "values ('" + id + "','" + konsumen.Id + "', now() ,'" + pesan + "','0')";
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

        public static bool TambahChatAdmin(User konsumen, User admin, String pesan)
        {
            int id = GenerateId();
            string sql = "insert into chats(id, konsumen, admin ,date, pesan, is_konsumen_penerima) " +
                         "values ('" + id + "','" + konsumen.Id + "','" + admin.Id + "', now() ,'" + pesan + "','1')";
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
    }
}
