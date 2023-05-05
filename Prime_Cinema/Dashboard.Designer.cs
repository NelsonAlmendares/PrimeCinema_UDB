
namespace Prime_Cinema
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel_Lateral = new System.Windows.Forms.Panel();
            this.Btn_Salas = new Guna.UI.WinForms.GunaButton();
            this.Txt_Name = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.Btn_CerrarSesion = new Guna.UI.WinForms.GunaButton();
            this.gunaButton7 = new Guna.UI.WinForms.GunaButton();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.Btn_Perfil = new Guna.UI.WinForms.GunaButton();
            this.Btn_Sucursal = new Guna.UI.WinForms.GunaButton();
            this.Btn_Peliculas = new Guna.UI.WinForms.GunaButton();
            this.Btn_Register = new Guna.UI.WinForms.GunaButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel_Superior = new System.Windows.Forms.Panel();
            this.Btn_Minimize = new System.Windows.Forms.Button();
            this.Btn_Maximize = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel_Container = new System.Windows.Forms.Panel();
            this.Panel_Lateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Panel_Superior.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Lateral
            // 
            this.Panel_Lateral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Panel_Lateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.Panel_Lateral.Controls.Add(this.Btn_Salas);
            this.Panel_Lateral.Controls.Add(this.Txt_Name);
            this.Panel_Lateral.Controls.Add(this.label2);
            this.Panel_Lateral.Controls.Add(this.label1);
            this.Panel_Lateral.Controls.Add(this.gunaCirclePictureBox1);
            this.Panel_Lateral.Controls.Add(this.Btn_CerrarSesion);
            this.Panel_Lateral.Controls.Add(this.gunaButton7);
            this.Panel_Lateral.Controls.Add(this.gunaSeparator1);
            this.Panel_Lateral.Controls.Add(this.Btn_Perfil);
            this.Panel_Lateral.Controls.Add(this.Btn_Sucursal);
            this.Panel_Lateral.Controls.Add(this.Btn_Peliculas);
            this.Panel_Lateral.Controls.Add(this.Btn_Register);
            this.Panel_Lateral.Controls.Add(this.gunaButton2);
            this.Panel_Lateral.Controls.Add(this.pictureBox1);
            this.Panel_Lateral.Location = new System.Drawing.Point(0, 0);
            this.Panel_Lateral.Name = "Panel_Lateral";
            this.Panel_Lateral.Size = new System.Drawing.Size(309, 1054);
            this.Panel_Lateral.TabIndex = 0;
            // 
            // Btn_Salas
            // 
            this.Btn_Salas.Animated = true;
            this.Btn_Salas.AnimationHoverSpeed = 0.09F;
            this.Btn_Salas.AnimationSpeed = 0.05F;
            this.Btn_Salas.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Salas.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.Btn_Salas.BorderColor = System.Drawing.Color.Black;
            this.Btn_Salas.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_Salas.FocusedColor = System.Drawing.Color.Empty;
            this.Btn_Salas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salas.ForeColor = System.Drawing.Color.White;
            this.Btn_Salas.Image = global::Prime_Cinema.Properties.Resources.teatro_white;
            this.Btn_Salas.ImageSize = new System.Drawing.Size(25, 25);
            this.Btn_Salas.Location = new System.Drawing.Point(12, 554);
            this.Btn_Salas.Name = "Btn_Salas";
            this.Btn_Salas.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(163)))), ((int)(((byte)(226)))));
            this.Btn_Salas.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(163)))), ((int)(((byte)(226)))));
            this.Btn_Salas.OnHoverForeColor = System.Drawing.Color.White;
            this.Btn_Salas.OnHoverImage = global::Prime_Cinema.Properties.Resources.teatro_white;
            this.Btn_Salas.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(108)))), ((int)(((byte)(150)))));
            this.Btn_Salas.Radius = 10;
            this.Btn_Salas.Size = new System.Drawing.Size(280, 55);
            this.Btn_Salas.TabIndex = 3;
            this.Btn_Salas.Text = "Salas";
            this.Btn_Salas.Click += new System.EventHandler(this.Btn_Salas_Click);
            // 
            // Txt_Name
            // 
            this.Txt_Name.BackColor = System.Drawing.Color.Transparent;
            this.Txt_Name.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.Txt_Name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.Txt_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Name.FocusedBaseColor = System.Drawing.Color.White;
            this.Txt_Name.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.Txt_Name.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Txt_Name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Name.ForeColor = System.Drawing.Color.White;
            this.Txt_Name.Location = new System.Drawing.Point(12, 241);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.PasswordChar = '\0';
            this.Txt_Name.Radius = 10;
            this.Txt_Name.SelectedText = "";
            this.Txt_Name.Size = new System.Drawing.Size(223, 50);
            this.Txt_Name.TabIndex = 49;
            this.Txt_Name.Text = "Buscar...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(163)))), ((int)(((byte)(226)))));
            this.label2.Location = new System.Drawing.Point(93, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(204)))), ((int)(((byte)(209)))));
            this.label1.Location = new System.Drawing.Point(93, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nelson Almendares";
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = global::Prime_Cinema.Properties.Resources.Profile_Logo;
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(27, 147);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(60, 60);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 0;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // Btn_CerrarSesion
            // 
            this.Btn_CerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_CerrarSesion.Animated = true;
            this.Btn_CerrarSesion.AnimationHoverSpeed = 0.09F;
            this.Btn_CerrarSesion.AnimationSpeed = 0.05F;
            this.Btn_CerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.Btn_CerrarSesion.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.Btn_CerrarSesion.BorderColor = System.Drawing.Color.Black;
            this.Btn_CerrarSesion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_CerrarSesion.FocusedColor = System.Drawing.Color.Empty;
            this.Btn_CerrarSesion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CerrarSesion.ForeColor = System.Drawing.Color.White;
            this.Btn_CerrarSesion.Image = global::Prime_Cinema.Properties.Resources.cerrar_sesion;
            this.Btn_CerrarSesion.ImageSize = new System.Drawing.Size(28, 28);
            this.Btn_CerrarSesion.Location = new System.Drawing.Point(14, 868);
            this.Btn_CerrarSesion.Name = "Btn_CerrarSesion";
            this.Btn_CerrarSesion.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(163)))), ((int)(((byte)(226)))));
            this.Btn_CerrarSesion.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(163)))), ((int)(((byte)(226)))));
            this.Btn_CerrarSesion.OnHoverForeColor = System.Drawing.Color.White;
            this.Btn_CerrarSesion.OnHoverImage = global::Prime_Cinema.Properties.Resources.cerrar_sesion;
            this.Btn_CerrarSesion.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(108)))), ((int)(((byte)(150)))));
            this.Btn_CerrarSesion.Radius = 10;
            this.Btn_CerrarSesion.Size = new System.Drawing.Size(280, 55);
            this.Btn_CerrarSesion.TabIndex = 9;
            this.Btn_CerrarSesion.Text = "CERRAR SESIÓN";
            this.Btn_CerrarSesion.Click += new System.EventHandler(this.Btn_CerrarSesion_Click);
            // 
            // gunaButton7
            // 
            this.gunaButton7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaButton7.Animated = true;
            this.gunaButton7.AnimationHoverSpeed = 0.09F;
            this.gunaButton7.AnimationSpeed = 0.05F;
            this.gunaButton7.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton7.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.gunaButton7.BorderColor = System.Drawing.Color.Black;
            this.gunaButton7.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton7.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton7.ForeColor = System.Drawing.Color.White;
            this.gunaButton7.Image = global::Prime_Cinema.Properties.Resources.soleado;
            this.gunaButton7.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaButton7.Location = new System.Drawing.Point(14, 938);
            this.gunaButton7.Margin = new System.Windows.Forms.Padding(1);
            this.gunaButton7.Name = "gunaButton7";
            this.gunaButton7.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(163)))), ((int)(((byte)(226)))));
            this.gunaButton7.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(163)))), ((int)(((byte)(226)))));
            this.gunaButton7.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton7.OnHoverImage = global::Prime_Cinema.Properties.Resources.soleado;
            this.gunaButton7.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(108)))), ((int)(((byte)(150)))));
            this.gunaButton7.Radius = 10;
            this.gunaButton7.Size = new System.Drawing.Size(280, 55);
            this.gunaButton7.TabIndex = 8;
            this.gunaButton7.Text = "Modo Oscuro";
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.gunaSeparator1.Location = new System.Drawing.Point(3, 834);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(305, 10);
            this.gunaSeparator1.TabIndex = 7;
            this.gunaSeparator1.Thickness = 3;
            // 
            // Btn_Perfil
            // 
            this.Btn_Perfil.Animated = true;
            this.Btn_Perfil.AnimationHoverSpeed = 0.09F;
            this.Btn_Perfil.AnimationSpeed = 0.05F;
            this.Btn_Perfil.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Perfil.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.Btn_Perfil.BorderColor = System.Drawing.Color.Black;
            this.Btn_Perfil.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_Perfil.FocusedColor = System.Drawing.Color.Empty;
            this.Btn_Perfil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Perfil.ForeColor = System.Drawing.Color.White;
            this.Btn_Perfil.Image = global::Prime_Cinema.Properties.Resources.usuario;
            this.Btn_Perfil.ImageSize = new System.Drawing.Size(25, 25);
            this.Btn_Perfil.Location = new System.Drawing.Point(12, 629);
            this.Btn_Perfil.Name = "Btn_Perfil";
            this.Btn_Perfil.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(163)))), ((int)(((byte)(226)))));
            this.Btn_Perfil.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(163)))), ((int)(((byte)(226)))));
            this.Btn_Perfil.OnHoverForeColor = System.Drawing.Color.White;
            this.Btn_Perfil.OnHoverImage = global::Prime_Cinema.Properties.Resources.rueda_dentada;
            this.Btn_Perfil.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(108)))), ((int)(((byte)(150)))));
            this.Btn_Perfil.Radius = 10;
            this.Btn_Perfil.Size = new System.Drawing.Size(280, 55);
            this.Btn_Perfil.TabIndex = 6;
            this.Btn_Perfil.Text = "Perfil";
            this.Btn_Perfil.Click += new System.EventHandler(this.Btn_Perfil_Click);
            // 
            // Btn_Sucursal
            // 
            this.Btn_Sucursal.Animated = true;
            this.Btn_Sucursal.AnimationHoverSpeed = 0.09F;
            this.Btn_Sucursal.AnimationSpeed = 0.05F;
            this.Btn_Sucursal.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Sucursal.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.Btn_Sucursal.BorderColor = System.Drawing.Color.Black;
            this.Btn_Sucursal.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_Sucursal.FocusedColor = System.Drawing.Color.Empty;
            this.Btn_Sucursal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Sucursal.ForeColor = System.Drawing.Color.White;
            this.Btn_Sucursal.Image = global::Prime_Cinema.Properties.Resources.billete;
            this.Btn_Sucursal.ImageSize = new System.Drawing.Size(25, 25);
            this.Btn_Sucursal.Location = new System.Drawing.Point(12, 406);
            this.Btn_Sucursal.Name = "Btn_Sucursal";
            this.Btn_Sucursal.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(163)))), ((int)(((byte)(226)))));
            this.Btn_Sucursal.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(163)))), ((int)(((byte)(226)))));
            this.Btn_Sucursal.OnHoverForeColor = System.Drawing.Color.White;
            this.Btn_Sucursal.OnHoverImage = global::Prime_Cinema.Properties.Resources.billete;
            this.Btn_Sucursal.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(108)))), ((int)(((byte)(150)))));
            this.Btn_Sucursal.Radius = 10;
            this.Btn_Sucursal.Size = new System.Drawing.Size(280, 55);
            this.Btn_Sucursal.TabIndex = 5;
            this.Btn_Sucursal.Text = "Sucursales";
            this.Btn_Sucursal.Click += new System.EventHandler(this.Btn_Sucursal_Click);
            // 
            // Btn_Peliculas
            // 
            this.Btn_Peliculas.Animated = true;
            this.Btn_Peliculas.AnimationHoverSpeed = 0.09F;
            this.Btn_Peliculas.AnimationSpeed = 0.05F;
            this.Btn_Peliculas.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Peliculas.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.Btn_Peliculas.BorderColor = System.Drawing.Color.Black;
            this.Btn_Peliculas.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_Peliculas.FocusedColor = System.Drawing.Color.Empty;
            this.Btn_Peliculas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Peliculas.ForeColor = System.Drawing.Color.White;
            this.Btn_Peliculas.Image = global::Prime_Cinema.Properties.Resources.camara_de_video_white;
            this.Btn_Peliculas.ImageSize = new System.Drawing.Size(25, 25);
            this.Btn_Peliculas.Location = new System.Drawing.Point(12, 481);
            this.Btn_Peliculas.Name = "Btn_Peliculas";
            this.Btn_Peliculas.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(163)))), ((int)(((byte)(226)))));
            this.Btn_Peliculas.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(163)))), ((int)(((byte)(226)))));
            this.Btn_Peliculas.OnHoverForeColor = System.Drawing.Color.White;
            this.Btn_Peliculas.OnHoverImage = global::Prime_Cinema.Properties.Resources.camara_de_video_white;
            this.Btn_Peliculas.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(108)))), ((int)(((byte)(150)))));
            this.Btn_Peliculas.Radius = 10;
            this.Btn_Peliculas.Size = new System.Drawing.Size(280, 55);
            this.Btn_Peliculas.TabIndex = 4;
            this.Btn_Peliculas.Text = "Películas";
            this.Btn_Peliculas.Click += new System.EventHandler(this.Btn_Peliculas_Click);
            // 
            // Btn_Register
            // 
            this.Btn_Register.Animated = true;
            this.Btn_Register.AnimationHoverSpeed = 0.09F;
            this.Btn_Register.AnimationSpeed = 0.05F;
            this.Btn_Register.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Register.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.Btn_Register.BorderColor = System.Drawing.Color.Black;
            this.Btn_Register.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_Register.FocusedColor = System.Drawing.Color.Empty;
            this.Btn_Register.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Register.ForeColor = System.Drawing.Color.White;
            this.Btn_Register.Image = global::Prime_Cinema.Properties.Resources.user;
            this.Btn_Register.ImageSize = new System.Drawing.Size(25, 25);
            this.Btn_Register.Location = new System.Drawing.Point(12, 331);
            this.Btn_Register.Name = "Btn_Register";
            this.Btn_Register.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(163)))), ((int)(((byte)(226)))));
            this.Btn_Register.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(163)))), ((int)(((byte)(226)))));
            this.Btn_Register.OnHoverForeColor = System.Drawing.Color.White;
            this.Btn_Register.OnHoverImage = global::Prime_Cinema.Properties.Resources.user;
            this.Btn_Register.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(108)))), ((int)(((byte)(150)))));
            this.Btn_Register.Radius = 10;
            this.Btn_Register.Size = new System.Drawing.Size(280, 55);
            this.Btn_Register.TabIndex = 2;
            this.Btn_Register.Text = "Clientes";
            this.Btn_Register.Click += new System.EventHandler(this.Btn_Register_Click);
            // 
            // gunaButton2
            // 
            this.gunaButton2.Animated = true;
            this.gunaButton2.AnimationHoverSpeed = 0.09F;
            this.gunaButton2.AnimationSpeed = 0.05F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = global::Prime_Cinema.Properties.Resources.aumentador_white;
            this.gunaButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton2.ImageSize = new System.Drawing.Size(22, 22);
            this.gunaButton2.Location = new System.Drawing.Point(241, 241);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(163)))), ((int)(((byte)(226)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(163)))), ((int)(((byte)(226)))));
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = global::Prime_Cinema.Properties.Resources.aumentador_white;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(108)))), ((int)(((byte)(150)))));
            this.gunaButton2.Radius = 10;
            this.gunaButton2.Size = new System.Drawing.Size(53, 50);
            this.gunaButton2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Prime_Cinema.Properties.Resources.logo_black;
            this.pictureBox1.Location = new System.Drawing.Point(27, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Panel_Superior
            // 
            this.Panel_Superior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Superior.BackColor = System.Drawing.Color.White;
            this.Panel_Superior.Controls.Add(this.Btn_Minimize);
            this.Panel_Superior.Controls.Add(this.Btn_Maximize);
            this.Panel_Superior.Controls.Add(this.Btn_Close);
            this.Panel_Superior.Location = new System.Drawing.Point(3, 0);
            this.Panel_Superior.Name = "Panel_Superior";
            this.Panel_Superior.Size = new System.Drawing.Size(1861, 43);
            this.Panel_Superior.TabIndex = 1;
            this.Panel_Superior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Superior_MouseDown);
            this.Panel_Superior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_Superior_MouseMove);
            this.Panel_Superior.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_Superior_MouseUp);
            // 
            // Btn_Minimize
            // 
            this.Btn_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Minimize.FlatAppearance.BorderSize = 0;
            this.Btn_Minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(167)))), ((int)(((byte)(173)))));
            this.Btn_Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(204)))), ((int)(((byte)(209)))));
            this.Btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Minimize.Image = global::Prime_Cinema.Properties.Resources.minimizar_signo;
            this.Btn_Minimize.Location = new System.Drawing.Point(1732, 3);
            this.Btn_Minimize.Name = "Btn_Minimize";
            this.Btn_Minimize.Size = new System.Drawing.Size(35, 34);
            this.Btn_Minimize.TabIndex = 4;
            this.Btn_Minimize.UseVisualStyleBackColor = true;
            this.Btn_Minimize.Click += new System.EventHandler(this.Btn_Minimize_Click);
            // 
            // Btn_Maximize
            // 
            this.Btn_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Maximize.FlatAppearance.BorderSize = 0;
            this.Btn_Maximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(167)))), ((int)(((byte)(173)))));
            this.Btn_Maximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(204)))), ((int)(((byte)(209)))));
            this.Btn_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Maximize.Image = global::Prime_Cinema.Properties.Resources.maximizar;
            this.Btn_Maximize.Location = new System.Drawing.Point(1773, 3);
            this.Btn_Maximize.Name = "Btn_Maximize";
            this.Btn_Maximize.Size = new System.Drawing.Size(35, 34);
            this.Btn_Maximize.TabIndex = 3;
            this.Btn_Maximize.UseVisualStyleBackColor = true;
            this.Btn_Maximize.Click += new System.EventHandler(this.Btn_Maximize_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Close.FlatAppearance.BorderSize = 0;
            this.Btn_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.Btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(96)))), ((int)(((byte)(108)))));
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Image = global::Prime_Cinema.Properties.Resources.cerrar;
            this.Btn_Close.Location = new System.Drawing.Point(1814, 3);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(35, 34);
            this.Btn_Close.TabIndex = 2;
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Panel_Container);
            this.panel1.Location = new System.Drawing.Point(308, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1556, 1011);
            this.panel1.TabIndex = 2;
            // 
            // Panel_Container
            // 
            this.Panel_Container.Location = new System.Drawing.Point(16, 22);
            this.Panel_Container.Name = "Panel_Container";
            this.Panel_Container.Size = new System.Drawing.Size(1523, 968);
            this.Panel_Container.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1864, 1054);
            this.Controls.Add(this.Panel_Lateral);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Panel_Superior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Panel_Lateral.ResumeLayout(false);
            this.Panel_Lateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Panel_Superior.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Lateral;
        private System.Windows.Forms.Panel Panel_Superior;
        private System.Windows.Forms.Button Btn_Minimize;
        private System.Windows.Forms.Button Btn_Maximize;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaButton Btn_Register;
        private Guna.UI.WinForms.GunaButton Btn_Salas;
        private Guna.UI.WinForms.GunaButton Btn_Perfil;
        private Guna.UI.WinForms.GunaButton Btn_Sucursal;
        private Guna.UI.WinForms.GunaButton Btn_Peliculas;
        private Guna.UI.WinForms.GunaButton gunaButton7;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaButton Btn_CerrarSesion;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Panel_Container;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaTextBox Txt_Name;
    }
}