using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class Model_Sucursal
    {
        public static int AddData (string name_Sucursal, string name_Gerente, string direccion_Sucursal, double telefono_Sucursal, int pid_Sala) {
            int retorno = 0;
            try {
                MySqlCommand cmbInsert = new MySqlCommand(string.Format("INSERT INTO Sucursales (name_Sucursal,gerente_Sucursal,direccion_Sucursal,phone_Sucursal,id_Sala) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", name_Sucursal, name_Gerente, direccion_Sucursal, telefono_Sucursal, pid_Sala),
                    Model_Concexion.Conectar());
                retorno = Convert.ToInt32(cmbInsert.ExecuteNonQuery());
                return retorno;
            } catch (Exception) {
                return retorno = 0;
            }
        }

        public static DataTable LoadData () {
            DataTable data;
            try{
                string query = "SELECT name_Sucursal AS Nombre , direccion_Sucursal AS Dirección, gerente_Sucursal AS  Gerente, phone_Sucursal AS Teléfono, number_Sala AS Número_Sala FROM Sucursales Su INNER JOIN Salas Sa ON Su.id_Sala = Sa.id_Sala";
                MySqlCommand tblSelect = new MySqlCommand(string.Format(query), Model_Concexion.Conectar());
                MySqlDataAdapter adp = new MySqlDataAdapter(tblSelect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            } catch (Exception) {
                return data = null;
            }
        }
    }
}
