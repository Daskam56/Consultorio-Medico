namespace HospitalBaseDeDatos
{
    partial class PantallaPrincipalDoctorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipalDoctorForm));
            this.gradient1 = new HospitalBaseDeDatos.Gradient();
            this.horario_Btn = new System.Windows.Forms.Button();
            this.citas_Btn = new System.Windows.Forms.Button();
            this.pacientes_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gradient1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradient1
            // 
            this.gradient1.Angle = 285F;
            this.gradient1.BackColor = System.Drawing.Color.Snow;
            this.gradient1.BottomColor = System.Drawing.Color.Empty;
            this.gradient1.Controls.Add(this.horario_Btn);
            this.gradient1.Controls.Add(this.citas_Btn);
            this.gradient1.Controls.Add(this.pacientes_Btn);
            this.gradient1.Controls.Add(this.label1);
            this.gradient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradient1.Location = new System.Drawing.Point(0, 0);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(800, 450);
            this.gradient1.TabIndex = 0;
            this.gradient1.TopColor = System.Drawing.Color.PaleTurquoise;
            // 
            // horario_Btn
            // 
            this.horario_Btn.BackColor = System.Drawing.Color.Transparent;
            this.horario_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.horario_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.horario_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.horario_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.horario_Btn.ForeColor = System.Drawing.Color.IndianRed;
            this.horario_Btn.Image = ((System.Drawing.Image)(resources.GetObject("horario_Btn.Image")));
            this.horario_Btn.Location = new System.Drawing.Point(307, 63);
            this.horario_Btn.Name = "horario_Btn";
            this.horario_Btn.Size = new System.Drawing.Size(181, 335);
            this.horario_Btn.TabIndex = 15;
            this.horario_Btn.Text = "Horario";
            this.horario_Btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.horario_Btn.UseVisualStyleBackColor = false;
            this.horario_Btn.Click += new System.EventHandler(this.horario_Btn_Click);
            // 
            // citas_Btn
            // 
            this.citas_Btn.BackColor = System.Drawing.Color.Transparent;
            this.citas_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(137)))), ((int)(((byte)(94)))));
            this.citas_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(164)))), ((int)(((byte)(113)))));
            this.citas_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(137)))), ((int)(((byte)(94)))));
            this.citas_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.citas_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(82)))), ((int)(((byte)(56)))));
            this.citas_Btn.Image = ((System.Drawing.Image)(resources.GetObject("citas_Btn.Image")));
            this.citas_Btn.Location = new System.Drawing.Point(532, 63);
            this.citas_Btn.Name = "citas_Btn";
            this.citas_Btn.Size = new System.Drawing.Size(181, 335);
            this.citas_Btn.TabIndex = 14;
            this.citas_Btn.Text = "Citas";
            this.citas_Btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.citas_Btn.UseVisualStyleBackColor = false;
            this.citas_Btn.Click += new System.EventHandler(this.citas_Btn_Click);
            // 
            // pacientes_Btn
            // 
            this.pacientes_Btn.BackColor = System.Drawing.Color.Transparent;
            this.pacientes_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(115)))), ((int)(((byte)(134)))));
            this.pacientes_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(150)))), ((int)(((byte)(164)))));
            this.pacientes_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(115)))), ((int)(((byte)(134)))));
            this.pacientes_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pacientes_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(79)))), ((int)(((byte)(93)))));
            this.pacientes_Btn.Image = ((System.Drawing.Image)(resources.GetObject("pacientes_Btn.Image")));
            this.pacientes_Btn.Location = new System.Drawing.Point(90, 63);
            this.pacientes_Btn.Name = "pacientes_Btn";
            this.pacientes_Btn.Size = new System.Drawing.Size(181, 335);
            this.pacientes_Btn.TabIndex = 13;
            this.pacientes_Btn.Text = "Pacientes";
            this.pacientes_Btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pacientes_Btn.UseVisualStyleBackColor = false;
            this.pacientes_Btn.Click += new System.EventHandler(this.pacientes_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "¡Bienvenido doctor!";
            // 
            // PantallaPrincipalDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gradient1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PantallaPrincipalDoctorForm";
            this.Text = "Hospital";
            this.gradient1.ResumeLayout(false);
            this.gradient1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Gradient gradient1;
        private System.Windows.Forms.Button horario_Btn;
        private System.Windows.Forms.Button citas_Btn;
        private System.Windows.Forms.Button pacientes_Btn;
        private System.Windows.Forms.Label label1;
    }
}