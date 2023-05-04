using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Prime_Cinema
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public void Btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Btn_Register.PerformClick();
        }

        public int m, mx, my;

        private void Panel_Superior_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        public bool IsFormOpenInPanel(Panel panel) {
            foreach (Control control in panel.Controls) {
                if (control is Form Register_Empleado && Register_Empleado.Visible) {
                    return true;
                }
            }
            return false;
        }

        public void EvaluarForm() {
            Form exists = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Register").SingleOrDefault<Form>();
            if (exists != null)
            {
                //MessageBox.Show("El Formulario esta abierto", "ABIERTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Btn_Register.BaseColor = Color.FromArgb(82, 163, 226);
            }
            else {
                //MessageBox.Show("El Formulario esta cerrado", "CERRADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Btn_Register.BaseColor = Color.FromArgb(43, 59, 72);
            }
        }

        public void Btn_Register_Click(object sender, EventArgs e)
        {
            Register_Empleado registro = new Register_Empleado();
            registro.TopLevel = false;
            registro.Dock = DockStyle.Fill;
            Panel_Container.Controls.Add(registro);
            registro.Show();
            if (IsFormOpenInPanel(Panel_Container)) {
                Btn_Register.BaseColor = Color.FromArgb(82, 163, 226);
            } else {
                Btn_Register.BaseColor = Color.FromArgb(43, 59, 72);
            }
        }

        private void Btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quieres salir de la Aplicación", "CERRAR SESIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Nos vemos pronto", "Cerrando sesión...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            else {
                MessageBox.Show("Sigue navegando dentro del sistema", "Sesión Activa...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_Minimize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void Btn_Maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void Btn_Sucursal_Click(object sender, EventArgs e)
        {
            Registro_Sucursales sucursales = new Registro_Sucursales();
            sucursales.TopLevel = false;
            sucursales.Dock = DockStyle.Fill;
            Panel_Container.Controls.Add(sucursales);
            sucursales.Show();
        }

        private void Btn_Peliculas_Click(object sender, EventArgs e)
        {
            RegistroPelicualas pelis = new RegistroPelicualas();
            pelis.TopLevel = false;
            pelis.Dock = DockStyle.Fill;
            Panel_Container.Controls.Add(pelis);
            pelis.Show();
        }

        private void Btn_Salas_Click(object sender, EventArgs e)
        {
            RegistroSalas salas = new RegistroSalas();
            salas.TopLevel = false;
            salas.Dock = DockStyle.Fill;
            Panel_Container.Controls.Add(salas);
            salas.Show();

        }

        private void Btn_Perfil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En mantenimiento... \n Próximamente", "VERSION BETA 2.0.1", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Panel_Superior_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void Panel_Superior_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }
    }
}
