using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SSInstructor.Class
{
    class moduleMySQL
    {
        private MySqlDataAdapter mySQLAdapter;
        private MySqlConnection mySQLConn;
        private MySqlCommand mySQLCmd;
        private MySqlDataReader mySQLReader;
        private MySqlTransaction mySQLTransact;

        private string conn = "Server=localhost; port=3306; Uid=root; Pwd=admin123!; database=";
        public string errMessage;
    }
}
