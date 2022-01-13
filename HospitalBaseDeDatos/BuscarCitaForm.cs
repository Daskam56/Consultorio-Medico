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
    public partial class BuscarCitaForm : Form
    {
        CITA oCITA = null;
        
        public BuscarCitaForm()
        {
            InitializeComponent();
        }

        private int? getKey() 
        {
            try
            {
                return int.Parse(textBox1.Text);
            }
            catch 
            {
                return null;
            }
        }

        private void informacion_Btn_Click(object sender, EventArgs e)
        {
           //EN DESUSO
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (CONSULTORIOEntities1 db = new CONSULTORIOEntities1())
            {
                int? key = getKey();
                oCITA = db.CITA.Find(key);
                if (key != null)
                {
                    oCITA = db.CITA.Find(key);
                    if (oCITA != null)
                    {
                        ModificaroEliminarCitaForm modificaroEliminarCitaForm =
                            new ModificaroEliminarCitaForm(key);
                        modificaroEliminarCitaForm.Show();

                    }
                    else
                    {
                        MessageBox.Show("No se encontró la cita");
                    }

                }

            }
        }
    }
}
