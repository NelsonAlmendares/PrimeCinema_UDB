using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class Data_Controller
    {
        // Para el registro de Clientes
        public static DataTable LoadTypes() {
            return Data_Modelo.LoadTypeClients();
        }
        public static DataTable LoadState() {
            return Data_Modelo.LoadStateClients();
        }
        // Para el registro de Sucursales
        public static DataTable LoadSalas() {
            return Data_Modelo.LoadSalasSucursal();
        }

        // Para el registro de pelis
        public static DataTable LoadHorarios()
        {
            return Data_Modelo.LoadHorarios();
        }
        public static DataTable LoadFormato()
        {
            return Data_Modelo.LoadFormato();
        }

        // Para el registro de Salas
        public static DataTable LoadPelis() {
            return Data_Modelo.LoadPelis();
        }
    }
}
