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
    public partial class RegistroSalas : Form
    {
        public RegistroSalas()
        {
            InitializeComponent();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Métodos
        void CleanData() {
            Txt_Sala.Clear();
        }

        void FillPeli() {
            Cmb_Peli.DataSource = Data_Controller.LoadPelis();
            Cmb_Peli.DisplayMember = ("name_Pelicula");
            Cmb_Peli.ValueMember = ("id_Pelicula");
        }

        void FillHorario() {
            cmb_Horario.DataSource = Data_Controller.LoadHorarios();
            cmb_Horario.DisplayMember = ("horario");
            cmb_Horario.ValueMember = ("id_Horario");
        }

        void FillDataGridView() {
            Salas_Controller salas = new Salas_Controller();
            data_Salas.DataSource = salas.LoadData();
        }

        void LoadData() {
            FillPeli();
            FillHorario();
        }
        void InsertData() {
            Salas_Controller salas = new Salas_Controller();
            salas.Number_Sala = Convert.ToInt32(Txt_Sala.Text);
            salas.id_Horario = Convert.ToInt32(cmb_Horario.SelectedValue);
            salas.id_Pelicula = Convert.ToInt32(Cmb_Peli.SelectedValue);
            int response = salas.InsertData();
            if (response >= 1) {
                data_Salas.DataSource = salas.LoadData();
                CleanData();
            } else {
                MessageBox.Show("Sala no pude ser Registrada", "SOLICITUD DENEGADA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void RegistroSalas_Load(object sender, EventArgs e)
        {
            FillDataGridView();
            LoadData();
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            InsertData();
        }
    }
}
