using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class Cliente_Controller
    {
        // Constructor 
        public Cliente_Controller() { }
        // Atributos
        public int ID { get; set; }
        public string User { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public double Phone { get; set; }
        public double Document { get; set; }
        public string Emali { get; set; }
        public int id_tipoUsuario { get; set; }
        public int id_estado { get; set; }
        //  Metodos
        public int InsertData() {
            return Cliente_Modelo.AddData(User,Name,Password,Phone,Document,Emali,id_tipoUsuario,id_estado);
        }

        public DataTable ReadClients() {
            return Cliente_Modelo.LoadData();
        }
    }
}
