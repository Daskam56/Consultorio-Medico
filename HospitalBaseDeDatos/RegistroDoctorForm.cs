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
    public partial class RegistroDoctorForm : Form
    {
        public RegistroDoctorForm()
        {
            InitializeComponent();
        }

        private void guardar_Btn_Click(object sender, EventArgs e)
        {
            using (CONSULTORIOEntities1 db = new CONSULTORIOEntities1())
            {
                DOCTOR dOCTOR = new DOCTOR();
                int x = Int32.Parse(id_Tbx.Text);
                dOCTOR.clave_doc = x;
                dOCTOR.contraseña = contra_Tbx.Text;
                dOCTOR.nombre = nombre_Tbx.Text;
                dOCTOR.apellidop = apellidoP_Tbx.Text;
                dOCTOR.apellidom = ApellidoM_Tbx.Text;
                dOCTOR.especialidad = especialidad_Tbx.Text;
                dOCTOR.email = email_Tbx.Text;
                dOCTOR.telefono = telefono_Tbx.Text;


                db.DOCTOR.Add(dOCTOR);
                db.SaveChanges();
                MessageBox.Show("Doctor dado de alta exitosamente");
                
            }
        }
    }
}
