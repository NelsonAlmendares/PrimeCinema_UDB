using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class Cliente_Modelo
    {
        public static int AddData(string User_Cliente, string Name_Cliente, string Password_Cliente, double Phone, double Document_Cliente, string Email_Cliente,  int pid_tipoUsuario, int pid_estado) {
            int retorno = 0;
            try {
                MySqlCommand cmbInsert = new MySqlCommand(string.Format("INSERT INTO Usuario (usuario, name_Usuario, password_Usuario, phone_Usuario, document_Usuario, email_Usuario, id_tipoUsuario, id_estado) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", User_Cliente, Name_Cliente, Password_Cliente, Phone, Document_Cliente, Email_Cliente, pid_tipoUsuario, pid_estado),
                    Model_Concexion.Conectar());
                retorno = Convert.ToInt32(cmbInsert.ExecuteNonQuery());
                return retorno;
            } catch (Exception) {
                return retorno = 0;
            }
        }

        public static DataTable LoadData () {
            DataTable data;
            try {
                string query = "SELECT id_Usuario AS ID, usuario AS Usuario,name_Usuario AS Nombre, nombre_User AS Tipo_Usuario, phone_Usuario AS Teléfono, document_Usuario AS DUI, email_Usuario AS Correo,estado_Usuario AS Estado  FROM Usuario Us INNER JOIN tipo_Ususario Tp ON Us.id_tipoUsuario = Tp.id_tipo INNER JOIN Estado Es ON Us.id_estado = Es.id_Estado";
                MySqlCommand tbSelect = new MySqlCommand(string.Format(query), Model_Concexion.Conectar());
                MySqlDataAdapter adp = new MySqlDataAdapter(tbSelect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            } catch (Exception) {
                return data = null;
            }
        }
    }
}
