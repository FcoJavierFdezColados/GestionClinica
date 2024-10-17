using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm.Frm.Citas;
using WinForm.Frm.Doctores;
using WinForm.Frm.Pacientes;

namespace WinForm.Frm
{
    public partial class FrmPpal : Form
    {
        public FrmPpal()
        {
            InitializeComponent();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcercaDe frmAcercaDe = new FrmAcercaDe();

            if (DialogResult.OK == frmAcercaDe.ShowDialog(this))
            {
                frmAcercaDe.Close();
            }
        }

        private void citasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCitasRead frmCitasRead = new FrmCitasRead();
            frmCitasRead.MdiParent = this;
            frmCitasRead.Show();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPacientesRead frmPacientesRead = new FrmPacientesRead();
            frmPacientesRead.MdiParent = this;
            frmPacientesRead.Show();
        }

        private void doctoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDoctoresRead frmDoctoresRead = new FrmDoctoresRead();
            frmDoctoresRead.MdiParent = this;
            frmDoctoresRead.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
