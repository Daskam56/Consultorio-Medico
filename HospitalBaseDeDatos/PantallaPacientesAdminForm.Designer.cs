namespace HospitalBaseDeDatos
{
    partial class PantallaPacientesAdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPacientesAdminForm));
            this.gradient1 = new HospitalBaseDeDatos.Gradient();
            this.pacientesGeneral_DG = new System.Windows.Forms.DataGridView();
            this.vISTAPACIENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cONSULTORIODataSet = new HospitalBaseDeDatos.CONSULTORIODataSet();
            this.refrescar_Btn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.vISTA_PACIENTESTableAdapter = new HospitalBaseDeDatos.CONSULTORIODataSetTableAdapters.VISTA_PACIENTESTableAdapter();
            this.gradient1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesGeneral_DG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vISTAPACIENTESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSULTORIODataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gradient1
            // 
            this.gradient1.Angle = 285F;
            this.gradient1.BackColor = System.Drawing.Color.Snow;
            this.gradient1.BottomColor = System.Drawing.Color.Empty;
            this.gradient1.Controls.Add(this.pacientesGeneral_DG);
            this.gradient1.Controls.Add(this.refrescar_Btn);
            this.gradient1.Controls.Add(this.button4);
            this.gradient1.Controls.Add(this.button3);
            this.gradient1.Controls.Add(this.button1);
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
            this.pacientesGeneral_DG.TabIndex = 25;
            // 
            // vISTAPACIENTESBindingSource
            // 
            this.vISTAPACIENTESBindingSource.DataMember = "VISTA_PACIENTES";
            this.vISTAPACIENTESBindingSource.DataSource = this.cONSULTORIODataSet;
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
            this.refrescar_Btn.Location = new System.Drawing.Point(1010, 415);
            this.refrescar_Btn.Name = "refrescar_Btn";
            this.refrescar_Btn.Size = new System.Drawing.Size(87, 23);
            this.refrescar_Btn.TabIndex = 24;
            this.refrescar_Btn.Text = "Refrescar";
            this.refrescar_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.refrescar_Btn.UseVisualStyleBackColor = false;
            this.refrescar_Btn.Click += new System.EventHandler(this.refrescar_Btn_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Enabled = false;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(137)))), ((int)(((byte)(150)))));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(883, 39);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 43);
            this.button4.TabIndex = 16;
            this.button4.Text = "Buscar historial";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Enabled = false;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumOrchid;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrchid;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(79)))), ((int)(((byte)(93)))));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(492, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 43);
            this.button3.TabIndex = 15;
            this.button3.Text = "Buscar paciente";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(103, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 43);
            this.button1.TabIndex = 14;
            this.button1.Text = "Agregar paciente";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // vISTA_PACIENTESTableAdapter
            // 
            this.vISTA_PACIENTESTableAdapter.ClearBeforeFill = true;
            // 
            // PantallaPacientesAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 450);
            this.Controls.Add(this.gradient1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PantallaPacientesAdminForm";
            this.Text = "Pacientes generales";
            this.Load += new System.EventHandler(this.PantallaPacientesAdminForm_Load);
            this.gradient1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pacientesGeneral_DG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vISTAPACIENTESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSULTORIODataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Gradient gradient1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private CONSULTORIODataSet cONSULTORIODataSet;
        private System.Windows.Forms.BindingSource vISTAPACIENTESBindingSource;
        private CONSULTORIODataSetTableAdapters.VISTA_PACIENTESTableAdapter vISTA_PACIENTESTableAdapter;
        private System.Windows.Forms.Button refrescar_Btn;
        private System.Windows.Forms.DataGridView pacientesGeneral_DG;
    }
}