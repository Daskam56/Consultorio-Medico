namespace HospitalBaseDeDatos
{
    partial class PantallaCitasAdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaCitasAdminForm));
            this.gradient1 = new HospitalBaseDeDatos.Gradient();
            this.refrescar_Btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pROXIMASCITASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cONSULTORIODataSet = new HospitalBaseDeDatos.CONSULTORIODataSet();
            this.pROXIMAS_CITASTableAdapter = new HospitalBaseDeDatos.CONSULTORIODataSetTableAdapters.PROXIMAS_CITASTableAdapter();
            this.proximascitas_DG = new System.Windows.Forms.DataGridView();
            this.gradient1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pROXIMASCITASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSULTORIODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximascitas_DG)).BeginInit();
            this.SuspendLayout();
            // 
            // gradient1
            // 
            this.gradient1.Angle = 285F;
            this.gradient1.BackColor = System.Drawing.Color.Snow;
            this.gradient1.BottomColor = System.Drawing.Color.Empty;
            this.gradient1.Controls.Add(this.proximascitas_DG);
            this.gradient1.Controls.Add(this.refrescar_Btn);
            this.gradient1.Controls.Add(this.button3);
            this.gradient1.Controls.Add(this.button1);
            this.gradient1.Controls.Add(this.label1);
            this.gradient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradient1.Location = new System.Drawing.Point(0, 0);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(774, 453);
            this.gradient1.TabIndex = 0;
            this.gradient1.TopColor = System.Drawing.Color.PaleTurquoise;
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
            this.refrescar_Btn.Location = new System.Drawing.Point(670, 420);
            this.refrescar_Btn.Name = "refrescar_Btn";
            this.refrescar_Btn.Size = new System.Drawing.Size(87, 23);
            this.refrescar_Btn.TabIndex = 22;
            this.refrescar_Btn.Text = "Refrescar";
            this.refrescar_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.refrescar_Btn.UseVisualStyleBackColor = false;
            this.refrescar_Btn.Click += new System.EventHandler(this.refrescar_Btn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Enabled = false;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Teal;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(442, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 37);
            this.button3.TabIndex = 21;
            this.button3.Text = "Eliminar o modificar cita";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.IndianRed;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(96, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 37);
            this.button1.TabIndex = 20;
            this.button1.Text = "Agregar cita";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(40, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Próximas 3 citas";
            // 
            // pROXIMASCITASBindingSource
            // 
            this.pROXIMASCITASBindingSource.DataMember = "PROXIMAS_CITAS";
            this.pROXIMASCITASBindingSource.DataSource = this.cONSULTORIODataSet;
            // 
            // cONSULTORIODataSet
            // 
            this.cONSULTORIODataSet.DataSetName = "CONSULTORIODataSet";
            this.cONSULTORIODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROXIMAS_CITASTableAdapter
            // 
            this.pROXIMAS_CITASTableAdapter.ClearBeforeFill = true;
            // 
            // proximascitas_DG
            // 
            this.proximascitas_DG.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.proximascitas_DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proximascitas_DG.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.proximascitas_DG.Location = new System.Drawing.Point(15, 90);
            this.proximascitas_DG.Name = "proximascitas_DG";
            this.proximascitas_DG.Size = new System.Drawing.Size(741, 311);
            this.proximascitas_DG.TabIndex = 23;
            // 
            // PantallaCitasAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 453);
            this.Controls.Add(this.gradient1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PantallaCitasAdminForm";
            this.Text = "Citas generales";
            this.Load += new System.EventHandler(this.PantallaCitasAdminForm_Load);
            this.gradient1.ResumeLayout(false);
            this.gradient1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pROXIMASCITASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSULTORIODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximascitas_DG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Gradient gradient1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private CONSULTORIODataSet cONSULTORIODataSet;
        private System.Windows.Forms.BindingSource pROXIMASCITASBindingSource;
        private CONSULTORIODataSetTableAdapters.PROXIMAS_CITASTableAdapter pROXIMAS_CITASTableAdapter;
        private System.Windows.Forms.Button refrescar_Btn;
        private System.Windows.Forms.DataGridView proximascitas_DG;
    }
}