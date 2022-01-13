namespace HospitalBaseDeDatos
{
    partial class HistorialForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialForm));
            this.gradient1 = new HospitalBaseDeDatos.Gradient();
            this.generarNota_Btn = new System.Windows.Forms.Button();
            this.buscar_Btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.vISTAHISTORIALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cONSULTORIODataSet = new HospitalBaseDeDatos.CONSULTORIODataSet();
            this.vISTA_HISTORIALTableAdapter = new HospitalBaseDeDatos.CONSULTORIODataSetTableAdapters.VISTA_HISTORIALTableAdapter();
            this.vistaHistorial_DG = new System.Windows.Forms.DataGridView();
            this.gradient1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vISTAHISTORIALBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSULTORIODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaHistorial_DG)).BeginInit();
            this.SuspendLayout();
            // 
            // gradient1
            // 
            this.gradient1.Angle = 285F;
            this.gradient1.BackColor = System.Drawing.Color.Snow;
            this.gradient1.BottomColor = System.Drawing.Color.Empty;
            this.gradient1.Controls.Add(this.vistaHistorial_DG);
            this.gradient1.Controls.Add(this.generarNota_Btn);
            this.gradient1.Controls.Add(this.buscar_Btn);
            this.gradient1.Controls.Add(this.label2);
            this.gradient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradient1.Location = new System.Drawing.Point(0, 0);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(632, 450);
            this.gradient1.TabIndex = 0;
            this.gradient1.TopColor = System.Drawing.Color.PaleTurquoise;
            // 
            // generarNota_Btn
            // 
            this.generarNota_Btn.BackColor = System.Drawing.Color.Transparent;
            this.generarNota_Btn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.generarNota_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.generarNota_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.generarNota_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generarNota_Btn.Location = new System.Drawing.Point(434, 74);
            this.generarNota_Btn.Name = "generarNota_Btn";
            this.generarNota_Btn.Size = new System.Drawing.Size(108, 30);
            this.generarNota_Btn.TabIndex = 68;
            this.generarNota_Btn.Text = "Generar registro";
            this.generarNota_Btn.UseVisualStyleBackColor = false;
            this.generarNota_Btn.Click += new System.EventHandler(this.generarNota_Btn_Click);
            // 
            // buscar_Btn
            // 
            this.buscar_Btn.BackColor = System.Drawing.Color.Transparent;
            this.buscar_Btn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buscar_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buscar_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buscar_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscar_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(120)))), ((int)(((byte)(92)))));
            this.buscar_Btn.Image = ((System.Drawing.Image)(resources.GetObject("buscar_Btn.Image")));
            this.buscar_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscar_Btn.Location = new System.Drawing.Point(102, 74);
            this.buscar_Btn.Name = "buscar_Btn";
            this.buscar_Btn.Size = new System.Drawing.Size(99, 30);
            this.buscar_Btn.TabIndex = 66;
            this.buscar_Btn.Text = "Actualizar";
            this.buscar_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buscar_Btn.UseVisualStyleBackColor = false;
            this.buscar_Btn.Click += new System.EventHandler(this.buscar_Btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 24);
            this.label2.TabIndex = 65;
            this.label2.Text = "Historial de pacientes";
            // 
            // vISTAHISTORIALBindingSource
            // 
            this.vISTAHISTORIALBindingSource.DataMember = "VISTA_HISTORIAL";
            this.vISTAHISTORIALBindingSource.DataSource = this.cONSULTORIODataSet;
            // 
            // cONSULTORIODataSet
            // 
            this.cONSULTORIODataSet.DataSetName = "CONSULTORIODataSet";
            this.cONSULTORIODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vISTA_HISTORIALTableAdapter
            // 
            this.vISTA_HISTORIALTableAdapter.ClearBeforeFill = true;
            // 
            // vistaHistorial_DG
            // 
            this.vistaHistorial_DG.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vistaHistorial_DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vistaHistorial_DG.Location = new System.Drawing.Point(35, 126);
            this.vistaHistorial_DG.Name = "vistaHistorial_DG";
            this.vistaHistorial_DG.Size = new System.Drawing.Size(547, 301);
            this.vistaHistorial_DG.TabIndex = 69;
            // 
            // HistorialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 450);
            this.Controls.Add(this.gradient1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HistorialForm";
            this.Text = "Historial médico";
            this.Load += new System.EventHandler(this.HistorialForm_Load);
            this.gradient1.ResumeLayout(false);
            this.gradient1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vISTAHISTORIALBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSULTORIODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaHistorial_DG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Gradient gradient1;
        private System.Windows.Forms.Button generarNota_Btn;
        private System.Windows.Forms.Button buscar_Btn;
        private System.Windows.Forms.Label label2;
        private CONSULTORIODataSet cONSULTORIODataSet;
        private System.Windows.Forms.BindingSource vISTAHISTORIALBindingSource;
        private CONSULTORIODataSetTableAdapters.VISTA_HISTORIALTableAdapter vISTA_HISTORIALTableAdapter;
        private System.Windows.Forms.DataGridView vistaHistorial_DG;
    }
}