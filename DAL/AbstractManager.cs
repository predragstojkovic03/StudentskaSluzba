using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AbstractManager
    {
        protected SqlConnection _sqlConnection;

        public AbstractManager()
        {
            _sqlConnection = new SqlConnection(@"
                Data Source=Predrag\SQLEXPRESS;
                Initial Catalog=StudentskaSluzba;
                Integrated Security=True;
                Connect Timeout=30;
                Encrypt=True;
                Trust Server Certificate=True;
                Application Intent=ReadWrite;
                Multi Subnet Failover=False");
        }

        protected void Connect()
        {
            _sqlConnection.Open();
        }

        protected void Disconnect()
        {
            _sqlConnection.Close();
        }
    }
}
