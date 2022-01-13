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
    public partial class PantallaPrincipalAdminForm : Form
    {
        public PantallaPrincipalAdminForm()
        {
            InitializeComponent();
        }

        private void pantallaPaciente_Btn_Click(object sender, EventArgs e)
        {
            PantallaPacientesAdminForm pantallaPacientesAdmin = new PantallaPacientesAdminForm();
            pantallaPacientesAdmin.ShowDialog();
        }

        private void pantallaHorario_Btn_Click(object sender, EventArgs e)
        {

            PantallaHorarioAdminForm pantallaHorarioAdmin = new PantallaHorarioAdminForm();
            pantallaHorarioAdmin.ShowDialog();
        }

            private void pantallaDoctor_Btn_Click(object sender, EventArgs e)
        {

            PantallaDoctorForm pantallaDoctor = new PantallaDoctorForm();
            pantallaDoctor.ShowDialog();
        }

        private void pantallaCitas_Btn_Click(object sender, EventArgs e)
        { 
            PantallaCitasAdminForm pantallaCitasAdmin = new PantallaCitasAdminForm();
            pantallaCitasAdmin.ShowDialog();
        }
    }
}
