using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class Pelicula_Controller
    {
        // Constructor
        public Pelicula_Controller() { }
        // Atributos
        public int ID { get; set; }
        public string NamePeli { get; set; }
        public string GenderPeli { get; set; }
        public string ClasificacionPeli { get; set; }
        public string Image { get; set; }
        public int id_Formato { get; set; }
        public int id_Horario { get; set; }

        // Metodos
        public int InsertData() { 
            return Peli_Modelo.AddData(NamePeli, GenderPeli, ClasificacionPeli, Image ,id_Formato, id_Horario);
        }
        public DataTable ReadPelis() {
            return Peli_Modelo.ReadData();
        }
    }
}
