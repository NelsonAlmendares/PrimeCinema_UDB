using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Modelo_PrimerUso
    {
        public static bool CheckUser() {
            bool retorno;
            string query = "SELECT * FROM Usuario";
            try {
                MySqlCommand cmdSelect = new MySqlCommand(string.Format(query), Model_Concexion.Conectar());
                retorno = Convert.ToBoolean(cmdSelect.ExecuteScalar());
                return retorno;
            } catch (Exception) {
                return false;
            }
        }
    }
}
