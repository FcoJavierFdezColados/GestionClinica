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

        private void tsslStatusFrmPpal_MouseHover(object sender, EventArgs e)
        {

        }

        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MdiChildren.Length > 0)
            {
                string message = "Tiene formularios abiertos. Le recomendamos que guarde los datos y cierre los formularios antes de cerrar la aplicación. ¿Desea cerrar la aplicación pese a ello?";
                var result = MessageBox.Show(message, "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                
                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }

            }
        }

        private void pacientesToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            tsslStatusFrmPpal.Text = ((ToolStripMenuItem)sender).Tag.ToString();
        }

        private void pacientesToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            tsslStatusFrmPpal.Text = "";
        }

        private void doctoresToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            tsslStatusFrmPpal.Text = ((ToolStripMenuItem)sender).Tag.ToString();
        }

        private void doctoresToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            tsslStatusFrmPpal.Text = "";
        }

        private void citasToolStripMenuItem1_MouseHover(object sender, EventArgs e)
        {
            tsslStatusFrmPpal.Text = ((ToolStripMenuItem)sender).Tag.ToString();
        }

        private void citasToolStripMenuItem1_MouseLeave(object sender, EventArgs e)
        {
            tsslStatusFrmPpal.Text = "";
        }
    }
}
