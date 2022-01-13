namespace HospitalBaseDeDatos
{
    partial class PantallaPacientesForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPacientesForm));
            this.gradient1 = new HospitalBaseDeDatos.Gradient();
            this.pacientesGeneral_DG = new System.Windows.Forms.DataGridView();
            this.vISTAPACIENTESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cONSULTORIODataSet = new HospitalBaseDeDatos.CONSULTORIODataSet();
            this.refrescar_Btn = new System.Windows.Forms.Button();
            this.buscarHistorial_Btn = new System.Windows.Forms.Button();
            this.buscarPaciente_Btn = new System.Windows.Forms.Button();
            this.pacienteNuevo_Btn = new System.Windows.Forms.Button();
            this.vISTAPACIENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vISTA_PACIENTESTableAdapter = new HospitalBaseDeDatos.CONSULTORIODataSetTableAdapters.VISTA_PACIENTESTableAdapter();
            this.gradient1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesGeneral_DG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vISTAPACIENTESBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSULTORIODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vISTAPACIENTESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gradient1
            // 
            this.gradient1.Angle = 285F;
            this.gradient1.BackColor = System.Drawing.Color.Snow;
            this.gradient1.BottomColor = System.Drawing.Color.Empty;
            this.gradient1.Controls.Add(this.pacientesGeneral_DG);
            this.gradient1.Controls.Add(this.refrescar_Btn);
            this.gradient1.Controls.Add(this.buscarHistorial_Btn);
            this.gradient1.Controls.Add(this.buscarPaciente_Btn);
            this.gradient1.Controls.Add(this.pacienteNuevo_Btn);
            this.gradient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradient1.Location = new System.Drawing.Point(0, 0);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(1110, 450);
            this.gradient1.TabIndex = 0;
            this.gradient1.TopColor = System.Drawing.Color.PaleTurquoise;
            // 
            // pacientesGeneral_DG
            // 
            this.pacientesGeneral_DG.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pacientesGeneral_DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pacientesGeneral_DG.GridColor = System.Drawing.SystemColors.ControlLight;
            this.pacientesGeneral_DG.Location = new System.Drawing.Point(30, 110);
            this.pacientesGeneral_DG.Name = "pacientesGeneral_DG";
            this.pacientesGeneral_DG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pacientesGeneral_DG.Size = new System.Drawing.Size(1040, 300);
            this.pacientesGeneral_DG.TabIndex = 26;
            // 
            // vISTAPACIENTESBindingSource1
            // 
            this.vISTAPACIENTESBindingSource1.DataMember = "VISTA_PACIENTES";
            this.vISTAPACIENTESBindingSource1.DataSource = this.cONSULTORIODataSet;
            // 
            // cONSULTORIODataSet
            // 
            this.cONSULTORIODataSet.DataSetName = "CONSULTORIODataSet";
            this.cONSULTORIODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // refrescar_Btn
            // 
            this.refrescar_Btn.BackColor = System.Drawing.Color.Transparent;
            this.refrescar_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(144)))), ((int)(((byte)(110)))));
            this.refrescar_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(163)))), ((int)(((byte)(132)))));
            this.refrescar_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(144)))), ((int)(((byte)(110)))));
            this.refrescar_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refrescar_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(120)))), ((int)(((byte)(92)))));
            this.refrescar_Btn.Image = ((System.Drawing.Image)(resources.GetObject("refrescar_Btn.Image")));
            this.refrescar_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refrescar_Btn.Location = new System.Drawing.Point(1011, 415);
            this.refrescar_Btn.Name = "refrescar_Btn";
            this.refrescar_Btn.Size = new System.Drawing.Size(87, 23);
            this.refrescar_Btn.TabIndex = 25;
            this.refrescar_Btn.Text = "Refrescar";
            this.refrescar_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.refrescar_Btn.UseVisualStyleBackColor = false;
            this.refrescar_Btn.Click += new System.EventHandler(this.refrescar_Btn_Click);
            // 
            // buscarHistorial_Btn
            // 
            this.buscarHistorial_Btn.BackColor = System.Drawing.Color.Transparent;
            this.buscarHistorial_Btn.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.buscarHistorial_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
            this.buscarHistorial_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.buscarHistorial_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarHistorial_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(137)))), ((int)(((byte)(150)))));
            this.buscarHistorial_Btn.Image = ((System.Drawing.Image)(resources.GetObject("buscarHistorial_Btn.Image")));
            this.buscarHistorial_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscarHistorial_Btn.Location = new System.Drawing.Point(883, 39);
            this.buscarHistorial_Btn.Name = "buscarHistorial_Btn";
            this.buscarHistorial_Btn.Size = new System.Drawing.Size(128, 43);
            this.buscarHistorial_Btn.TabIndex = 12;
            this.buscarHistorial_Btn.Text = "Buscar historial";
            this.buscarHistorial_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buscarHistorial_Btn.UseVisualStyleBackColor = false;
            this.buscarHistorial_Btn.Click += new System.EventHandler(this.buscarHistorial_Btn_Click);
            // 
            // buscarPaciente_Btn
            // 
            this.buscarPaciente_Btn.BackColor = System.Drawing.Color.Transparent;
            this.buscarPaciente_Btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.buscarPaciente_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumOrchid;
            this.buscarPaciente_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrchid;
            this.buscarPaciente_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarPaciente_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(79)))), ((int)(((byte)(93)))));
            this.buscarPaciente_Btn.Image = ((System.Drawing.Image)(resources.GetObject("buscarPaciente_Btn.Image")));
            this.buscarPaciente_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscarPaciente_Btn.Location = new System.Drawing.Point(492, 39);
            this.buscarPaciente_Btn.Name = "buscarPaciente_Btn";
            this.buscarPaciente_Btn.Size = new System.Drawing.Size(133, 43);
            this.buscarPaciente_Btn.TabIndex = 11;
            this.buscarPaciente_Btn.Text = "Buscar paciente";
            this.buscarPaciente_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buscarPaciente_Btn.UseVisualStyleBackColor = false;
            this.buscarPaciente_Btn.Click += new System.EventHandler(this.buscarPaciente_Btn_Click);
            // 
            // pacienteNuevo_Btn
            // 
            this.pacienteNuevo_Btn.BackColor = System.Drawing.Color.Transparent;
            this.pacienteNuevo_Btn.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pacienteNuevo_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.pacienteNuevo_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.pacienteNuevo_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pacienteNuevo_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.pacienteNuevo_Btn.Image = ((System.Drawing.Image)(resources.GetObject("pacienteNuevo_Btn.Image")));
            this.pacienteNuevo_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pacienteNuevo_Btn.Location = new System.Drawing.Point(103, 39);
            this.pacienteNuevo_Btn.Name = "pacienteNuevo_Btn";
            this.pacienteNuevo_Btn.Size = new System.Drawing.Size(144, 43);
            this.pacienteNuevo_Btn.TabIndex = 10;
            this.pacienteNuevo_Btn.Text = "Agregar paciente";
            this.pacienteNuevo_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pacienteNuevo_Btn.UseVisualStyleBackColor = false;
            this.pacienteNuevo_Btn.Click += new System.EventHandler(this.pacienteNuevo_Btn_Click);
            // 
            // vISTAPACIENTESBindingSource
            // 
            this.vISTAPACIENTESBindingSource.DataMember = "VISTA_PACIENTES";
            this.vISTAPACIENTESBindingSource.DataSource = this.cONSULTORIODataSet;
            // 
            // vISTA_PACIENTESTableAdapter
            // 
            this.vISTA_PACIENTESTableAdapter.ClearBeforeFill = true;
            // 
            // PantallaPacientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 450);
            this.Controls.Add(this.gradient1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PantallaPacientesForm";
            this.Text = "Pacientes";
            this.Load += new System.EventHandler(this.PantallaPacientesForm_Load);
            this.gradient1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pacientesGeneral_DG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vISTAPACIENTESBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSULTORIODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vISTAPACIENTESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Gradient gradient1;
        private System.Windows.Forms.Button buscarHistorial_Btn;
        private System.Windows.Forms.Button buscarPaciente_Btn;
        private System.Windows.Forms.Button pacienteNuevo_Btn;
        private System.Windows.Forms.Button refrescar_Btn;
        private CONSULTORIODataSet cONSULTORIODataSet;
        private System.Windows.Forms.BindingSource vISTAPACIENTESBindingSource;
        private CONSULTORIODataSetTableAdapters.VISTA_PACIENTESTableAdapter vISTA_PACIENTESTableAdapter;
        private System.Windows.Forms.DataGridView pacientesGeneral_DG;
        private System.Windows.Forms.BindingSource vISTAPACIENTESBindingSource1;
    }
}