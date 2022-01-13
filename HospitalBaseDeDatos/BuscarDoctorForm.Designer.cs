namespace HospitalBaseDeDatos
{
    partial class BuscarDoctorForm
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
            this.informacion_Btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.claveDoctor_Tbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gradient1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradient1
            // 
            this.gradient1.Angle = 285F;
            this.gradient1.BackColor = System.Drawing.Color.Snow;
            this.gradient1.BottomColor = System.Drawing.Color.Snow;
            this.gradient1.Controls.Add(this.informacion_Btn);
            this.gradient1.Controls.Add(this.label2);
            this.gradient1.Controls.Add(this.claveDoctor_Tbx);
            this.gradient1.Controls.Add(this.label1);
            this.gradient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradient1.Location = new System.Drawing.Point(0, 0);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(402, 195);
            this.gradient1.TabIndex = 0;
            this.gradient1.TopColor = System.Drawing.Color.PaleTurquoise;
            // 
            // informacion_Btn
            // 
            this.informacion_Btn.BackColor = System.Drawing.Color.Transparent;
            this.informacion_Btn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.informacion_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.informacion_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.informacion_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.informacion_Btn.ForeColor = System.Drawing.Color.Black;
            this.informacion_Btn.Location = new System.Drawing.Point(239, 153);
            this.informacion_Btn.Name = "informacion_Btn";
            this.informacion_Btn.Size = new System.Drawing.Size(127, 23);
            this.informacion_Btn.TabIndex = 62;
            this.informacion_Btn.Text = "Obtener información.";
            this.informacion_Btn.UseVisualStyleBackColor = false;
            this.informacion_Btn.Click += new System.EventHandler(this.informacion_Btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 24);
            this.label2.TabIndex = 61;
            this.label2.Text = "Buscar a un doctor";
            // 
            // claveDoctor_Tbx
            // 
            this.claveDoctor_Tbx.Location = new System.Drawing.Point(157, 93);
            this.claveDoctor_Tbx.Name = "claveDoctor_Tbx";
            this.claveDoctor_Tbx.Size = new System.Drawing.Size(164, 20);
            this.claveDoctor_Tbx.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(37, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Clave de doctor";
            // 
            // BuscarDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 195);
            this.Controls.Add(this.gradient1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BuscarDoctorForm";
            this.Text = "Buscar Doctor";
            this.gradient1.ResumeLayout(false);
            this.gradient1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Gradient gradient1;
        private System.Windows.Forms.Button informacion_Btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox claveDoctor_Tbx;
        private System.Windows.Forms.Label label1;
    }
}