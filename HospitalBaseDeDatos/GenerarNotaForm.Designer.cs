namespace HospitalBaseDeDatos
{
    partial class GenerarNotaForm
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
            this.nota_Tbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fechaNota_DP = new System.Windows.Forms.DateTimePicker();
            this.guardar_Btn = new System.Windows.Forms.Button();
            this.expediente_Tbx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.medicamento_Tbx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cancelar_Btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gradient1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradient1
            // 
            this.gradient1.Angle = 285F;
            this.gradient1.BackColor = System.Drawing.Color.Snow;
            this.gradient1.BottomColor = System.Drawing.Color.Empty;
            this.gradient1.Controls.Add(this.nota_Tbx);
            this.gradient1.Controls.Add(this.label2);
            this.gradient1.Controls.Add(this.fechaNota_DP);
            this.gradient1.Controls.Add(this.guardar_Btn);
            this.gradient1.Controls.Add(this.expediente_Tbx);
            this.gradient1.Controls.Add(this.label7);
            this.gradient1.Controls.Add(this.medicamento_Tbx);
            this.gradient1.Controls.Add(this.label6);
            this.gradient1.Controls.Add(this.cancelar_Btn);
            this.gradient1.Controls.Add(this.label5);
            this.gradient1.Controls.Add(this.label12);
            this.gradient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradient1.Location = new System.Drawing.Point(0, 0);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(407, 342);
            this.gradient1.TabIndex = 0;
            this.gradient1.TopColor = System.Drawing.Color.PaleTurquoise;
            // 
            // nota_Tbx
            // 
            this.nota_Tbx.Location = new System.Drawing.Point(135, 189);
            this.nota_Tbx.MaxLength = 200;
            this.nota_Tbx.Multiline = true;
            this.nota_Tbx.Name = "nota_Tbx";
            this.nota_Tbx.Size = new System.Drawing.Size(210, 72);
            this.nota_Tbx.TabIndex = 103;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 24);
            this.label2.TabIndex = 95;
            this.label2.Text = "Reporte de cita";
            // 
            // fechaNota_DP
            // 
            this.fechaNota_DP.Location = new System.Drawing.Point(135, 107);
            this.fechaNota_DP.Name = "fechaNota_DP";
            this.fechaNota_DP.Size = new System.Drawing.Size(210, 20);
            this.fechaNota_DP.TabIndex = 102;
            this.fechaNota_DP.Value = new System.DateTime(2022, 1, 6, 23, 9, 59, 0);
            // 
            // guardar_Btn
            // 
            this.guardar_Btn.BackColor = System.Drawing.Color.Transparent;
            this.guardar_Btn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.guardar_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.guardar_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.guardar_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardar_Btn.Location = new System.Drawing.Point(66, 283);
            this.guardar_Btn.Name = "guardar_Btn";
            this.guardar_Btn.Size = new System.Drawing.Size(105, 23);
            this.guardar_Btn.TabIndex = 94;
            this.guardar_Btn.Text = "Guardar";
            this.guardar_Btn.UseVisualStyleBackColor = false;
            this.guardar_Btn.Click += new System.EventHandler(this.guardar_Btn_Click);
            // 
            // expediente_Tbx
            // 
            this.expediente_Tbx.Location = new System.Drawing.Point(135, 72);
            this.expediente_Tbx.Name = "expediente_Tbx";
            this.expediente_Tbx.Size = new System.Drawing.Size(210, 20);
            this.expediente_Tbx.TabIndex = 101;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(45, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 99;
            this.label7.Text = "Nota";
            // 
            // medicamento_Tbx
            // 
            this.medicamento_Tbx.Location = new System.Drawing.Point(135, 146);
            this.medicamento_Tbx.MaxLength = 40;
            this.medicamento_Tbx.Name = "medicamento_Tbx";
            this.medicamento_Tbx.Size = new System.Drawing.Size(210, 20);
            this.medicamento_Tbx.TabIndex = 98;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(45, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 97;
            this.label6.Text = "Medicamento";
            // 
            // cancelar_Btn
            // 
            this.cancelar_Btn.BackColor = System.Drawing.Color.Transparent;
            this.cancelar_Btn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.cancelar_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.cancelar_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.cancelar_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelar_Btn.Location = new System.Drawing.Point(263, 283);
            this.cancelar_Btn.Name = "cancelar_Btn";
            this.cancelar_Btn.Size = new System.Drawing.Size(105, 23);
            this.cancelar_Btn.TabIndex = 104;
            this.cancelar_Btn.Text = "Cancelar";
            this.cancelar_Btn.UseVisualStyleBackColor = false;
            this.cancelar_Btn.Click += new System.EventHandler(this.cancelar_Btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(45, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 96;
            this.label5.Text = "Fecha";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(45, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 100;
            this.label12.Text = "Expediente";
            // 
            // GenerarNotaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 342);
            this.Controls.Add(this.gradient1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GenerarNotaForm";
            this.Text = "Generar nota";
            this.gradient1.ResumeLayout(false);
            this.gradient1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Gradient gradient1;
        private System.Windows.Forms.TextBox nota_Tbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fechaNota_DP;
        private System.Windows.Forms.Button guardar_Btn;
        private System.Windows.Forms.TextBox expediente_Tbx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox medicamento_Tbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cancelar_Btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
    }
}