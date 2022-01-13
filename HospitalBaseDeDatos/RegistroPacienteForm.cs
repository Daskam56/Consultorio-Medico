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
    public partial class RegistroPacienteForm : Form
    {
        public RegistroPacienteForm()
        {
            InitializeComponent();
        }

        private void guardar_Btn_Click(object sender, EventArgs e)
        {
            using (CONSULTORIOEntities1 db = new CONSULTORIOEntities1())
            {
                paciente pacientev = new paciente();
                int x = Int32.Parse(claveDoctor_Tbx.Text);
                int y = Int32.Parse(expediente_Tbx.Text);
                pacientev.nombre = nombre_Tbx.Text;
                pacientev.apellidop = apellidoP_Tbx.Text;
                pacientev.apellidom = apellidoM_Tbx.Text;
                pacientev.clave_doctor = x;
                pacientev.curp = cURP_Tbx.Text;
                pacientev.sexo = sexo_Tbx.Text;
                pacientev.fecha_nacimiento = fechaNacimiento_DP.Value;
                pacientev.expediente = y;
                pacientev.telefono = telefono_Tbx.Text;
                pacientev.email = email_Tbx.Text;
                pacientev.direccion = direccion_Tbx.Text;
                pacientev.alergias = alergias_Tbx.Text;
                pacientev.ciudad = ciudad_Tbx.Text;


                db.paciente.Add(pacientev);
                db.SaveChanges();
                MessageBox.Show("Paciente dado de alta exitosamente");
            }
        }
    }
}
