using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Prime_Cinema.Data
{
    class Repositorio
    {
        // Ruta de acceso para los clientes:
        private const string RUTE_FILE = @"C:\temp\Clientes.json";

        // Metodo de lista con la cual llenamos los datos del Json
        public static List<Cliente> Clientes { get; private set; }

        public static void StartRepository()
        {            
            Clientes = new List<Cliente>();
        }

        public void AddClient(Cliente cliente) {
            Clientes.Add(cliente);
            string json = JsonConvert.SerializeObject(Clientes, Formatting.Indented);
            File.WriteAllText(RUTE_FILE, json);
        }
    }
}
