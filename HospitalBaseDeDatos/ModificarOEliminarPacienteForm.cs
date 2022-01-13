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
    public partial class ModificarOEliminarPacienteForm : Form
    {
        paciente oPaciente = null;
        public int? exp;
        

        public ModificarOEliminarPacienteForm( int? exp = null)
        {
            InitializeComponent();
            this.exp = exp;
            if (exp != null) 
            {
                CargaDatos();
            }
            
        }

        private void CargaDatos() 
        {
            using (CONSULTORIOEntities1 db = new CONSULTORIOEntities1()) 
            {
                oPaciente = db.paciente.Find(exp);

                nombre_Tbx.Text = oPaciente.nombre;
                apellidoP_Tbx.Text = oPaciente.apellidop;
                apellidoM_Tbx.Text = oPaciente.apellidom;
                claveDoctor_Tbx.Text = Convert.ToString(oPaciente.clave_doctor);
                cURP_Tbx.Text = oPaciente.curp;
                sexo_Tbx.Text = oPaciente.sexo;
                fechaNacimiento_DP.Value = oPaciente.fecha_nacimiento;
                telefono_Tbx.Text = oPaciente.telefono;
                email_Tbx.Text = oPaciente.email;
                direccion_Tbx.Text = oPaciente.direccion;
                alergias_Tbx.Text = oPaciente.alergias;
                ciudad_Tbx.Text = oPaciente.ciudad;
                expediente_Tbx.Text = Convert.ToString(oPaciente.expediente);


            }
        }

        private void guardar_Btn_Click(object sender, EventArgs e)
        {
            using (CONSULTORIOEntities1 db = new CONSULTORIOEntities1()) 
            {
                int x = Int32.Parse(claveDoctor_Tbx.Text);
                int y = Int32.Parse(expediente_Tbx.Text);
                oPaciente.nombre = nombre_Tbx.Text;
                oPaciente.apellidop = apellidoP_Tbx.Text;
                oPaciente.apellidom = apellidoM_Tbx.Text;
                oPaciente.clave_doctor = x;
                oPaciente.curp = cURP_Tbx.Text;
                oPaciente.sexo = sexo_Tbx.Text;
                oPaciente.fecha_nacimiento = fechaNacimiento_DP.Value;
                oPaciente.expediente = y;
                oPaciente.telefono = telefono_Tbx.Text;
                oPaciente.email = email_Tbx.Text;
                oPaciente.direccion = direccion_Tbx.Text;
                oPaciente.alergias = alergias_Tbx.Text;
                oPaciente.ciudad = ciudad_Tbx.Text;
                db.Entry(oPaciente).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
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
                    //db.paciente.Remove(oPaciente);
                    //db.SaveChanges();

                    db.Entry(oPaciente).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                    MessageBox.Show("Registro eliminado permanentemente");
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
