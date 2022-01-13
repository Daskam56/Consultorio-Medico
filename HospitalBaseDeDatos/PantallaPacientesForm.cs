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
    public partial class PantallaPacientesForm : Form
    {
        public PantallaPacientesForm()
        {
            InitializeComponent();
        }

        private void pacienteNuevo_Btn_Click(object sender, EventArgs e)
        {
            RegistroPacienteForm registroPaciente = new RegistroPacienteForm();
            registroPaciente.ShowDialog();
        }

        private void buscarPaciente_Btn_Click(object sender, EventArgs e)
        {
            BuscarPacienteForm buscarPaciente = new BuscarPacienteForm();
            buscarPaciente.ShowDialog();
        }

        private void buscarHistorial_Btn_Click(object sender, EventArgs e)
        {
            HistorialForm historialForm = new HistorialForm(); 
            historialForm.ShowDialog();
        }

        private void PantallaPacientesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cONSULTORIODataSet.VISTA_PACIENTES' table. You can move, or remove it, as needed.
            // this.vISTA_PACIENTESTableAdapter.Fill(this.cONSULTORIODataSet.VISTA_PACIENTES);
            Refrescar();

        }

        private void refrescar_Btn_Click(object sender, EventArgs e)
        {
            //this.vISTA_PACIENTESTableAdapter.Fill(this.cONSULTORIODataSet.VISTA_PACIENTES);
            Refrescar();
        }

        private void Refrescar()
        {
            using (CONSULTORIOEntities1 db = new CONSULTORIOEntities1())
            {
                pacientesGeneral_DG.DataSource = db.paciente.ToList();
            }
        }
    }
}
