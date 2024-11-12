using Npgsql;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialTools
{
    public partial class GreenplumDB
    {

        private string _Username;
        private string _Password;
        private string _ConnectionString;

        private string Username { get { return _Username; } set { _Username = value; } }
        private string Password { get { return _Password; } set { _Password = value; } }
        private string ConnectionString { get { return _ConnectionString; } set { _ConnectionString = value; } }

        public GreenplumDB(string Username, string Password)
        {
            this._Username = Username;
            this._Password = Password;
            this._ConnectionString = "Server=greenplum.example.org;Database=exampledb;port=5432;User Id=" + Username + ";Password=" + Password;
        }


  
        private static string GetConnectionString(string username, string password)
        {
            // You will need to modify this connection string to match your SQL Server Configuration
            return "Server=greenplum.example.org;Database=exampledb;port=5432;Timeout=60;Keepalive=60;User Id=" + username + ";Password=" + password;
        }

    }

}