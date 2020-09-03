using System.Configuration;
using System.Data.SqlClient;

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
