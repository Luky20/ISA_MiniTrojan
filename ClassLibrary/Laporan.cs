using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Laporan
    {
        public static Transaksi BacaDataInvoice(int idTransaksi)
        {
            string sql = "select t.id, t.date, t.total, u.username " +
                "from transaksi as t inner join users as u on t.id = u.id " +
                "where t.id = '" + idTransaksi + "'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            Transaksi t = new Transaksi();
            if (hasil.Read())
            {
                User u = new User();
                u.username = hasil.GetString(3);
                t.Id = hasil.GetInt32(0);
                t.Date = DateTime.Parse(hasil.GetValue(1).ToString());
                t.Total = double.Parse(hasil.GetValue(2).ToString());
                t.User = u;
            }

            string sql2 = "select p.nama, dt.quantity, dt.harga from detail_transaksi as dt " +
                "inner join produk as p on dt.products_id = p.id " +
                "where transaksi_id = '" + t.Id + "'";
            MySqlDataReader hasil2 = Koneksi.JalankanPerintahQuery(sql2);

           List<DetailTransaksi> listDetailTransaksi = new List<DetailTransaksi>();
            while (hasil2.Read())
            {
                DetailTransaksi dt = new DetailTransaksi();
                dt.Transactions.Id = t.Id;
                dt.Product.Name = hasil2.GetString(0);
                dt.Quantity = hasil2.GetInt16(1);
                dt.Harga = hasil2.GetDouble(2);
                listDetailTransaksi.Add(dt);
            }
            t.DetailTransaksiList = listDetailTransaksi;
            return t;

        }

        public static void PrintLaporan1(int idTransaksi)
        {

            string namaFile = "Invoice";
            StreamWriter tempFile = new StreamWriter(namaFile);
            tempFile.WriteLine("");
            tempFile.WriteLine("ISA_MiniTrojan");
            tempFile.WriteLine("Shopping");
            tempFile.WriteLine("Phone. (031)-123456");
            tempFile.WriteLine("=".PadRight(50, '='));

            Transaksi t = Laporan.BacaDataInvoice(idTransaksi);
            tempFile.WriteLine("Transactions ID: " + t.Id.ToString());
            tempFile.WriteLine("Date: " + t.Date.ToString("yyyy-MM-dd HH:mm:ss"));
            tempFile.WriteLine("Total: " + t.Total.ToString());
            tempFile.WriteLine("Username: " + t.User.Username);
            tempFile.WriteLine("=".PadRight(50, '='));

            tempFile.WriteLine("================Transaction's Detail====================");
            tempFile.WriteLine("");
            foreach (DetailTransaksi dt in t.DetailTransaksiList)
            {
                tempFile.WriteLine("Product Name : " + dt.Product.Name);
                tempFile.WriteLine("Quantity : " + dt.Quantity);
                tempFile.WriteLine("Price : " + dt.Harga);
                tempFile.WriteLine("");
            }
            double total = t.Total;
            tempFile.WriteLine("=".PadRight(50, '='));
            tempFile.WriteLine("Total: " + total.ToString());
            tempFile.WriteLine("=".PadRight(50, '='));
            tempFile.WriteLine("Thank you");
            tempFile.WriteLine("");
            tempFile.Close();

            CustomPrint p = new CustomPrint(new Font("Courier New", 12), namaFile, 20, 10, 10, 10);
            p.SendToPrinter();
        }

    }
}
