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
    public partial class ModificarOEliminarDoctorForm : Form
    {
        DOCTOR oDOCTOR = null;
        public int? ced;
        
        public ModificarOEliminarDoctorForm(int? ced = null)
        {
            InitializeComponent();
            this.ced = ced;
            if (ced != null) 
            {
                cargaDatos();
            }
            
        }

        private void cargaDatos() 
        {
            using (CONSULTORIOEntities1 db = new CONSULTORIOEntities1()) 
            {
                oDOCTOR = db.DOCTOR.Find(ced);
                nombre_Tbx.Text = oDOCTOR.nombre;
                apellidoP_Tbx.Text = oDOCTOR.apellidop;
                ApellidoM_Tbx.Text = oDOCTOR.apellidom;
                especialidad_Tbx.Text = oDOCTOR.especialidad;
                email_Tbx.Text = oDOCTOR.email;
                telefono_Tbx.Text = oDOCTOR.telefono;
                id_Tbx.Text = Convert.ToString(oDOCTOR.clave_doc);
                contra_Tbx.Text = oDOCTOR.contraseña;
            }
        }

        private void guardar_Btn_Click(object sender, EventArgs e)
        {
            
        }

        private void eliminar_Btn_Click(object sender, EventArgs e)
        {
            using (CONSULTORIOEntities1 db = new CONSULTORIOEntities1())
            {
                string message = "Esta acción eliminará este registro, ¿Continuar?";
                string title = "Eliminar registro";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    //db.DOCTOR.Remove(oDOCTOR);
                    //db.SaveChanges();

                    db.Entry(oDOCTOR).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                    MessageBox.Show("Registro eliminado permanentemente");
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void guardar_Btn_Click_1(object sender, EventArgs e)
        {
            using (CONSULTORIOEntities1 db = new CONSULTORIOEntities1())
            {
                int x = Int32.Parse(id_Tbx.Text);
                oDOCTOR.clave_doc = x;
                oDOCTOR.contraseña = contra_Tbx.Text;
                oDOCTOR.nombre = nombre_Tbx.Text;
                oDOCTOR.apellidop = apellidoP_Tbx.Text;
                oDOCTOR.apellidom = ApellidoM_Tbx.Text;
                oDOCTOR.especialidad = especialidad_Tbx.Text;
                oDOCTOR.email = email_Tbx.Text;
                oDOCTOR.telefono = telefono_Tbx.Text;
                db.Entry(oDOCTOR).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
