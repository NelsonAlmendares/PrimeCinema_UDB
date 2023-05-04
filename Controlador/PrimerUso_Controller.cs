using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Modelo;

namespace Controlador
{
    public class PrimerUso_Controller
    {
        public bool VerifyUser() {
            return Modelo_PrimerUso.CheckUser();
        }
    }
}
