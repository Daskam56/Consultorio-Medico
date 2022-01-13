namespace HospitalBaseDeDatos
{
    partial class PantallaDoctorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaDoctorForm));
            this.cONSULTORIODataSet = new HospitalBaseDeDatos.CONSULTORIODataSet();
            this.vISTADOCTORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vISTA_DOCTORESTableAdapter = new HospitalBaseDeDatos.CONSULTORIODataSetTableAdapters.VISTA_DOCTORESTableAdapter();
            this.gradient1 = new HospitalBaseDeDatos.Gradient();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.refrescar_Btn = new System.Windows.Forms.Button();
            this.buscarDoctor_Btn = new System.Windows.Forms.Button();
            this.doctorNuevo_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cONSULTORIODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vISTADOCTORESBindingSource)).BeginInit();
            this.gradient1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cONSULTORIODataSet
            // 
            this.cONSULTORIODataSet.DataSetName = "CONSULTORIODataSet";
            this.cONSULTORIODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vISTADOCTORESBindingSource
            // 
            this.vISTADOCTORESBindingSource.DataMember = "VISTA_DOCTORES";
            this.vISTADOCTORESBindingSource.DataSource = this.cONSULTORIODataSet;
            // 
            // vISTA_DOCTORESTableAdapter
            // 
            this.vISTA_DOCTORESTableAdapter.ClearBeforeFill = true;
            // 
            // gradient1
            // 
            this.gradient1.Angle = 285F;
            this.gradient1.BackColor = System.Drawing.Color.Snow;
            this.gradient1.BottomColor = System.Drawing.Color.Empty;
            this.gradient1.Controls.Add(this.dataGridView1);
            this.gradient1.Controls.Add(this.refrescar_Btn);
            this.gradient1.Controls.Add(this.buscarDoctor_Btn);
            this.gradient1.Controls.Add(this.doctorNuevo_Btn);
            this.gradient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradient1.Location = new System.Drawing.Point(0, 0);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(895, 456);
            this.gradient1.TabIndex = 0;
            this.gradient1.TopColor = System.Drawing.Color.PaleTurquoise;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(845, 300);
            this.dataGridView1.TabIndex = 24;
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
            this.refrescar_Btn.Location = new System.Drawing.Point(796, 421);
            this.refrescar_Btn.Name = "refrescar_Btn";
            this.refrescar_Btn.Size = new System.Drawing.Size(87, 23);
            this.refrescar_Btn.TabIndex = 23;
            this.refrescar_Btn.Text = "Refrescar";
            this.refrescar_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.refrescar_Btn.UseVisualStyleBackColor = false;
            this.refrescar_Btn.Click += new System.EventHandler(this.refrescar_Btn_Click);
            // 
            // buscarDoctor_Btn
            // 
            this.buscarDoctor_Btn.BackColor = System.Drawing.Color.Transparent;
            this.buscarDoctor_Btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.buscarDoctor_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumOrchid;
            this.buscarDoctor_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrchid;
            this.buscarDoctor_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarDoctor_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(79)))), ((int)(((byte)(93)))));
            this.buscarDoctor_Btn.Image = ((System.Drawing.Image)(resources.GetObject("buscarDoctor_Btn.Image")));
            this.buscarDoctor_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscarDoctor_Btn.Location = new System.Drawing.Point(579, 41);
            this.buscarDoctor_Btn.Name = "buscarDoctor_Btn";
            this.buscarDoctor_Btn.Size = new System.Drawing.Size(127, 43);
            this.buscarDoctor_Btn.TabIndex = 13;
            this.buscarDoctor_Btn.Text = "Buscar doctor";
            this.buscarDoctor_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buscarDoctor_Btn.UseVisualStyleBackColor = false;
            this.buscarDoctor_Btn.Click += new System.EventHandler(this.buscarDoctor_Btn_Click);
            // 
            // doctorNuevo_Btn
            // 
            this.doctorNuevo_Btn.BackColor = System.Drawing.Color.Transparent;
            this.doctorNuevo_Btn.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.doctorNuevo_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.doctorNuevo_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.doctorNuevo_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doctorNuevo_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.doctorNuevo_Btn.Image = ((System.Drawing.Image)(resources.GetObject("doctorNuevo_Btn.Image")));
            this.doctorNuevo_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.doctorNuevo_Btn.Location = new System.Drawing.Point(229, 41);
            this.doctorNuevo_Btn.Name = "doctorNuevo_Btn";
            this.doctorNuevo_Btn.Size = new System.Drawing.Size(131, 43);
            this.doctorNuevo_Btn.TabIndex = 12;
            this.doctorNuevo_Btn.Text = "Agregar doctor";
            this.doctorNuevo_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.doctorNuevo_Btn.UseVisualStyleBackColor = false;
            this.doctorNuevo_Btn.Click += new System.EventHandler(this.doctorNuevo_Btn_Click);
            // 
            // PantallaDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 456);
            this.Controls.Add(this.gradient1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PantallaDoctorForm";
            this.Text = "Doctores";
            this.Load += new System.EventHandler(this.PantallaDoctorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cONSULTORIODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vISTADOCTORESBindingSource)).EndInit();
            this.gradient1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Gradient gradient1;
        private System.Windows.Forms.Button buscarDoctor_Btn;
        private System.Windows.Forms.Button doctorNuevo_Btn;
        private CONSULTORIODataSet cONSULTORIODataSet;
        private System.Windows.Forms.BindingSource vISTADOCTORESBindingSource;
        private CONSULTORIODataSetTableAdapters.VISTA_DOCTORESTableAdapter vISTA_DOCTORESTableAdapter;
        private System.Windows.Forms.Button refrescar_Btn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}