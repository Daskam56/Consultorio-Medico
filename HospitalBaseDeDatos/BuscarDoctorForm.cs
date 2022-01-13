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
    public partial class BuscarDoctorForm : Form
    {
        DOCTOR oDOCTOR = null;
        
        public BuscarDoctorForm()
        {
            InitializeComponent();
        }

        private int? getCed() 
        {
            try
            {
                return int.Parse(claveDoctor_Tbx.Text);
            }
            catch 
            {
                return null;
            }
        }

        private void informacion_Btn_Click(object sender, EventArgs e)
        {
            using (CONSULTORIOEntities1 db = new CONSULTORIOEntities1())
            {
                int? ced = getCed();
                if (ced != null)
                {
                    oDOCTOR = db.DOCTOR.Find(ced);
                    if (oDOCTOR != null)
                    {
                        ModificarOEliminarDoctorForm modificarOEliminarDoctor
                            = new ModificarOEliminarDoctorForm(ced);
                        modificarOEliminarDoctor.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el paciente");
                    }

                }

            }
        }
    }
}
