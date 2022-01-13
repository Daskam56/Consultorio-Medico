using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalBaseDeDatos.BD;

namespace HospitalBaseDeDatos
{
    public partial class GenerarCitaForm : Form
    {
        public GenerarCitaForm()
        {
            InitializeComponent();
        }
        private void guardar_Btn_Click(object sender, EventArgs e)
        {
            using (CONSULTORIOEntities1 db = new CONSULTORIOEntities1())
            {
                CITA cITA = new CITA();
                int x = Int32.Parse(expediente_Tbx.Text);
                int y = Int32.Parse(claveDoctor_Tbx.Text);
                cITA.dia = fechaCita_Dp.Value;
                cITA.hora_inicio = inicioCita_Tbx.Text;
                cITA.hora_termino = horaFinCita_Tbx.Text;
                cITA.clave_doc =y;
                cITA.expediente = x;

                db.CITA.Add(cITA);
                db.SaveChanges();
                MessageBox.Show("Cita generada con ID: " + cITA.numeroCita);
            }
        }
    }
}
