namespace HospitalBaseDeDatos
{
    partial class BuscarCitaForm
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
            this.gradient2 = new HospitalBaseDeDatos.Gradient();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.informacion_Btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.claveCita_Tbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gradient1.SuspendLayout();
            this.gradient2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradient1
            // 
            this.gradient1.Angle = 285F;
            this.gradient1.BackColor = System.Drawing.Color.Snow;
            this.gradient1.BottomColor = System.Drawing.Color.Snow;
            this.gradient1.Controls.Add(this.gradient2);
            this.gradient1.Controls.Add(this.informacion_Btn);
            this.gradient1.Controls.Add(this.label2);
            this.gradient1.Controls.Add(this.claveCita_Tbx);
            this.gradient1.Controls.Add(this.label1);
            this.gradient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradient1.Location = new System.Drawing.Point(0, 0);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(402, 195);
            this.gradient1.TabIndex = 0;
            this.gradient1.TopColor = System.Drawing.Color.PaleTurquoise;
            // 
            // gradient2
            // 
            this.gradient2.Angle = 285F;
            this.gradient2.BackColor = System.Drawing.Color.Snow;
            this.gradient2.BottomColor = System.Drawing.Color.Snow;
            this.gradient2.Controls.Add(this.button1);
            this.gradient2.Controls.Add(this.label3);
            this.gradient2.Controls.Add(this.textBox1);
            this.gradient2.Controls.Add(this.label4);
            this.gradient2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradient2.Location = new System.Drawing.Point(0, 0);
            this.gradient2.Name = "gradient2";
            this.gradient2.Size = new System.Drawing.Size(402, 195);
            this.gradient2.TabIndex = 63;
            this.gradient2.TopColor = System.Drawing.Color.PaleTurquoise;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(239, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 62;
            this.button1.Text = "Obtener información.";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 24);
            this.label3.TabIndex = 61;
            this.label3.Text = "Buscar una cita";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(37, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "ID único de cita";
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
            this.label2.Size = new System.Drawing.Size(153, 24);
            this.label2.TabIndex = 61;
            this.label2.Text = "Buscar una cita";
            // 
            // claveCita_Tbx
            // 
            this.claveCita_Tbx.Location = new System.Drawing.Point(157, 93);
            this.claveCita_Tbx.Name = "claveCita_Tbx";
            this.claveCita_Tbx.Size = new System.Drawing.Size(164, 20);
            this.claveCita_Tbx.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(37, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "ID único de cita";
            // 
            // BuscarCitaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 195);
            this.Controls.Add(this.gradient1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BuscarCitaForm";
            this.Text = "Buscar Cita";
            this.gradient1.ResumeLayout(false);
            this.gradient1.PerformLayout();
            this.gradient2.ResumeLayout(false);
            this.gradient2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Gradient gradient1;
        private System.Windows.Forms.Button informacion_Btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox claveCita_Tbx;
        private System.Windows.Forms.Label label1;
        private Gradient gradient2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
    }
}