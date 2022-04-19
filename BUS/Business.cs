using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class Business
    {
        ConnectDatabase _conn = new ConnectDatabase();
        DataHandle _data = new DataHandle();

        public bool CheckConnect(string _server, string _database, string _user, string _pwd) {
            _conn.connectionInfo(_server, _database, _user, _pwd);
            if(_conn.CheckConnection())
                return true;
            return false;
        }

        public string RandomID(string text)
        {
            Random random = new Random();
            return text + random.Next(0, int.MaxValue).ToString();
        }

        public DataTable GetData(string proc)
        {
            return _data.ReadData(proc);
        }

        public DataTable GetData(string proc, params object[] agrs)
        {
            return _data.ReadData(proc, agrs);
        }

        public DataTable GetDataByQuery(string query)
        {
            return _data.Read(query);
        }

        public void AddData(string proc, params object[] agrs)
        {
            _data.AddData(proc, agrs);
        }

        public void UpdateData(string proc, params object[] agrs)
        {
            _data.UpdateData(proc, agrs);
        }

        public void DeleteData(string proc, params object[] agrs)
        {
            _data.DeleteData(proc, agrs);
        }

        public int login(string proc, params object[] agrs)
        {
            return _data.Login(proc, agrs);
        }
    }
}
