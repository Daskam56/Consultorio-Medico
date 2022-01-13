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
    public partial class BuscarPacienteForm : Form
    {
        paciente oPaciente = null;

        public BuscarPacienteForm()
        {
            InitializeComponent();
        }


        private int? getExp() 
        {
            /*
             * La función recoge el valor del cuadro de busqueda y 
             * la convierte a entero, en caso de que no exista un valor
             * la función va a retornar nulo
             */

            try
            {
                return int.Parse(expediente_Tbx.Text);
            }
            catch 
            {
                return null;
            }
        }
       

        private void informacion_Btn_Click(object sender, EventArgs e)
        {
            int? exp = getExp();
            
            
            using (CONSULTORIOEntities1 db = new CONSULTORIOEntities1()) 
            {
                /*
                 * En caso de que la consulta no regrese valor, 
                 * el programa debería mostrar un Mensaje de no encontrado
                 */
                if (exp != null) 
                {
                    oPaciente = db.paciente.Find(exp);
                    if (oPaciente != null)
                    {
                        ModificarOEliminarPacienteForm modificarOEliminarPaciente
                            = new ModificarOEliminarPacienteForm(exp);
                        modificarOEliminarPaciente.ShowDialog();

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
