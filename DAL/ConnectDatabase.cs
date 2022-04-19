using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ConnectDatabase
    {
        // Khai báo tên server, tên cơ sở dữ liệu, tài khoản, mật khẩu để kết nối với database
        public string _sever, _database, _user, _pwd;
        // Khai báo tên chuỗi kết nối và gán cho chuỗi này giá trị empty
        public static string _connectionString = String.Empty;

        // Thiết lập chuỗi kết nối
        public void connectionInfo(string server, string database, string user, string pwd)
        {
            _sever = server;
            _database = database;
            _user = user;
            _pwd = pwd;
            setConnectionString();
        }

        // Thiết lập chuỗi kết nối
        private void setConnectionString()
        {
            string _connection = @"Data Source= {0};Initial Catalog= {1};User ID= {2}; Password = {3};";
            _connectionString = String.Format(_connection, _sever, _database, _user, _pwd);
        }

        //
        public bool CheckConnection()
        {
            using(SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    conn.Close();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}
