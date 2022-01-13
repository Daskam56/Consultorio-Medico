using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using HospitalBaseDeDatos.BD;

namespace HospitalBaseDeDatos
{
    public partial class IniciarSesionForm : Form
    {
        public IniciarSesionForm()
        {
            InitializeComponent();
        }

        private void crearCuenta_Lbl_Click(object sender, EventArgs e)
        {
            CrearCuentaForm crearCuenta = new CrearCuentaForm();
            crearCuenta.Show();
        }

        private void entrarAdmin_Btn_Click(object sender, EventArgs e)
        {
            if (usuario_Tbx.Text == "admin")
            {
                if (contraseña_Tbx.Text == "123")
                {
                    PantallaPrincipalAdminForm pantallaPrincipalAdminForm = new PantallaPrincipalAdminForm();
                    pantallaPrincipalAdminForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("contraseña incorrecta");
                }

            }
            else
            {
                MessageBox.Show("usuario incorrecto");
            }
        }

        private void ingresar_Btn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(usuario_Tbx.Text);
            var contra = contraseña_Tbx.Text;
            using (CONSULTORIOEntities1 db = new CONSULTORIOEntities1())
            {
                var d = db.DOCTOR.FirstOrDefault(u=> u.clave_doc==id);
                if (id != null)
                {
                    if (d.contraseña == contra)
                    {
                        PantallaPrincipalDoctorForm pantallaPrincipalDoctor = new PantallaPrincipalDoctorForm();
                        pantallaPrincipalDoctor.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("usuario no encontrado");
                    }
                       
                }
            }
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            using (CONSULTORIOEntities1 db = new CONSULTORIOEntities1()) 
            {
                int x = Int32.Parse(expediente_Tbx.Text);
                int y = Int32.Parse(claveDoctor_Tbx.Text);
                oCITA.hora_termino = horaFinCita_Tbx.Text;
                oCITA.hora_inicio = inicioCita_Tbx.Text;
                oCITA.expediente = x;
                oCITA.clave_doc = y;

                db.Entry(oCITA).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }*/
    }
}
