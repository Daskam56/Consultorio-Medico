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

namespace HospitalBaseDeDatos
{
    public partial class PantallaDoctorForm : Form
    {
        public PantallaDoctorForm()
        {
            InitializeComponent();
        }

        private void doctorNuevo_Btn_Click(object sender, EventArgs e)
        {
            RegistroDoctorForm registroDoctor = new RegistroDoctorForm();
            registroDoctor.ShowDialog();
        }

        private void buscarDoctor_Btn_Click(object sender, EventArgs e)
        {
            BuscarDoctorForm buscarDoctor = new BuscarDoctorForm();
            buscarDoctor.ShowDialog();
        }

        private void PantallaDoctorForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cONSULTORIODataSet.VISTA_DOCTORES' table. You can move, or remove it, as needed.
            //this.vISTA_DOCTORESTableAdapter.Fill(this.cONSULTORIODataSet.VISTA_DOCTORES);
            Refrescar();

        }

        private void refrescar_Btn_Click(object sender, EventArgs e)
        {
            //this.vISTA_DOCTORESTableAdapter.Fill(this.cONSULTORIODataSet.VISTA_DOCTORES);
            Refrescar();
        }

        private void Refrescar()
        {
            using (CONSULTORIOEntities1 db = new CONSULTORIOEntities1())
            {
                dataGridView1.DataSource = db.VISTA_DOCTORES.ToList();
            }
        }
    }
}
