using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Prime_Cinema
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Minimize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("server=127.0.0.1; database=prime_cinema;uid=root;pwd=;");
            connect.Open();

            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection connection = new MySqlConnection();
            codigo.Connection = connect;
            codigo.CommandText = ("SELECT name_Usuario, password_Usuario FROM Usuario WHERE usuario = '"+ Txt_User.Text +"' AND password_Usuario = '"+Txt_Password.Text+"' ");
            MySqlDataReader leer = codigo.ExecuteReader();
            if (leer.Read())
            {
                MessageBox.Show("Acceso conseguido","INICIANDO SESIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dashboard main = new Dashboard();
                this.Hide();
                main.Show();
            }
            else {
                MessageBox.Show("Acceso Denegado \n Credenciales no validas", "CONEXIÓN NO ESTABLECIDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contácta con tu supervisor con el códio de error... \n ERR_ACCESS_DENIED", "SOPORTE TÉCNICO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
