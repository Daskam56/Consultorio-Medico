namespace HospitalBaseDeDatos
{
    partial class IniciarSesionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IniciarSesionForm));
            this.gradient1 = new HospitalBaseDeDatos.Gradient();
            this.ingresar_Btn = new System.Windows.Forms.Button();
            this.entrarAdmin_Btn = new System.Windows.Forms.Button();
            this.crearCuenta_Lbl = new System.Windows.Forms.Label();
            this.contraseña_Tbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usuario_Tbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gradient1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradient1
            // 
            this.gradient1.Angle = 285F;
            this.gradient1.BackColor = System.Drawing.Color.Snow;
            this.gradient1.BottomColor = System.Drawing.Color.Empty;
            this.gradient1.Controls.Add(this.ingresar_Btn);
            this.gradient1.Controls.Add(this.entrarAdmin_Btn);
            this.gradient1.Controls.Add(this.crearCuenta_Lbl);
            this.gradient1.Controls.Add(this.contraseña_Tbx);
            this.gradient1.Controls.Add(this.label4);
            this.gradient1.Controls.Add(this.label3);
            this.gradient1.Controls.Add(this.label2);
            this.gradient1.Controls.Add(this.usuario_Tbx);
            this.gradient1.Controls.Add(this.label1);
            this.gradient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradient1.Location = new System.Drawing.Point(0, 0);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(437, 292);
            this.gradient1.TabIndex = 0;
            this.gradient1.TopColor = System.Drawing.Color.PaleTurquoise;
            // 
            // ingresar_Btn
            // 
            this.ingresar_Btn.BackColor = System.Drawing.Color.Transparent;
            this.ingresar_Btn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.ingresar_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.ingresar_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.ingresar_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ingresar_Btn.Location = new System.Drawing.Point(122, 217);
            this.ingresar_Btn.Name = "ingresar_Btn";
            this.ingresar_Btn.Size = new System.Drawing.Size(75, 23);
            this.ingresar_Btn.TabIndex = 27;
            this.ingresar_Btn.Text = "Ingresar";
            this.ingresar_Btn.UseVisualStyleBackColor = false;
            this.ingresar_Btn.Click += new System.EventHandler(this.ingresar_Btn_Click);
            // 
            // entrarAdmin_Btn
            // 
            this.entrarAdmin_Btn.BackColor = System.Drawing.Color.Transparent;
            this.entrarAdmin_Btn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.entrarAdmin_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.entrarAdmin_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.entrarAdmin_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entrarAdmin_Btn.Location = new System.Drawing.Point(238, 217);
            this.entrarAdmin_Btn.Name = "entrarAdmin_Btn";
            this.entrarAdmin_Btn.Size = new System.Drawing.Size(146, 23);
            this.entrarAdmin_Btn.TabIndex = 26;
            this.entrarAdmin_Btn.Text = "Entrar como Administrador";
            this.entrarAdmin_Btn.UseVisualStyleBackColor = false;
            this.entrarAdmin_Btn.Click += new System.EventHandler(this.entrarAdmin_Btn_Click);
            // 
            // crearCuenta_Lbl
            // 
            this.crearCuenta_Lbl.AutoSize = true;
            this.crearCuenta_Lbl.BackColor = System.Drawing.Color.Transparent;
            this.crearCuenta_Lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.crearCuenta_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crearCuenta_Lbl.ForeColor = System.Drawing.Color.Navy;
            this.crearCuenta_Lbl.Location = new System.Drawing.Point(119, 255);
            this.crearCuenta_Lbl.Name = "crearCuenta_Lbl";
            this.crearCuenta_Lbl.Size = new System.Drawing.Size(223, 16);
            this.crearCuenta_Lbl.TabIndex = 25;
            this.crearCuenta_Lbl.Text = "Haz click aquí para crear una cuenta";
            this.crearCuenta_Lbl.Click += new System.EventHandler(this.crearCuenta_Lbl_Click);
            // 
            // contraseña_Tbx
            // 
            this.contraseña_Tbx.Location = new System.Drawing.Point(164, 167);
            this.contraseña_Tbx.MaxLength = 15;
            this.contraseña_Tbx.Name = "contraseña_Tbx";
            this.contraseña_Tbx.Size = new System.Drawing.Size(158, 20);
            this.contraseña_Tbx.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Inicia sesión";
            // 
            // usuario_Tbx
            // 
            this.usuario_Tbx.Location = new System.Drawing.Point(164, 103);
            this.usuario_Tbx.Name = "usuario_Tbx";
            this.usuario_Tbx.Size = new System.Drawing.Size(158, 20);
            this.usuario_Tbx.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "¡Bienvenido!";
            // 
            // IniciarSesionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(437, 292);
            this.Controls.Add(this.gradient1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "IniciarSesionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar sesión";
            this.gradient1.ResumeLayout(false);
            this.gradient1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Gradient gradient1;
        private System.Windows.Forms.Button entrarAdmin_Btn;
        private System.Windows.Forms.Label crearCuenta_Lbl;
        private System.Windows.Forms.TextBox contraseña_Tbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usuario_Tbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ingresar_Btn;
    }
}

