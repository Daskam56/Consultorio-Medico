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
    public partial class PantallaHorarioForm : Form
    {
        public PantallaHorarioForm()
        {
            InitializeComponent();
        }

        private void PantallaHorarioForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cONSULTORIODataSet.VISTA_HORARIO' table. You can move, or remove it, as needed.
            //this.vISTA_HORARIOTableAdapter.Fill(this.cONSULTORIODataSet.VISTA_HORARIO);

            Refresca();

        }

        private void Refrescar() 
        {
            using (CONSULTORIOEntities1 db = new CONSULTORIOEntities1()) 
            {
                horarioPersonal_DG.DataSource = db.VISTA_HORARIO.ToList();
            }
        }

        private void Refresca()
        {
            using (SqlConnection connection = new SqlConnection
                ("server=LAPTOP-EQMN6VB8; database=CONSULTORIO; integrated security=true"))
            {
                connection.Open();
                String consulta =
                    "SELECT * FROM VISTA_HISTORIAL";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, connection);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                horarioPersonal_DG.DataSource = dt;
            }
        }
    }


}
