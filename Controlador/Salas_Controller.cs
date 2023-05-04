using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class Salas_Controller
    {
        public Salas_Controller() { }
        public int id { get; set; }
        public int Number_Sala { get; set; }
        public int id_Horario { get; set; }
        public int id_Pelicula { get; set; }

        public int InsertData() {
            return Modelo_Salas.AddData(Number_Sala, id_Horario, id_Pelicula);
        }

        public DataTable LoadData() {
            return Modelo_Salas.LoadData();
        }
    }
}
