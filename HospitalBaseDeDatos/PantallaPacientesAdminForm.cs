﻿using System;
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
    public partial class PantallaPacientesAdminForm : Form
    {
        public PantallaPacientesAdminForm()
        {
            InitializeComponent();
        }

        private void PantallaPacientesAdminForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cONSULTORIODataSet.VISTA_PACIENTES' table. You can move, or remove it, as needed.
            //this.vISTA_PACIENTESTableAdapter.Fill(this.cONSULTORIODataSet.VISTA_PACIENTES);
            Refrescar();

        }

        private void refrescar_Btn_Click(object sender, EventArgs e)
        {
            //this.vISTA_PACIENTESTableAdapter.Fill(this.cONSULTORIODataSet.VISTA_PACIENTES);
            Refrescar();
        }

        private void Refrescar()
        {
            using (CONSULTORIOEntities1 db = new CONSULTORIOEntities1())
            {
                pacientesGeneral_DG.DataSource = db.VISTA_PACIENTES.ToList();
            }
        }
    }
}
