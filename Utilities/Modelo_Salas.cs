using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Modelo_Salas
    {
        public static int AddData(int Number, int pid_Horario, int pid_Pelicula) {
            int retorno = 0;
            try {
                MySqlCommand cmbInsert = new MySqlCommand(string.Format("INSERT INTO Salas (number_Sala,id_Horario,id_Pelicula) VALUES ('{0}','{1}','{2}')", Number, pid_Horario, pid_Pelicula), Model_Concexion.Conectar());
                retorno = Convert.ToInt32(cmbInsert.ExecuteNonQuery());
                return retorno;
            } catch (Exception) {
                return retorno = 0;
            }
        }

        public static DataTable LoadData (){
            DataTable data;
            try {
                string query = "SELECT id_Sala AS ID, number_Sala AS NúmeroSala, horario AS Horario, name_Pelicula AS Película, gender_Pelicula AS Género, clasification_Peli AS Clasificación, formato AS Formato, CONCAT('$ ', ROUND(valor_Funcion, 2)) AS ValorFunción FROM Salas Sa INNER JOIN Horario Ho ON Sa.id_Horario = Ho.id_Horario INNER JOIN Peliculas Pe ON Sa.id_Pelicula = Pe.id_Pelicula INNER JOIN Formato Fo ON Pe.id_formato = Fo.id_Formato INNER JOIN Valor Va ON Fo.id_valor = Va.id_valor";
                MySqlCommand cmbSelect = new MySqlCommand(string.Format(query), Model_Concexion.Conectar());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmbSelect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            } catch (Exception){
                return data = null;
            }
        }
    }
}
