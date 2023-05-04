using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class Model_Concexion
    {
        public static MySqlConnection Conectar() {
            MySqlConnection connect;
            try
            {
                string server, database, uid, pwd;
                server = "127.0.0.1";
                database = "prime_cinema";
                uid = "root";
                pwd = "";
                connect = new MySqlConnection("server = " + server +
                                              "; database = " + database +
                                              "; uid = " + uid +
                                              "; pwd = " + pwd);
                connect.Open();
                return connect;
            }
            catch (Exception)
            {
                return connect = null;
            }
        }
    }
}
