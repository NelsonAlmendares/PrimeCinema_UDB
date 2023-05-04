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
using System.IO;
using System.Drawing.Imaging;
using MySql.Data.MySqlClient;
using Prime_Cinema.Properties;

namespace Prime_Cinema
{
    public partial class RegistroPelicualas : Form
    {
        public RegistroPelicualas()
        {
            InitializeComponent();
        }

        // Métodos
        void FillHorario() {
            Cmb_Horario.DataSource = Data_Controller.LoadHorarios();
            Cmb_Horario.DisplayMember = ("horario");
            Cmb_Horario.ValueMember = ("id_Horario");
        }

        void FillFormato() {
            Cmb_Formato.DataSource = Data_Controller.LoadFormato();
            Cmb_Formato.DisplayMember = ("formato");
            Cmb_Formato.ValueMember = ("id_Formato");
        }

        void LoadComboBox() {
            FillHorario();
            FillFormato();
        }

        void CleanData() {
            Txt_Pelicula.Clear();
            Txt_Genero.Clear();
            Txt_Clasificacion.Clear();
            PbPeli.Image = null;
        }

        void LoadGridPelis (){
            Pelicula_Controller pelis = new Pelicula_Controller();
            data_Pelis.DataSource = pelis.ReadPelis();
        }

        void InsertData() {
            Pelicula_Controller pelis = new Pelicula_Controller();
            pelis.NamePeli = Txt_Pelicula.Text;
            pelis.GenderPeli = Txt_Genero.Text;
            pelis.ClasificacionPeli = Txt_Clasificacion.Text;
            MemoryStream ms = new MemoryStream();
            PbPeli.Image.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();
            string encoded = Convert.ToBase64String(aByte);
            pelis.Image = encoded;
            pelis.id_Formato = Convert.ToInt32(Cmb_Formato.SelectedValue);
            pelis.id_Horario = Convert.ToInt32(Cmb_Horario.SelectedValue);
            int response = pelis.InsertData();
            if (response >= 1)
            {
                data_Pelis.DataSource = pelis.ReadPelis();
                CleanData(); 
            }
            else {
                MessageBox.Show("Empleado no pude ser Registrado", "SOLICITUD DENEGADA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            InsertData();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegistroPelicualas_Load(object sender, EventArgs e)
        {
            LoadGridPelis();
            LoadComboBox();
        }

        private void Btn_Examinar_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Archivos de Imagen .jpg |*.jpg | Archivos de Imagen .png |*.png| Archivos de Imagen .jpeg |*.jpeg| Todos los archivos |*.*";
                DialogResult resultado = openFileDialog1.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    PbPeli.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error al cargar la imagen", "IMAGE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
