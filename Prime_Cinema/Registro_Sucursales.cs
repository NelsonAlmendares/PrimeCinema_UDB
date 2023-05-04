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
    public partial class Registro_Sucursales : Form
    {
        public Registro_Sucursales()
        {
            InitializeComponent();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Métodos
        void InserData () {
            Sucursal_Controller objSucursal = new Sucursal_Controller();
            objSucursal.Sucursal = Txt_Sucursal.Text;
            objSucursal.Gerente = Txt_Gerente.Text;
            objSucursal.Direccion = Txt_Direccion.Text;
            objSucursal.Telefono = Convert.ToDouble(Txt_Telefono.Text);
            objSucursal.id_Sala = Convert.ToInt32(cmb_Sala.SelectedValue);
            int response = objSucursal.InsertData();
            if (response >= 1) {
                data_Sucursales.DataSource = objSucursal.ReadSalas();
                CleanTextBox();
            } else {
                MessageBox.Show("Sucursal no pude ser Registrada", "SOLICITUD DENEGADA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        void LoadSalas() {
            cmb_Sala.DataSource = Data_Controller.LoadSalas();
            cmb_Sala.DisplayMember = ("number_Sala");
            cmb_Sala.ValueMember = ("id_Sala");
        }

        void CleanTextBox() {
            Txt_Sucursal.Clear();
            Txt_Gerente.Clear();
            Txt_Direccion.Clear();
            Txt_Telefono.Clear();
        }

        void FillDataSucursal() {
            Sucursal_Controller objSucursal = new Sucursal_Controller();
            data_Sucursales.DataSource = objSucursal.ReadSalas();
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            InserData();
        }

        private void Registro_Sucursales_Load(object sender, EventArgs e)
        {
            FillDataSucursal();
            LoadSalas();
        }
    }
}
