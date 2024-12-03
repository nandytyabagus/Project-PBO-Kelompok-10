using System;
using Npgsql;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Projek_SimBuku.Controller
{
    public class Connector
    {
        protected string addres = "Host=localhost;Username=postgres;Password=123;Database=Simbuku";
        private NpgsqlConnection Conn;
        protected NpgsqlConnection conn
        {
            get { return this.Conn; }
            set
            {
                if (Conn != null)
                {
                    Conn.Close();
                    Conn = null;
                }
                Conn = value;
                Conn.Open();
            }
        }
        public void Setup()
        {
            Execute_No_Return("CREATE TABLE IF NOT EXISTS Data_Akun (" +
                "id_Akun  serial NOT NULL UNIQUE PRIMARY KEY," +
                "username VARCHAR(50) NOT NULL UNIQUE," +
                "password VARCHAR(50) NOT NULL ," +
                "nama VARCHAR(100) NOT NULL," +
                "email    VARCHAR(50) NOT NULL UNIQUE," +
                "nomor_Hp VARCHAR(13) NOT NULL UNIQUE)");

            Execute_No_Return("CREATE TABLE IF NOT EXISTS pengarang (" +
                "id_pengarang SERIAL PRIMARY KEY," +
                "nama_pengarang VARCHAR(50) NOT NULL");

            Execute_No_Return("CREATE TABLE IF NOT EXISTS genre (" +
                "id_genre SERIAL PRIMARY KEY," +
                "genre VARCHAR(20) NOT NULL");

            Execute_No_Return("CREATE TABLE IF NOT EXISTS penerbit (" +
                "id_penerbit SERIAL PRIMARY KEY," +
                "penerbit VARCHAR(50) NOT NULL");

            Execute_No_Return("CREATE TABLE IF NOT EXISTS buku (" +
                "id_buku SERIAL PRIMARY KEY," +
                "judul_buku VARCHAR(50) NOT NULL," +
                "tahun_terbit INT NOT NULL," +
                "gambar BYTEA," +
                "stok INT NOT NULL," + 
                "id_pengarang INT NOT NULL," +
                "id_genre INT NOT NULL," +
                "id_penerbit INT NOT NULL," +
                "FOREIGN KEY (id_pengarang) REFERENCES pengarang(id_pengarang)," +
                "FOREIGN KEY (id_genre) REFERENCES genre(id_genre)," +
                "FOREIGN KEY (id_penerbit) REFERENCES penerbit(id_penerbit)");

            Execute_No_Return("CREATE TABLE IF NOT EXISTS keranjang (" +
                "id_keranjang SERIAL PRIMARY KEY," +
                "id_akun INT NOT NULL," +
                "id_buku INT NOT NULL," +
                "jumlah INT NOT NULL," +
                "FOREIGN KEY (id_akun) REFERENCES akun(id_akun)," +
                "FOREIGN KEY (id_buku) REFERENCES buku(id_buku)");

            Execute_No_Return("CREATE TABLE IF NOT EXISTS metode_pembayaran (" +
                "id_metode_pembayaran SERIAL PRIMARY KEY," +
                "metode VARCHAR(50) NOT NULL");

            Execute_No_Return("CREATE TABLE IF NOT EXISTS transaksi (" +
                "id_transaksi SERIAL PRIMARY KEY," +
                "id_keranjang INT NOT NULL," +
                "id_metode_pembayaran INT NOT NULL," +
                "tanggal_transaksi DATE NOT NULL," +
                "status VARCHAR(50) NOT NULL," +
                "harga_sewa DECIMAL(10, 2) NOT NULL," +
                "harga_denda DECIMAL(10, 2)," +
                "tanggal_pengambilan DATE," +
                "FOREIGN KEY (id_keranjang) REFERENCES keranjang(id_keranjang)," +
                "FOREIGN KEY (id_metode_pembayaran) REFERENCES metode_pembayaran(id_metode_pembayaran)");
        }
        public void Execute_No_Return(string Querry)
        {
            using (conn = new NpgsqlConnection(addres))
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = Querry;
                cmd.ExecuteNonQuery();
            }
        }

        public void Execute_No_Return(NpgsqlCommand command)
        {
            using (conn = new NpgsqlConnection(addres))
            {
                command.Connection = conn;
                command.ExecuteNonQuery();
            }
        }

        public DataTable Execute_With_Return(string Querry)
        {
            using (conn = new NpgsqlConnection(addres))
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = Querry;
                DataTable Data = new DataTable();
                Data.Load(cmd.ExecuteReader());
                return Data;
            }
        }
        public DataTable Execute_With_Return(NpgsqlCommand Querry)
        {
            using (conn = new NpgsqlConnection(addres))
            {
                Querry.Connection = conn;
                DataTable Data = new DataTable();
                Data.Load(Querry.ExecuteReader());
                return Data;
            }
        }
        public object Execute_Single_Return(string querry)
        {
            object Data;
            using (conn = new NpgsqlConnection(addres))
            {
                conn = new NpgsqlConnection(addres);
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = querry;
                Data = cmd.ExecuteScalar();
            }
            return Data;
        }
        public object Execute_Single_Return(NpgsqlCommand command)
        {
            object Data;
            using (conn = new NpgsqlConnection(addres))
            {
                command.Connection = conn;
                Data = command.ExecuteScalar();
            }
            return Data;
        }
    }
}
