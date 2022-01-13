using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalBaseDeDatos
{
    public partial class PantallaPrincipalDoctorForm : Form
    {
        public PantallaPrincipalDoctorForm()
        {
            InitializeComponent();
        }

        private void horario_Btn_Click(object sender, EventArgs e)
        {

            PantallaHorarioForm pantallaHorario = new PantallaHorarioForm();
            pantallaHorario.ShowDialog();

        }

        private void pacientes_Btn_Click(object sender, EventArgs e)
        {
            
            PantallaPacientesForm pantallaPacientesForm = new PantallaPacientesForm();
            pantallaPacientesForm.ShowDialog();

        }

        private void citas_Btn_Click(object sender, EventArgs e)
        {
           
            PantallaCitasForm pantallaCitas = new PantallaCitasForm();
            pantallaCitas.ShowDialog();

        }
    }
}
