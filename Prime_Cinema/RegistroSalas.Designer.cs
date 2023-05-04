
namespace Prime_Cinema
{
    partial class RegistroSalas
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
            this.label2 = new System.Windows.Forms.Label();
            this.data_Salas = new System.Windows.Forms.DataGridView();
            this.Btn_Register = new Guna.UI.WinForms.GunaButton();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_Horario = new Guna.UI.WinForms.GunaComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Txt_Sala = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cmb_Peli = new Guna.UI.WinForms.GunaComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Salas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1523, 53);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(163)))), ((int)(((byte)(226)))));
            this.label1.Location = new System.Drawing.Point(209, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Registro de Salas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(31, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Prime Cinema  >";
            // 
            // data_Salas
            // 
            this.data_Salas.AllowUserToAddRows = false;
            this.data_Salas.AllowUserToDeleteRows = false;
            this.data_Salas.AllowUserToResizeRows = false;
            this.data_Salas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_Salas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_Salas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Salas.Location = new System.Drawing.Point(36, 607);
            this.data_Salas.Name = "data_Salas";
            this.data_Salas.RowHeadersWidth = 51;
            this.data_Salas.RowTemplate.Height = 24;
            this.data_Salas.Size = new System.Drawing.Size(1449, 332);
            this.data_Salas.TabIndex = 38;
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
            this.Btn_Register.Location = new System.Drawing.Point(36, 536);
            this.Btn_Register.Name = "Btn_Register";
            this.Btn_Register.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(193)))), ((int)(((byte)(235)))));
            this.Btn_Register.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Btn_Register.OnHoverForeColor = System.Drawing.Color.White;
            this.Btn_Register.OnHoverImage = null;
            this.Btn_Register.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(108)))), ((int)(((byte)(150)))));
            this.Btn_Register.OnPressedDepth = 90;
            this.Btn_Register.Radius = 15;
            this.Btn_Register.Size = new System.Drawing.Size(235, 49);
            this.Btn_Register.TabIndex = 39;
            this.Btn_Register.Text = "Agregar";
            this.Btn_Register.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btn_Register.Click += new System.EventHandler(this.Btn_Register_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(60, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 29);
            this.label8.TabIndex = 45;
            this.label8.Text = "Horario:";
            // 
            // cmb_Horario
            // 
            this.cmb_Horario.BackColor = System.Drawing.Color.Transparent;
            this.cmb_Horario.BaseColor = System.Drawing.Color.White;
            this.cmb_Horario.BorderColor = System.Drawing.Color.Silver;
            this.cmb_Horario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_Horario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Horario.FocusedColor = System.Drawing.Color.Empty;
            this.cmb_Horario.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Horario.ForeColor = System.Drawing.Color.Black;
            this.cmb_Horario.FormattingEnabled = true;
            this.cmb_Horario.Location = new System.Drawing.Point(36, 296);
            this.cmb_Horario.Name = "cmb_Horario";
            this.cmb_Horario.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmb_Horario.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmb_Horario.Radius = 10;
            this.cmb_Horario.Size = new System.Drawing.Size(496, 37);
            this.cmb_Horario.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(60, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 29);
            this.label10.TabIndex = 47;
            this.label10.Text = "Número Sala:";
            // 
            // Txt_Sala
            // 
            this.Txt_Sala.BackColor = System.Drawing.Color.Transparent;
            this.Txt_Sala.BaseColor = System.Drawing.Color.White;
            this.Txt_Sala.BorderColor = System.Drawing.Color.Silver;
            this.Txt_Sala.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Sala.FocusedBaseColor = System.Drawing.Color.White;
            this.Txt_Sala.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.Txt_Sala.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Txt_Sala.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Sala.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.Txt_Sala.Location = new System.Drawing.Point(36, 171);
            this.Txt_Sala.Name = "Txt_Sala";
            this.Txt_Sala.PasswordChar = '\0';
            this.Txt_Sala.Radius = 10;
            this.Txt_Sala.SelectedText = "";
            this.Txt_Sala.Size = new System.Drawing.Size(496, 40);
            this.Txt_Sala.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 29);
            this.label3.TabIndex = 49;
            this.label3.Text = "Película:";
            // 
            // Cmb_Peli
            // 
            this.Cmb_Peli.BackColor = System.Drawing.Color.Transparent;
            this.Cmb_Peli.BaseColor = System.Drawing.Color.White;
            this.Cmb_Peli.BorderColor = System.Drawing.Color.Silver;
            this.Cmb_Peli.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cmb_Peli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Peli.FocusedColor = System.Drawing.Color.Empty;
            this.Cmb_Peli.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Peli.ForeColor = System.Drawing.Color.Black;
            this.Cmb_Peli.FormattingEnabled = true;
            this.Cmb_Peli.Location = new System.Drawing.Point(36, 425);
            this.Cmb_Peli.Name = "Cmb_Peli";
            this.Cmb_Peli.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Cmb_Peli.OnHoverItemForeColor = System.Drawing.Color.White;
            this.Cmb_Peli.Radius = 10;
            this.Cmb_Peli.Size = new System.Drawing.Size(496, 37);
            this.Cmb_Peli.TabIndex = 48;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Prime_Cinema.Properties.Resources.undraw_horror_movie_3988;
            this.pictureBox1.Location = new System.Drawing.Point(875, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(555, 487);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
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
            this.Btn_Close.Location = new System.Drawing.Point(1476, 59);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(35, 34);
            this.Btn_Close.TabIndex = 19;
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // RegistroSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1523, 968);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cmb_Peli);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Txt_Sala);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmb_Horario);
            this.Controls.Add(this.Btn_Register);
            this.Controls.Add(this.data_Salas);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroSalas";
            this.Text = "RegistroSalas";
            this.Load += new System.EventHandler(this.RegistroSalas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Salas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.DataGridView data_Salas;
        private Guna.UI.WinForms.GunaButton Btn_Register;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaComboBox cmb_Horario;
        private System.Windows.Forms.Label label10;
        private Guna.UI.WinForms.GunaTextBox Txt_Sala;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaComboBox Cmb_Peli;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}