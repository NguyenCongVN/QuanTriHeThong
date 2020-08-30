using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace DXApplication1.Models
{
    class ConnectionDatabase
    {
        SqlConnection connection;
        public ConnectionDatabase()
        {
            InitClass();
        }
        private void InitClass()
        {
            string connectionStr = ConfigurationManager.AppSettings["MainConnection"];
            connection = new SqlConnection(connectionStr);
        }
        protected SqlConnection Connection
        {
            get { return connection; }
        }
    }
}
