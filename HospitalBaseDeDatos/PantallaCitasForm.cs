using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalBaseDeDatos.BD;
using System.Data.SqlClient;

namespace HospitalBaseDeDatos
{
    public partial class PantallaCitasForm : Form
    {
        private Button eliminarOModificar_Btn;
        private Button nuevaCita_Btn;
        private Label label1;
        private Button refrescar_Btn;
        private CONSULTORIODataSet cONSULTORIODataSet;
        private BindingSource pROXIMASCITASBindingSource;
        private IContainer components;
        private CONSULTORIODataSetTableAdapters.PROXIMAS_CITASTableAdapter pROXIMAS_CITASTableAdapter;
        private BackgroundWorker backgroundWorker1;
        private DataGridView proximascitas_DG;
        private Gradient gradient1;

        public PantallaCitasForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaCitasForm));
            this.gradient1 = new HospitalBaseDeDatos.Gradient();
            this.refrescar_Btn = new System.Windows.Forms.Button();
            this.eliminarOModificar_Btn = new System.Windows.Forms.Button();
            this.nuevaCita_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pROXIMASCITASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cONSULTORIODataSet = new HospitalBaseDeDatos.CONSULTORIODataSet();
            this.pROXIMAS_CITASTableAdapter = new HospitalBaseDeDatos.CONSULTORIODataSetTableAdapters.PROXIMAS_CITASTableAdapter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
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
            this.gradient1.Controls.Add(this.eliminarOModificar_Btn);
            this.gradient1.Controls.Add(this.nuevaCita_Btn);
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
            this.refrescar_Btn.TabIndex = 30;
            this.refrescar_Btn.Text = "Refrescar";
            this.refrescar_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.refrescar_Btn.UseVisualStyleBackColor = false;
            this.refrescar_Btn.Click += new System.EventHandler(this.refrescar_Btn_Click);
            // 
            // eliminarOModificar_Btn
            // 
            this.eliminarOModificar_Btn.BackColor = System.Drawing.Color.Transparent;
            this.eliminarOModificar_Btn.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.eliminarOModificar_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.eliminarOModificar_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.eliminarOModificar_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarOModificar_Btn.ForeColor = System.Drawing.Color.Teal;
            this.eliminarOModificar_Btn.Image = ((System.Drawing.Image)(resources.GetObject("eliminarOModificar_Btn.Image")));
            this.eliminarOModificar_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eliminarOModificar_Btn.Location = new System.Drawing.Point(442, 12);
            this.eliminarOModificar_Btn.Name = "eliminarOModificar_Btn";
            this.eliminarOModificar_Btn.Size = new System.Drawing.Size(168, 37);
            this.eliminarOModificar_Btn.TabIndex = 29;
            this.eliminarOModificar_Btn.Text = "Eliminar o modificar cita";
            this.eliminarOModificar_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.eliminarOModificar_Btn.UseVisualStyleBackColor = false;
            this.eliminarOModificar_Btn.Click += new System.EventHandler(this.eliminarOModificar_Btn_Click);
            // 
            // nuevaCita_Btn
            // 
            this.nuevaCita_Btn.BackColor = System.Drawing.Color.Transparent;
            this.nuevaCita_Btn.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.nuevaCita_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.nuevaCita_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.nuevaCita_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuevaCita_Btn.ForeColor = System.Drawing.Color.IndianRed;
            this.nuevaCita_Btn.Image = ((System.Drawing.Image)(resources.GetObject("nuevaCita_Btn.Image")));
            this.nuevaCita_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nuevaCita_Btn.Location = new System.Drawing.Point(96, 12);
            this.nuevaCita_Btn.Name = "nuevaCita_Btn";
            this.nuevaCita_Btn.Size = new System.Drawing.Size(112, 37);
            this.nuevaCita_Btn.TabIndex = 28;
            this.nuevaCita_Btn.Text = "Agregar cita";
            this.nuevaCita_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nuevaCita_Btn.UseVisualStyleBackColor = false;
            this.nuevaCita_Btn.Click += new System.EventHandler(this.nuevaCita_Btn_Click);
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
            this.label1.TabIndex = 27;
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
            this.proximascitas_DG.Location = new System.Drawing.Point(15, 90);
            this.proximascitas_DG.Name = "proximascitas_DG";
            this.proximascitas_DG.Size = new System.Drawing.Size(741, 311);
            this.proximascitas_DG.TabIndex = 31;
            // 
            // PantallaCitasForm
            // 
            this.ClientSize = new System.Drawing.Size(774, 453);
            this.Controls.Add(this.gradient1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PantallaCitasForm";
            this.Text = "Citas";
            this.Load += new System.EventHandler(this.PantallaCitasForm_Load);
            this.gradient1.ResumeLayout(false);
            this.gradient1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pROXIMASCITASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSULTORIODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximascitas_DG)).EndInit();
            this.ResumeLayout(false);

        }

        private void nuevaCita_Btn_Click(object sender, EventArgs e)
        {
            GenerarCitaForm generarCita = new GenerarCitaForm();
            generarCita.ShowDialog();
        }

        private void eliminarOModificar_Btn_Click(object sender, EventArgs e)
        {
            BuscarCitaForm buscarCitaForm = new BuscarCitaForm();
            buscarCitaForm.ShowDialog();
        }

        private void PantallaCitasForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cONSULTORIODataSet.PROXIMAS_CITAS' table. You can move, or remove it, as needed.
            // this.pROXIMAS_CITASTableAdapter.Fill(this.cONSULTORIODataSet.PROXIMAS_CITAS);
            Refresca();

        }

        private void refrescar_Btn_Click(object sender, EventArgs e)
        {
            //this.pROXIMAS_CITASTableAdapter.Fill(this.cONSULTORIODataSet.PROXIMAS_CITAS);
            Refresca();
        }

        private void Refrescar()
        {
            using (CONSULTORIOEntities1 db = new CONSULTORIOEntities1())
            {
                proximascitas_DG.DataSource = db.CITA.ToList();
            }
        }

        private void Refresca() 
        {
            using (SqlConnection connection = new SqlConnection
                ("server=LAPTOP-EQMN6VB8; database=CONSULTORIO; integrated security=true")) 
            {
                connection.Open();
                String consulta =
                    "SELECT * FROM PROXIMAS_CITAS";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, connection);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                proximascitas_DG.DataSource = dt;
            }
        }
    }


}
