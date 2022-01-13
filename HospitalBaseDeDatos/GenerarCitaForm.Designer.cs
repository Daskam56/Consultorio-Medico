namespace HospitalBaseDeDatos
{
    partial class GenerarCitaForm
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
            this.gradient1 = new HospitalBaseDeDatos.Gradient();
            this.fechaCita_Dp = new System.Windows.Forms.DateTimePicker();
            this.expediente_Tbx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.claveDoctor_Tbx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.horaFinCita_Tbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inicioCita_Tbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guardar_Btn = new System.Windows.Forms.Button();
            this.gradient1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradient1
            // 
            this.gradient1.Angle = 285F;
            this.gradient1.BackColor = System.Drawing.Color.Snow;
            this.gradient1.BottomColor = System.Drawing.Color.Empty;
            this.gradient1.Controls.Add(this.fechaCita_Dp);
            this.gradient1.Controls.Add(this.expediente_Tbx);
            this.gradient1.Controls.Add(this.label6);
            this.gradient1.Controls.Add(this.claveDoctor_Tbx);
            this.gradient1.Controls.Add(this.label5);
            this.gradient1.Controls.Add(this.horaFinCita_Tbx);
            this.gradient1.Controls.Add(this.label4);
            this.gradient1.Controls.Add(this.inicioCita_Tbx);
            this.gradient1.Controls.Add(this.label3);
            this.gradient1.Controls.Add(this.label2);
            this.gradient1.Controls.Add(this.label1);
            this.gradient1.Controls.Add(this.guardar_Btn);
            this.gradient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradient1.Location = new System.Drawing.Point(0, 0);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(412, 349);
            this.gradient1.TabIndex = 0;
            this.gradient1.TopColor = System.Drawing.Color.PaleTurquoise;
            // 
            // fechaCita_Dp
            // 
            this.fechaCita_Dp.Location = new System.Drawing.Point(165, 83);
            this.fechaCita_Dp.Name = "fechaCita_Dp";
            this.fechaCita_Dp.Size = new System.Drawing.Size(210, 20);
            this.fechaCita_Dp.TabIndex = 116;
            // 
            // expediente_Tbx
            // 
            this.expediente_Tbx.Location = new System.Drawing.Point(165, 239);
            this.expediente_Tbx.Name = "expediente_Tbx";
            this.expediente_Tbx.Size = new System.Drawing.Size(210, 20);
            this.expediente_Tbx.TabIndex = 115;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(37, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 114;
            this.label6.Text = "Expediente";
            // 
            // claveDoctor_Tbx
            // 
            this.claveDoctor_Tbx.Location = new System.Drawing.Point(165, 199);
            this.claveDoctor_Tbx.Name = "claveDoctor_Tbx";
            this.claveDoctor_Tbx.Size = new System.Drawing.Size(210, 20);
            this.claveDoctor_Tbx.TabIndex = 113;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(37, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 112;
            this.label5.Text = "Clave del doctor";
            // 
            // horaFinCita_Tbx
            // 
            this.horaFinCita_Tbx.Location = new System.Drawing.Point(165, 162);
            this.horaFinCita_Tbx.MaxLength = 5;
            this.horaFinCita_Tbx.Name = "horaFinCita_Tbx";
            this.horaFinCita_Tbx.Size = new System.Drawing.Size(210, 20);
            this.horaFinCita_Tbx.TabIndex = 111;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(37, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 110;
            this.label4.Text = "Hora aproximada de fin";
            // 
            // inicioCita_Tbx
            // 
            this.inicioCita_Tbx.Location = new System.Drawing.Point(165, 122);
            this.inicioCita_Tbx.MaxLength = 5;
            this.inicioCita_Tbx.Name = "inicioCita_Tbx";
            this.inicioCita_Tbx.Size = new System.Drawing.Size(210, 20);
            this.inicioCita_Tbx.TabIndex = 109;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(37, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 108;
            this.label3.Text = "Hora de inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 107;
            this.label2.Text = "Generar cita";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(37, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 106;
            this.label1.Text = "Fecha";
            // 
            // guardar_Btn
            // 
            this.guardar_Btn.BackColor = System.Drawing.Color.Transparent;
            this.guardar_Btn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.guardar_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.guardar_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.guardar_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardar_Btn.Location = new System.Drawing.Point(270, 301);
            this.guardar_Btn.Name = "guardar_Btn";
            this.guardar_Btn.Size = new System.Drawing.Size(105, 23);
            this.guardar_Btn.TabIndex = 105;
            this.guardar_Btn.Text = "Guardar";
            this.guardar_Btn.UseVisualStyleBackColor = false;
            this.guardar_Btn.Click += new System.EventHandler(this.guardar_Btn_Click);
            // 
            // GenerarCitaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 349);
            this.Controls.Add(this.gradient1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GenerarCitaForm";
            this.Text = "Generar una cita";
            this.gradient1.ResumeLayout(false);
            this.gradient1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Gradient gradient1;
        private System.Windows.Forms.DateTimePicker fechaCita_Dp;
        private System.Windows.Forms.TextBox expediente_Tbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox claveDoctor_Tbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox horaFinCita_Tbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inicioCita_Tbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button guardar_Btn;
    }
}