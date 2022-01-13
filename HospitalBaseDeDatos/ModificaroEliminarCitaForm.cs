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
    public partial class ModificaroEliminarCitaForm : Form
    {
        CITA oCITA;
        public int? key;


        public ModificaroEliminarCitaForm(int? key = null)
        {
            InitializeComponent();
            this.key = key;
            if (key != null) 
            {
                cargaDatos();
            }
            
        }

        private void cargaDatos() 
        {
            using (CONSULTORIOEntities1 db = new CONSULTORIOEntities1()) 
            {
                oCITA = db.CITA.Find(key);
                horaFinCita_Tbx.Text = oCITA.hora_termino;
                inicioCita_Tbx.Text = oCITA.hora_inicio;
                expediente_Tbx.Text = Convert.ToString(oCITA.expediente);
                claveDoctor_Tbx.Text = Convert.ToString(oCITA.clave_doc);
            }

        }

        private void button1_Click(object sender, EventArgs e)
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (CONSULTORIOEntities1 db = new CONSULTORIOEntities1()) 
            {
                string message = "Esta acción eliminará este registro, ¿Continuar?";
                string title = "Eliminar registro";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    //En desuso debido a errores en SQL
                    //db.CITA.Remove(oCITA);
                    //db.SaveChanges();

                    db.Entry(oCITA).State = System.Data.Entity.EntityState.Deleted;
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
