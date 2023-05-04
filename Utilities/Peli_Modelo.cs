using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;

namespace Modelo
{
    public class Peli_Modelo
    {
        public static int AddData(string Name_Peli, string Gender_Peli, string Clasificacion_Peli, string Imagen,int pid_Formato, int pid_Horario) {
            int retorno = 0;
            try { 
                MySqlCommand cmbInsertData = new MySqlCommand(string.Format("INSERT INTO Peliculas (name_Pelicula, gender_Pelicula, clasification_Peli, foto ,id_formato, id_horario) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", Name_Peli, Gender_Peli, Clasificacion_Peli, Imagen,pid_Horario, pid_Formato), Model_Concexion.Conectar());
                retorno = Convert.ToInt32(cmbInsertData.ExecuteNonQuery());
                return retorno;
            } catch (Exception) {
                return retorno = 0;
            }
        }

        public static DataTable ReadData() {
            DataTable data;
            try {
                string query = "SELECT id_Pelicula AS ID, name_Pelicula AS Película, gender_Pelicula AS Género, clasification_Peli AS Clasificación, formato, horario FROM Peliculas Pe INNER JOIN Formato Fo ON Pe.id_formato = Fo.id_Formato INNER JOIN Horario Ho ON Pe.id_horario = Ho.id_Horario";
                MySqlCommand tblSelect = new MySqlCommand(string.Format(query), Model_Concexion.Conectar());
                MySqlDataAdapter adp = new MySqlDataAdapter(tblSelect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            } catch (Exception){
                return data = null;
            }
        }
    }
}
