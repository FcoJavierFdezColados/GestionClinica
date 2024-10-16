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
            frmCitasRead.Show();
        }
    }
}
