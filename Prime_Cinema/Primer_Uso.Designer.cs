
namespace Prime_Cinema
{
    partial class Primer_Uso
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
            this.Btn_Minimize = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.Label();
            this.Message = new System.Windows.Forms.Label();
            this.Btn_Login = new Guna.UI.WinForms.GunaButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Minimize);
            this.panel1.Controls.Add(this.Btn_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 40);
            this.panel1.TabIndex = 0;
            // 
            // Btn_Minimize
            // 
            this.Btn_Minimize.FlatAppearance.BorderSize = 0;
            this.Btn_Minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(167)))), ((int)(((byte)(173)))));
            this.Btn_Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(204)))), ((int)(((byte)(209)))));
            this.Btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Minimize.Image = global::Prime_Cinema.Properties.Resources.minimizar_signo;
            this.Btn_Minimize.Location = new System.Drawing.Point(483, 3);
            this.Btn_Minimize.Name = "Btn_Minimize";
            this.Btn_Minimize.Size = new System.Drawing.Size(35, 34);
            this.Btn_Minimize.TabIndex = 3;
            this.Btn_Minimize.UseVisualStyleBackColor = true;
            // 
            // Btn_Close
            // 
            this.Btn_Close.FlatAppearance.BorderSize = 0;
            this.Btn_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.Btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(96)))), ((int)(((byte)(108)))));
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Image = global::Prime_Cinema.Properties.Resources.cerrar;
            this.Btn_Close.Location = new System.Drawing.Point(524, 3);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(35, 34);
            this.Btn_Close.TabIndex = 2;
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Prime_Cinema.Properties.Resources.undraw_welcoming_re_x0qo;
            this.pictureBox1.Location = new System.Drawing.Point(112, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 343);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "¡Binvenido!";
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info.Location = new System.Drawing.Point(157, 643);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(219, 25);
            this.Info.TabIndex = 3;
            this.Info.Text = "Verificando sistema...";
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message.Location = new System.Drawing.Point(120, 677);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(310, 25);
            this.Message.TabIndex = 4;
            this.Message.Text = "Creando las mejores soluciones....";
            // 
            // Btn_Login
            // 
            this.Btn_Login.Animated = true;
            this.Btn_Login.AnimationHoverSpeed = 0.09F;
            this.Btn_Login.AnimationSpeed = 0.05F;
            this.Btn_Login.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Login.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.Btn_Login.BorderColor = System.Drawing.Color.Black;
            this.Btn_Login.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_Login.FocusedColor = System.Drawing.Color.Empty;
            this.Btn_Login.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Login.ForeColor = System.Drawing.Color.White;
            this.Btn_Login.Image = null;
            this.Btn_Login.ImageSize = new System.Drawing.Size(20, 20);
            this.Btn_Login.Location = new System.Drawing.Point(112, 771);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(193)))), ((int)(((byte)(235)))));
            this.Btn_Login.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Btn_Login.OnHoverForeColor = System.Drawing.Color.Black;
            this.Btn_Login.OnHoverImage = null;
            this.Btn_Login.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(163)))), ((int)(((byte)(226)))));
            this.Btn_Login.OnPressedDepth = 90;
            this.Btn_Login.Radius = 15;
            this.Btn_Login.Size = new System.Drawing.Size(318, 60);
            this.Btn_Login.TabIndex = 8;
            this.Btn_Login.Text = "Ingresar";
            this.Btn_Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Primer_Uso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 884);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Primer_Uso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Primer_Uso";
            this.Load += new System.EventHandler(this.Primer_Uso_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Minimize;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Label Message;
        private Guna.UI.WinForms.GunaButton Btn_Login;
    }
}