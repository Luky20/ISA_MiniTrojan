using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClassLibrary
{
    public class Transaksi
    {
        private int id;
        private DateTime date;
        private double total;
        private User user;
        private List<DetailTransaksi> detailTransaksiList;

        public Transaksi(int id, DateTime date, double total, User user)
        {
            Id = id;
            Date = date;
            Total = total;
            User = user;
            DetailTransaksiList = new List<DetailTransaksi>();
        }
        public Transaksi()
        {
            Id = 0;
            Date = new DateTime();
            Total = 0;
            User = null;
            DetailTransaksiList = new List<DetailTransaksi>();
        }
        public int Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public double Total { get => total; set => total = value; }
        public User User { get => user; set => user = value; }
        public List<DetailTransaksi> DetailTransaksiList { get; set; }

        private static int GenerateIdTransaksi()
        {
            string sql = "select max(id) from transaksi";
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
        public static void TambahData(Transaksi t)
        {
            t.Id = GenerateIdTransaksi();
            string sqlUser = "select saldo from users where id='" + t.User.Id + "';";
            MySqlDataReader hasilUser = Koneksi.JalankanPerintahQuery(sqlUser);
            if (hasilUser.Read())
            {
                t.User.saldo = hasilUser.GetString(0);
            }
            else
            {
                throw new Exception("User tidak ditemukan");
            }
            if (t.Total <= t.User.Saldo)
            {
                foreach(DetailTransaksi dt in t.DetailTransaksiList)
                {
                    if (dt.Quantity >= dt.Product.Stock)
                    {
                        throw new Exception("stok " + dt.Product.Name + " tidak cukup");
                    }
                       
                }
                string sql1 = "INSERT INTO `minitrojan`.`transaksi` (`id`, `date`, `total`, `users_id`) " +
                        "VALUES ('"+t.Id+"', now(), '"+t.Total+"', '"+t.User.Id+"');";
                Koneksi.JalankanPerintahDML(sql1);

                foreach (DetailTransaksi dt in t.DetailTransaksiList)
                {
                    string sql = "INSERT INTO `minitrojan`.`detail_transaksi` (`transaksi_id`, `products_id`, `quantity`, `harga`) " +
                    "VALUES ('" + t.Id + "', '" + dt.Product.Id + "', '" + dt.Quantity + "', '" + dt.Product.Price + "');";
                    Koneksi.JalankanPerintahDML(sql);
                    string sqlStock = "UPDATE `minitrojan`.`produk` SET `stock` = stock-" + dt.Quantity + " WHERE (`id` = '" + dt.Product.Id + "');";
                    Koneksi.JalankanPerintahDML(sqlStock);
                    string sqlKeranjang = "delete from keranjang " +
                        "where users_id ='" + t.User.Id + "' and produk_id='" + dt.Product.Id + "'";
                    Koneksi.JalankanPerintahDML(sqlKeranjang);
                }
                double saldoAkhir = t.User.Saldo - t.Total;
                string sqlSaldo = "UPDATE `minitrojan`.`users` SET `saldo` = '"+AES.Encrypt(saldoAkhir.ToString(),AES.key)+"' WHERE (`id` = '" + t.User.Id + "');";
                Koneksi.JalankanPerintahDML(sqlSaldo);

            }
            else
            {
                throw new Exception("saldo tidak cukup");
            }
            
            //int jumlahDiubah = Koneksi.JalankanPerintahDML(sql);
            //if(jumlahDiubah == 0)
            //{
            //    return false;
            //}
            //else
            //{
            //    return true;
            //}
        }

        public static List<Transaksi> BacaData(string filter = "", string nilai = "")
        {
            string sql;
            if(filter == "")
            {
                sql = "select t.*, u.* from Transaksi t inner join Users u on t.users_id=u.id";
            }
            else if (filter=="u.id")
            {
                sql = "select t.*, u.* from Transaksi t inner join Users u on t.users_id=u.id" +
                      " where " + filter + " = '" + nilai + "'";
            }
            else
            {
                sql = "select t.*, u.* from Transaksi t inner join Users u on t.users_id=u.id" +
                      " where " + filter + " like '%'" + nilai + "%'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<Transaksi> listTransaksi = new List<Transaksi>();
            while(hasil.Read() == true)
            {
                Transaksi t = new Transaksi();
                t.Id = hasil.GetInt32(0);
                t.Date = DateTime.Parse(hasil.GetValue(1).ToString());
                t.Total = double.Parse(hasil.GetValue(2) .ToString());
                
                User tampung = new User();
                tampung.Id = int.Parse(hasil.GetValue(3).ToString());
                tampung.email = hasil.GetValue(5).ToString();
                tampung.username = hasil.GetValue(6).ToString();
                tampung.password = "";
                tampung.nama = hasil.GetValue(8).ToString();
                tampung.saldo = hasil.GetValue(9).ToString();
                tampung.role = hasil.GetValue(10).ToString();
                tampung.Sisa_percobaan_login = hasil.GetInt32(11);
                t.User = tampung;
                listTransaksi.Add(t); 
            }
            foreach (Transaksi t in listTransaksi)
            {
                t.DetailTransaksiList = DetailTransaksi.BacaData("t.id", t.Id.ToString());
            }
            return listTransaksi;
        }
    }
}
