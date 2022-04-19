using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataHandle : ConnectDatabase
    {
        /// <summary>
        ///     - Đọc dữ liệu từ database qua procedure
        ///     - Procedure truyền vào cho hàm này không có tham số 
        /// </summary>
        /// <param name="proc">Tên stored procedure</param>
        /// <returns>Bảng giá trị</returns>
        /// <author>Phan Quang Quí</author>
        /// <MSSV>1911547798</MSSV>
        public DataTable ReadData(string proc)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = proc;
                    cmd.Connection = conn;
                    using (SqlDataAdapter adt = new SqlDataAdapter(cmd))
                    {
                        using (DataTable tb = new DataTable())
                        {
                            adt.Fill(tb);
                            if (tb == null)
                            {
                                throw new Exception("Lỗi");
                            }
                            return tb;
                        }
                    }
                }
            }
        }

        /// <summary>
        ///     - Đọc dữ liệu từ database qua câu truy vấn SQL
        ///     - Lấy toàn bộ dữ liệu từ database để hiển thị lên màn hình
        /// </summary>
        /// <param name="query">Chuỗi truy vấn SQL</param>
        /// <returns>Bảng giá trị</returns>
        /// <author>Phan Quang Quí</author>
        /// <MSSV>1911547798</MSSV>
        public DataTable Read(string query)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;
                    using (SqlDataAdapter adt = new SqlDataAdapter(cmd))
                    {
                        using (DataTable tb = new DataTable())
                        {
                            adt.Fill(tb);
                            if (tb == null)
                            {
                                throw new Exception("Lỗi");
                            }
                            return tb;
                        }
                    }
                }
            }
        }

        /// <summary>
        ///     - Đọc dữ liệu từ database phục vụ cho tìm kiếm dữ liệu qua procedure
        ///     - Parameter = tên biến trong stored procedure còn value = giá trị tham số truyền vào
        /// </summary>
        /// <param name="proc">Tên stored procedure</param>
        /// <param name="agrs">
        ///     - Mảng các giá trị truyền vào
        ///     - Kiểm tra xem độ dài agrs có >0 và độ dài mảng agrs % 2 == 0?
        ///     - Nếu kiểm tra đúng thì thực hiện thêm dữ liệu [SqlCommand].Parameters.AddWithValue(agrs[i].ToString(), agrs[i + 1]); 
        ///     - Mỗi lần i tăng thêm 2 đơn vị: với agrs[i] = parameter và agrs[i + 1] = value
        ///     - Nếu kiểm tra không đúng thì throw về Exception
        /// </param>
        /// <returns>Bảng giá trị</returns>
        /// <author>Phan Quang Quí</author>
        /// <MSSV>1911547798</MSSV>
        public DataTable ReadData(string proc, params object[] agrs)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = proc;
                    cmd.Connection = conn;
                    if(agrs.Length > 0 && agrs.Length % 2 == 0)
                    {
                        for (int i = 0; i < agrs.Length; i+=2)
                        {
                            cmd.Parameters.AddWithValue(agrs[i].ToString(), agrs[i + 1]);
                        }
                    }
                    using (SqlDataAdapter adt = new SqlDataAdapter(cmd))
                    {
                        using (DataTable tb = new DataTable())
                        {
                            adt.Fill(tb);
                            if (tb == null)
                            {
                                throw new Exception("Lỗi");
                            }
                            return tb;
                        }
                    }
                }
            }
        }

        /// <summary>
        ///     - Thêm dữ liệu vào database qua procedure
        ///     - Parameter = tên biến trong stored procedure value = giá trị tham số truyền vào để thực hiện cho mục đích thêm dữ liệu
        /// </summary>
        /// <param name="proc">Tên procedure</param>
        /// <param name="agrs">
        ///     - Mảng các giá trị truyền vào
        ///     - Kiểm tra xem độ dài agrs có >0 và độ dài mảng agrs % 2 == 0?
        ///     - Nếu kiểm tra đúng thì thực hiện thêm dữ liệu [SqlCommand].Parameters.AddWithValue(agrs[i].ToString(), agrs[i + 1]); 
        ///     - Mỗi lần i tăng thêm 2 đơn vị: với agrs[i] = parameter và agrs[i + 1] = value
        ///     - Nếu kiểm tra không đúng thì throw về Exception
        /// </param>
        /// <author>Phan Quang Quí</author>
        /// <MSSV>1911547798</MSSV>
        public void AddData(string proc, params object[] agrs)
        {
            using(SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = proc;
                        if (agrs.Length > 0 && agrs.Length % 2 == 0)
                        {
                            try
                            {
                                for (int i = 0; i < agrs.Length; i += 2)
                                {
                                    cmd.Parameters.AddWithValue(agrs[i].ToString(), agrs[i + 1]);
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    conn.Dispose();
                }
            }
        }

        /// <summary>
        ///     - Sửa dữ liệu qua stored procedure
        ///     - Parameter = tên biến trong stored procedure value = giá trị tham số truyền vào để thực hiện thay đổi dữ liệu
        /// </summary>
        /// <param name="proc">Tên procedure</param>
        /// <param name="agrs">
        ///     - Mảng các giá trị truyền vào
        ///     - Kiểm tra xem độ dài agrs có >0 và độ dài mảng agrs % 2 == 0?
        ///     - Nếu kiểm tra đúng thì thực hiện thêm dữ liệu cmd.Parameters.AddWithValue(agrs[i].ToString(), agrs[i + 1]); 
        ///     - Mỗi lần i tăng thêm 2 đơn vị: với agrs[i] = parameter và agrs[i + 1] = value
        ///     - Nếu kiểm tra không đúng thì throw về Exception
        /// </param>
        /// <author>Phan Quang Quí</author>
        /// <MSSV>19115477987</MSSV>
        public void UpdateData(string proc, params object[] agrs)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = proc;
                        if (agrs.Length > 0 && agrs.Length % 2 == 0)
                        {
                            try
                            {
                                for (int i = 0; i < agrs.Length; i += 2)
                                {
                                    cmd.Parameters.AddWithValue(agrs[i].ToString(), agrs[i + 1]);
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        cmd.ExecuteNonQuery();
                        conn.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    conn.Dispose();
                }
            }
        }


        /// <summary>
        ///     - Xóa dữ liệu qua stored procedure
        ///     - Parameter = tên biến trong stored procedure value = giá trị tham số truyền vào để thực hiện xóa dữ liệu
        /// </summary>
        /// <param name="proc">Tên procedure</param>
        /// <param name="agrs">
        ///     - Mảng các giá trị truyền vào
        ///     - Kiểm tra xem độ dài agrs có >0 và độ dài mảng agrs % 2 == 0?
        ///     - Nếu kiểm tra đúng thì thực hiện thêm dữ liệu cmd.Parameters.AddWithValue(agrs[i].ToString(), agrs[i + 1]); 
        ///     - Mỗi lần i tăng thêm 2 đơn vị: với agrs[i] = parameter và agrs[i + 1] = value
        ///     - Nếu kiểm tra không đúng thì throw về Exception
        /// </param>
        /// <author>Phan Quang Quí</author>
        /// <MSSV>19115477987</MSSV>
        public void DeleteData(string proc, params object[] agrs)
        {
            using(SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = proc;
                    if(agrs.Length > 0 && agrs.Length % 2 == 0)
                    {
                        try
                        {
                            for (int i = 0; i < agrs.Length; i += 2)
                            {
                                cmd.Parameters.AddWithValue(agrs[i].ToString(), agrs[i + 1]);
                            }
                        }
                        catch (Exception)
                        {
                            throw new Exception("Lỗi rồi!!!");
                        }
                    }
                    cmd.ExecuteNonQuery();
                }
                conn.Dispose();
            }
        }

        /// <summary>
        ///     - Đăng nhập tài khoản qua stored procedure
        /// </summary>
        /// <param name="proc">Tên stored procedure</param>
        /// <param name="agrs">
        ///     - Mảng các giá trị truyền vào
        ///     - Kiểm tra xem độ dài agrs có >0 và độ dài mảng agrs % 2 == 0?
        ///     - Nếu kiểm tra đúng thì thực hiện thêm dữ liệu [SqlCommand].Parameters.AddWithValue(agrs[i].ToString(), agrs[i + 1]); 
        ///     - Mỗi lần i tăng thêm 2 đơn vị: với agrs[i] = parameter và agrs[i + 1] = value
        ///     - Nếu kiểm tra không đúng thì throw về Exception
        /// </param>
        /// <returns>Bảng giá trị</returns>
        /// <author>Phan Quang Quí</author>
        /// <MSSV>1911547798</MSSV>
        public int Login(string proc, params object[] agrs)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = proc;
                    cmd.Connection = conn;
                    if (agrs.Length > 0 && agrs.Length % 2 == 0)
                    {
                        for (int i = 0; i < agrs.Length; i += 2)
                        {
                            cmd.Parameters.AddWithValue(agrs[i].ToString(), agrs[i + 1]);
                        }
                    }
                    object obj = cmd.ExecuteScalar();
                    int code = Convert.ToInt32(obj);
                    return code;
                }
            }
        }
    }
}
