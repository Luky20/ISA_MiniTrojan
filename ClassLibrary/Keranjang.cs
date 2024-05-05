using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClassLibrary
{
    public class Keranjang
    {
        private User user;
        private Product product;
        private int jumlah;

        public Keranjang()
        {
            User = new User();
            Product = new Product();
            Jumlah = 0;
        }
        public Keranjang(User user, Product product, int jumlah)
        {
            User = user;
            Product = product;
            Jumlah = jumlah;
        }

        public User User { get => user; set => user = value; }
        public Product Product { get => product; set => product = value; }
        public int Jumlah { get => jumlah; set => jumlah = value; }

        public static List<Keranjang> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql;
            if (kriteria == "")
            {
                sql = "select u.id, u.email, u.username, u.password, u.nama, u.saldo, u.role, u.sisa_percobaan_login, u.photo_id_path, " +
                      " p.id, p.nama, p.deskripsi, p.harga, p.stock," +
                      " k.jumlah from keranjang as k" +
                      " inner join users as u on k.users_id = u.id" +
                      " inner join produk as p on k.produk_id = p.id";
            }
            else
            {
                sql = "select u.id, u.email, u.username, u.password, u.nama, u.saldo, u.role, u.sisa_percobaan_login, u.photo_id_path, " +
                      " p.id, p.nama, p.deskripsi, p.harga, p.stock," +
                      " k.jumlah from keranjang as k" +
                      " inner join users as u on k.users_id = u.id" +
                      " inner join produk as p on k.produk_id = p.id" +
                      " where " + kriteria + " = '" + nilaiKriteria + "'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<Keranjang> listKeranjang = new List<Keranjang>();
            while (hasil.Read() == true)
            {
                User u = new User();
                u.Id = int.Parse(hasil.GetValue(0).ToString());
                u.email = hasil.GetValue(1).ToString();
                u.username = hasil.GetValue(2).ToString();
                u.nama = hasil.GetValue(4).ToString();
                u.saldo = hasil.GetValue(5).ToString();
                u.Role = hasil.GetValue(6).ToString();
                u.Sisa_percobaan_login = int.Parse(hasil.GetValue(7).ToString());

                Product p = new Product();
                p.Id = int.Parse(hasil.GetValue(9).ToString());
                p.Name = hasil.GetValue(10).ToString();
                p.Description = hasil.GetValue(11).ToString();
                p.Price = double.Parse(hasil.GetValue(12).ToString());
                p.Stock = int.Parse(hasil.GetValue(13).ToString());

                Keranjang k = new Keranjang();
                k.User = u;
                k.Product = p;
                k.Jumlah = int.Parse(hasil.GetValue(14).ToString());
                listKeranjang.Add(k);
            }
            return listKeranjang;
        }
        public static bool TambahData(Keranjang k)
        {
            string sql = "insert into keranjang " +
                         "values('" + k.User.Id + "','" + k.Product.Id + "','" + k.Jumlah + "')";

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
        public static bool UpdateData(Keranjang k)
        {
            string sql = "update keranjang " +
                         "set users_id ='" + k.User.Id + "', produk ='" + k.Product.Id + "', jumlah ='" + k.Jumlah + "'" +
                         "where users_id ='" + k.User.Id + "'";
            int jumlahDataBerubah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDataBerubah == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool HapusData(Keranjang k)
        {
            string sql = "delete from keranjang " +
                         "where users_id ='" + k.User.Id + "' and produk_id='"+k.Product.Id+"'";
            int jumlahDataBerubah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDataBerubah == 0)
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
