using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Modelo;

namespace Controlador
{
    public class Conection_Controller
    {
        public static MySqlConnection Connect_Model() {
            return Model_Concexion.Conectar();
        }
    }
}
