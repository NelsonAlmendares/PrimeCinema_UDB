using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class Sucursal_Controller
    {
        // Constructor de clase
        public Sucursal_Controller() { }
        public int ID { get; set; }
        public string Sucursal { get; set; }
        public string Gerente { get; set; }
        public string Direccion { get; set; }
        public double Telefono { get; set; }
        public int id_Sala { get; set; }

        // Métodos
        public int InsertData () {
            return Model_Sucursal.AddData(Sucursal, Gerente, Direccion, Telefono, id_Sala);
        }

        public DataTable ReadSalas() {
            return Model_Sucursal.LoadData();
        }

    }
}
