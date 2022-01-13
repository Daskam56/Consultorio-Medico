using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using HospitalBaseDeDatos.BD;

namespace HospitalBaseDeDatos
{
    public partial class PantallaCitasAdminForm : Form
    {
        public PantallaCitasAdminForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BuscarCitaForm buscarCitaForm = new BuscarCitaForm();
            buscarCitaForm.ShowDialog();
        }

        private void PantallaCitasAdminForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cONSULTORIODataSet.PROXIMAS_CITAS' table. You can move, or remove it, as needed.
            //this.pROXIMAS_CITASTableAdapter.Fill(this.cONSULTORIODataSet.PROXIMAS_CITAS);
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
                    "SELECT P.nombre, P.sexo, P.fecha_nacimiento, P.telefono, P.alergias, C.dia, C.hora_inicio FROM dbo.CITA AS C INNER JOIN dbo.paciente AS P ON C.expediente = P.expediente";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, connection);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                proximascitas_DG.DataSource = dt;
            }
        }
    }
}
