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
    public partial class HistorialForm : Form
    {
        public HistorialForm()
        {
            InitializeComponent();
        }

        private void generarNota_Btn_Click(object sender, EventArgs e)
        {
            GenerarNotaForm generarNota = new GenerarNotaForm();
            generarNota.ShowDialog();
        }

        private void HistorialForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cONSULTORIODataSet.VISTA_HISTORIAL' table. You can move, or remove it, as needed.
            // this.vISTA_HISTORIALTableAdapter.Fill(this.cONSULTORIODataSet.VISTA_HISTORIAL);
            Refrescar();

        }

        private void buscar_Btn_Click(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void Refrescar()
        {
            using (CONSULTORIOEntities1 db = new CONSULTORIOEntities1())
            {
                vistaHistorial_DG.DataSource = db.VISTA_HISTORIAL.ToList();
            }
        }
    }
}
