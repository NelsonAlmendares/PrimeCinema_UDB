
namespace Prime_Cinema
{
    partial class Registro_Sucursales
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Register = new Guna.UI.WinForms.GunaButton();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_Sucursal = new Guna.UI.WinForms.GunaTextBox();
            this.Txt_Gerente = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Direccion = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.data_Sucursales = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Txt_Telefono = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_Sala = new Guna.UI.WinForms.GunaComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Sucursales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1523, 54);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(163)))), ((int)(((byte)(226)))));
            this.label1.Location = new System.Drawing.Point(196, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 29);
            this.label1.TabIndex = 50;
            this.label1.Text = "Registro de Sucursales";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(18, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 29);
            this.label3.TabIndex = 49;
            this.label3.Text = "Prime Cinema  >";
            // 
            // Btn_Register
            // 
            this.Btn_Register.Animated = true;
            this.Btn_Register.AnimationHoverSpeed = 0.09F;
            this.Btn_Register.AnimationSpeed = 0.05F;
            this.Btn_Register.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Register.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(163)))), ((int)(((byte)(226)))));
            this.Btn_Register.BorderColor = System.Drawing.Color.Black;
            this.Btn_Register.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_Register.FocusedColor = System.Drawing.Color.Empty;
            this.Btn_Register.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Register.ForeColor = System.Drawing.Color.White;
            this.Btn_Register.Image = null;
            this.Btn_Register.ImageSize = new System.Drawing.Size(20, 20);
            this.Btn_Register.Location = new System.Drawing.Point(49, 538);
            this.Btn_Register.Name = "Btn_Register";
            this.Btn_Register.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(193)))), ((int)(((byte)(235)))));
            this.Btn_Register.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Btn_Register.OnHoverForeColor = System.Drawing.Color.White;
            this.Btn_Register.OnHoverImage = null;
            this.Btn_Register.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(108)))), ((int)(((byte)(150)))));
            this.Btn_Register.OnPressedDepth = 90;
            this.Btn_Register.Radius = 15;
            this.Btn_Register.Size = new System.Drawing.Size(257, 49);
            this.Btn_Register.TabIndex = 23;
            this.Btn_Register.Text = "Registrar";
            this.Btn_Register.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btn_Register.Click += new System.EventHandler(this.Btn_Register_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(44, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 29);
            this.label8.TabIndex = 34;
            this.label8.Text = "Nombre Sucursal:";
            // 
            // Txt_Sucursal
            // 
            this.Txt_Sucursal.BackColor = System.Drawing.Color.Transparent;
            this.Txt_Sucursal.BaseColor = System.Drawing.Color.White;
            this.Txt_Sucursal.BorderColor = System.Drawing.Color.Silver;
            this.Txt_Sucursal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Sucursal.FocusedBaseColor = System.Drawing.Color.White;
            this.Txt_Sucursal.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.Txt_Sucursal.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Txt_Sucursal.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Sucursal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.Txt_Sucursal.Location = new System.Drawing.Point(49, 127);
            this.Txt_Sucursal.Name = "Txt_Sucursal";
            this.Txt_Sucursal.PasswordChar = '\0';
            this.Txt_Sucursal.Radius = 10;
            this.Txt_Sucursal.SelectedText = "";
            this.Txt_Sucursal.Size = new System.Drawing.Size(496, 40);
            this.Txt_Sucursal.TabIndex = 48;
            // 
            // Txt_Gerente
            // 
            this.Txt_Gerente.BackColor = System.Drawing.Color.Transparent;
            this.Txt_Gerente.BaseColor = System.Drawing.Color.White;
            this.Txt_Gerente.BorderColor = System.Drawing.Color.Silver;
            this.Txt_Gerente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Gerente.FocusedBaseColor = System.Drawing.Color.White;
            this.Txt_Gerente.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.Txt_Gerente.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Txt_Gerente.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Gerente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.Txt_Gerente.Location = new System.Drawing.Point(49, 231);
            this.Txt_Gerente.Name = "Txt_Gerente";
            this.Txt_Gerente.PasswordChar = '\0';
            this.Txt_Gerente.Radius = 10;
            this.Txt_Gerente.SelectedText = "";
            this.Txt_Gerente.Size = new System.Drawing.Size(496, 40);
            this.Txt_Gerente.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 29);
            this.label2.TabIndex = 49;
            this.label2.Text = "Gerente de Sucursal:";
            // 
            // Txt_Direccion
            // 
            this.Txt_Direccion.BackColor = System.Drawing.Color.Transparent;
            this.Txt_Direccion.BaseColor = System.Drawing.Color.White;
            this.Txt_Direccion.BorderColor = System.Drawing.Color.Silver;
            this.Txt_Direccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Direccion.FocusedBaseColor = System.Drawing.Color.White;
            this.Txt_Direccion.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.Txt_Direccion.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Txt_Direccion.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Direccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.Txt_Direccion.Location = new System.Drawing.Point(49, 351);
            this.Txt_Direccion.Name = "Txt_Direccion";
            this.Txt_Direccion.PasswordChar = '\0';
            this.Txt_Direccion.Radius = 10;
            this.Txt_Direccion.SelectedText = "";
            this.Txt_Direccion.Size = new System.Drawing.Size(496, 40);
            this.Txt_Direccion.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 29);
            this.label4.TabIndex = 51;
            this.label4.Text = "Dirección de Sucursal:";
            // 
            // data_Sucursales
            // 
            this.data_Sucursales.AllowUserToAddRows = false;
            this.data_Sucursales.AllowUserToDeleteRows = false;
            this.data_Sucursales.AllowUserToResizeRows = false;
            this.data_Sucursales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_Sucursales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_Sucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Sucursales.Location = new System.Drawing.Point(23, 610);
            this.data_Sucursales.Name = "data_Sucursales";
            this.data_Sucursales.RowHeadersWidth = 51;
            this.data_Sucursales.RowTemplate.Height = 24;
            this.data_Sucursales.Size = new System.Drawing.Size(1470, 332);
            this.data_Sucursales.TabIndex = 53;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Prime_Cinema.Properties.Resources.undraw_transfer_files_re_a2a9;
            this.pictureBox1.Location = new System.Drawing.Point(850, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(629, 440);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Close
            // 
            this.Btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Close.FlatAppearance.BorderSize = 0;
            this.Btn_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.Btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(96)))), ((int)(((byte)(108)))));
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Image = global::Prime_Cinema.Properties.Resources.cerrar;
            this.Btn_Close.Location = new System.Drawing.Point(1476, 60);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(35, 34);
            this.Btn_Close.TabIndex = 5;
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Txt_Telefono
            // 
            this.Txt_Telefono.BackColor = System.Drawing.Color.Transparent;
            this.Txt_Telefono.BaseColor = System.Drawing.Color.White;
            this.Txt_Telefono.BorderColor = System.Drawing.Color.Silver;
            this.Txt_Telefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Telefono.FocusedBaseColor = System.Drawing.Color.White;
            this.Txt_Telefono.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.Txt_Telefono.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Txt_Telefono.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Telefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.Txt_Telefono.Location = new System.Drawing.Point(49, 465);
            this.Txt_Telefono.Name = "Txt_Telefono";
            this.Txt_Telefono.PasswordChar = '\0';
            this.Txt_Telefono.Radius = 10;
            this.Txt_Telefono.SelectedText = "";
            this.Txt_Telefono.Size = new System.Drawing.Size(496, 40);
            this.Txt_Telefono.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 29);
            this.label6.TabIndex = 57;
            this.label6.Text = "Teléfono de la Sucursal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(574, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 29);
            this.label5.TabIndex = 60;
            this.label5.Text = "Sala:";
            // 
            // cmb_Sala
            // 
            this.cmb_Sala.BackColor = System.Drawing.Color.Transparent;
            this.cmb_Sala.BaseColor = System.Drawing.Color.White;
            this.cmb_Sala.BorderColor = System.Drawing.Color.Silver;
            this.cmb_Sala.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_Sala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Sala.FocusedColor = System.Drawing.Color.Empty;
            this.cmb_Sala.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Sala.ForeColor = System.Drawing.Color.Black;
            this.cmb_Sala.FormattingEnabled = true;
            this.cmb_Sala.Location = new System.Drawing.Point(579, 127);
            this.cmb_Sala.Name = "cmb_Sala";
            this.cmb_Sala.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmb_Sala.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmb_Sala.Radius = 10;
            this.cmb_Sala.Size = new System.Drawing.Size(236, 37);
            this.cmb_Sala.TabIndex = 59;
            // 
            // Registro_Sucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1523, 968);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_Sala);
            this.Controls.Add(this.Txt_Telefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.data_Sucursales);
            this.Controls.Add(this.Txt_Direccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_Gerente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Sucursal);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Btn_Register);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro_Sucursales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Registro_Sucursales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Sucursales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Close;
        private Guna.UI.WinForms.GunaButton Btn_Register;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaTextBox Txt_Sucursal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox Txt_Gerente;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox Txt_Direccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView data_Sucursales;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaTextBox Txt_Telefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaComboBox cmb_Sala;
    }
}