using Controlador;
using MySql.Data.MySqlClient;
using Prime_Cinema.Data;
using System;
using System.IO;
using System.Net.Mail;
using System.Windows.Forms;

namespace Prime_Cinema
{
    public partial class Register_Empleado : Form
    {
        public Register_Empleado()
        {
            InitializeComponent();
            txt_Id.Visible = false;
        }

        public void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            bool ValidatedClient = Validate_Client(out string errorMsg);
            if (ValidatedClient)
            {
                InsertData();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(errorMsg, "Usuario no validado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
            }

        }

        void FillType () {
            cmbTipoUser.DataSource = Data_Controller.LoadTypes();
            cmbTipoUser.DisplayMember = ("nombre_User");
            cmbTipoUser.ValueMember = ("id_tipo");
        }

        void FillState () {
            cmb_Estado.DataSource = Data_Controller.LoadState();
            cmb_Estado.DisplayMember = ("estado_Usuario");
            cmb_Estado.ValueMember = ("id_Estado");
        }

        void LoadLists() {
            FillType(); 
            FillState();
        }

        private bool Validate_Client(out string errorMsg) {
            errorMsg = string.Empty;
            
            if (string.IsNullOrEmpty(Txt_Name.Text)) {
                errorMsg += "El campo de Nombre no puedo estar incompleto " + Environment.NewLine;
            } if (string.IsNullOrEmpty(Txt_User.Text)) {
                errorMsg += "El campo de Usuario no puede estar vacio " + Environment.NewLine;
            } if (string.IsNullOrEmpty(Txt_Password.Text)) {
                errorMsg += "El campo de Contraseña no puede estar vacio" + Environment.NewLine;
            } if (string.IsNullOrEmpty(Txt_Email.Text)) {
                errorMsg += "El campo de Correo no puede estar vacio" + Environment.NewLine;
            } if (string.IsNullOrEmpty(Txt_Documento.Text)) {
                errorMsg += "El campo de Documento no puede estar vacio" + Environment.NewLine;
            } if (string.IsNullOrEmpty(Txt_Phone.Text)) {
                errorMsg += "El campo de Teléfono no puede estar vacio" + Environment.NewLine;
            } 
            bool number = double.TryParse(Txt_Phone.Text, out double num_return);
            bool document = double.TryParse(Txt_Documento.Text, out double doc_return);
            if (number) {
                if (num_return < 8) {
                    errorMsg += "El número no contiene la cantidad de caráteres requerida" + Environment.NewLine;
                }
            } else {
                errorMsg += "El número ingresado debe de ser válido" + Environment.NewLine;
            }
            if (document) {
                if (doc_return < 9) {
                    errorMsg += "El Documento no contiene la cantidad de caráteres requerida" + Environment.NewLine;
                }
            } else {
                errorMsg += "El documento ingresado debe de ser válido" + Environment.NewLine;
            }
            try {
                new MailAddress(Txt_Email.Text);
            } catch (Exception ex) {
                errorMsg += "El correo no posee el formato correcto" + Environment.NewLine + ex;
            }

            return errorMsg == string.Empty;
        }

        // Inserccion
        void InsertData() {
            Cliente_Controller objClientes = new Cliente_Controller();
            objClientes.User = Txt_User.Text;
            objClientes.Name = Txt_Name.Text;
            objClientes.Password = Txt_Password.Text;
            objClientes.Emali = Txt_Email.Text;
            objClientes.Phone = Convert.ToDouble(Txt_Phone.Text);
            objClientes.Document = Convert.ToDouble(Txt_Documento.Text);
            objClientes.id_estado = Convert.ToInt32(cmb_Estado.SelectedValue);
            objClientes.id_tipoUsuario = Convert.ToInt32(cmbTipoUser.SelectedValue);
            int response = objClientes.InsertData();
            if (response >= 1) { 
                data_Clientes.DataSource = objClientes.ReadClients();
                CleanData();
            } else {
                MessageBox.Show("Empleado no pude ser Registrado", "SOLICITUD DENEGADA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        void LoadGrid() {
            Cliente_Controller objReadClientes = new Cliente_Controller();
            data_Clientes.DataSource = objReadClientes.ReadClients();
        }

        void CleanData () {
            Txt_User.Clear();
            Txt_Name.Clear();
            Txt_Documento.Clear();
            Txt_Email.Clear();
            Txt_Password.Clear();
            Txt_Phone.Clear();
        }

        private void Register_Empleado_Load(object sender, EventArgs e)
        {
            LoadLists();
            LoadGrid();
        }

        private void Test_Connection_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
             con = Conection_Controller.Connect_Model();
            if (con != null) { 
                MessageBox.Show("Conexión con el servidor realizada de manera exitosa", "CONEXIÓN ESTABLE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show("Sin conexión, verifique que los servicios del servidior estén activos\n" +
                    "Comuniquese con su Administrador", "CONEXIÓN NO ESTABLECIDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
