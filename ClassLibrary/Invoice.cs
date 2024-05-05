using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class Invoice
    {
        private int id;
        private DateTime date;
        private double total;
        private User user;

        public Invoice()
        {
            this.id = 0;
            this.date = DateTime.Now;
            this.total = 0;
            this.user = new User();
        }
        public Invoice(int id, DateTime date, double total, User user)
        {
            this.id = id;
            this.date = date;
            this.total = total;
            this.user = user;
        }

        private static int GenerateId()
        {
            string sql = "select max(id) from transaksi";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            if (hasil.Read() == true)
            {
                return int.Parse(hasil.GetValue(0).ToString()) + 1;
            }
            return 1;
        }

    }
}
