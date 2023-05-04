using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Modelo;

namespace Modelo
{
    public class Data_Modelo
    {
        public static DataTable LoadTypeClients() {
            DataTable data;
            try {
                string query = "SELECT * FROM tipo_Ususario";
                MySqlCommand cmbSelect = new MySqlCommand(string.Format(query), Model_Concexion.Conectar());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmbSelect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            } catch (Exception) {
                return data = null;
            }
        }

        public static DataTable LoadStateClients() {
            DataTable data;
            try {
                string query = "SELECT * FROM Estado";
                MySqlCommand cmbSelectState = new MySqlCommand(string.Format(query), Model_Concexion.Conectar());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmbSelectState);
                data = new DataTable();
                adp.Fill(data);
                return data;
            } catch (Exception) {
                return data = null;
            }
        }

        public static DataTable LoadSalasSucursal() {
            DataTable data;
            try {
                string query = "SELECT * FROM Salas";
                MySqlCommand cmbSelectSala = new MySqlCommand(string.Format(query), Model_Concexion.Conectar());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmbSelectSala);
                data = new DataTable();
                adp.Fill(data);
                return data;
            } catch (Exception) {
                return data = null;
            }
        }
        public static DataTable LoadHorarios() {
            DataTable data;
            try {
                string query = "SELECT * FROM Horario";
                MySqlCommand cmbSelectHorario = new MySqlCommand(string.Format(query), Model_Concexion.Conectar());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmbSelectHorario);
                data = new DataTable();
                adp.Fill(data);
                return data;
            } catch (Exception) {
                return data = null;
            }
        }
        public static DataTable LoadFormato() {
            DataTable data;
            try {
                string query = "SELECT * FROM Formato";
                MySqlCommand cmbSelectFormato = new MySqlCommand(string.Format(query), Model_Concexion.Conectar());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmbSelectFormato);
                data = new DataTable();
                adp.Fill(data);
                return data;
            } catch (Exception) {
                return data = null;
            }
        }

        public static DataTable LoadPelis() {
            DataTable data;
            try {
                string query = "SELECT * FROM Peliculas";
                MySqlCommand cmbSelectPelis = new MySqlCommand(string.Format(query), Model_Concexion.Conectar());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmbSelectPelis);
                data = new DataTable();
                adp.Fill(data);
                return data;
            } catch (Exception) {
                return data = null;
            }
        }
    }
}
