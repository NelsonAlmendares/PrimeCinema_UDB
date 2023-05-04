using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace Prime_Cinema
{
    public partial class Primer_Uso : Form
    {
        public Primer_Uso()
        {
            InitializeComponent();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            // Verificar la exitencia de un Empleado
            PrimerUso_Controller objPrimerUso = new PrimerUso_Controller();
            bool response = objPrimerUso.VerifyUser();
            if (response == true) {
                MessageBox.Show("Creando tu sesión en el sistema...", "REDIRIGIENDO - LOGIN...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login login = new Login();
                this.Hide();
                login.Show();
            } else {
                MessageBox.Show("No existen usuarios Registrados...", "NECESITAS REGISTRARTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Register_Empleado registro_Admin = new Register_Empleado();
                this.Hide();
                registro_Admin.Show();
            }
        }

        private void Primer_Uso_Load(object sender, EventArgs e)
        {

        }
    }
}
