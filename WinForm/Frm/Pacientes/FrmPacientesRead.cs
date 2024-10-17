using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm.Frm.Pacientes
{
    public partial class FrmPacientesRead : Form
    {
        public FrmPacientesRead()
        {
            InitializeComponent();
        }

        private void tsbFrmPacientesCrear_Click(object sender, EventArgs e)
        {
            FrmPacientesCreate frmPacientesCreate = new FrmPacientesCreate();

            if (frmPacientesCreate.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void tsbFrmPacientesEditar_Click(object sender, EventArgs e)
        {
            FrmPacientesUpdate frmPacientesUpdate = new FrmPacientesUpdate();

            if(frmPacientesUpdate.ShowDialog() == DialogResult.OK)
            {
                
            }
        }
    }
}
