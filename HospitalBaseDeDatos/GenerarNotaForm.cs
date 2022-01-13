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
    public partial class GenerarNotaForm : Form
    {
        public GenerarNotaForm()
        {
            InitializeComponent();
        }

        private void guardar_Btn_Click(object sender, EventArgs e)
        {
            using (CONSULTORIOEntities1 db = new CONSULTORIOEntities1())
            {
                HISTORIAL hISTORIAL = new HISTORIAL();
                int x = Int32.Parse(expediente_Tbx.Text);
                hISTORIAL.fecha = fechaNota_DP.Value;
                hISTORIAL.expediente = x;
                hISTORIAL.medicamento = medicamento_Tbx.Text;
                hISTORIAL.nota = nota_Tbx.Text;

                db.HISTORIAL.Add(hISTORIAL);
                db.SaveChanges();
                MessageBox.Show("Nota Creada Exitosamente");
                
            }
        }

        private void cancelar_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
