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
