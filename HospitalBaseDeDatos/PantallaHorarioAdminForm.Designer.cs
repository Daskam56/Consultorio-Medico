namespace HospitalBaseDeDatos
{
    partial class PantallaHorarioAdminForm
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
            this.gradient1 = new HospitalBaseDeDatos.Gradient();
            this.label1 = new System.Windows.Forms.Label();
            this.vISTAHORARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cONSULTORIODataSet = new HospitalBaseDeDatos.CONSULTORIODataSet();
            this.vISTA_HORARIOTableAdapter = new HospitalBaseDeDatos.CONSULTORIODataSetTableAdapters.VISTA_HORARIOTableAdapter();
            this.horarioGeneral_DG = new System.Windows.Forms.DataGridView();
            this.gradient1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vISTAHORARIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSULTORIODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horarioGeneral_DG)).BeginInit();
            this.SuspendLayout();
            // 
            // gradient1
            // 
            this.gradient1.Angle = 285F;
            this.gradient1.BackColor = System.Drawing.Color.Snow;
            this.gradient1.BottomColor = System.Drawing.Color.Empty;
            this.gradient1.Controls.Add(this.horarioGeneral_DG);
            this.gradient1.Controls.Add(this.label1);
            this.gradient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradient1.Location = new System.Drawing.Point(0, 0);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(584, 451);
            this.gradient1.TabIndex = 0;
            this.gradient1.TopColor = System.Drawing.Color.PaleTurquoise;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(35, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Estas son las citas programadas en la próxima semana";
            // 
            // vISTAHORARIOBindingSource
            // 
            this.vISTAHORARIOBindingSource.DataMember = "VISTA_HORARIO";
            this.vISTAHORARIOBindingSource.DataSource = this.cONSULTORIODataSet;
            // 
            // cONSULTORIODataSet
            // 
            this.cONSULTORIODataSet.DataSetName = "CONSULTORIODataSet";
            this.cONSULTORIODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vISTA_HORARIOTableAdapter
            // 
            this.vISTA_HORARIOTableAdapter.ClearBeforeFill = true;
            // 
            // horarioGeneral_DG
            // 
            this.horarioGeneral_DG.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.horarioGeneral_DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.horarioGeneral_DG.Location = new System.Drawing.Point(15, 60);
            this.horarioGeneral_DG.Name = "horarioGeneral_DG";
            this.horarioGeneral_DG.Size = new System.Drawing.Size(550, 365);
            this.horarioGeneral_DG.TabIndex = 12;
            // 
            // PantallaHorarioAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 451);
            this.Controls.Add(this.gradient1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PantallaHorarioAdminForm";
            this.Text = "Horario general";
            this.Load += new System.EventHandler(this.PantallaHorarioAdminForm_Load);
            this.gradient1.ResumeLayout(false);
            this.gradient1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vISTAHORARIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSULTORIODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horarioGeneral_DG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Gradient gradient1;
        private System.Windows.Forms.Label label1;
        private CONSULTORIODataSet cONSULTORIODataSet;
        private System.Windows.Forms.BindingSource vISTAHORARIOBindingSource;
        private CONSULTORIODataSetTableAdapters.VISTA_HORARIOTableAdapter vISTA_HORARIOTableAdapter;
        private System.Windows.Forms.DataGridView horarioGeneral_DG;
    }
}