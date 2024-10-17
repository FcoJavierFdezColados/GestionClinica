using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm.Frm.Doctores
{
    public partial class FrmDoctoresRead : Form
    {
        public FrmDoctoresRead()
        {
            InitializeComponent();
        }

        private void tsbFrmDoctoresCrear_Click(object sender, EventArgs e)
        {
            FrmDoctoresCreate frmDoctoresCreate = new FrmDoctoresCreate();

            if (frmDoctoresCreate.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void tsbFrmDoctoresEditar_Click(object sender, EventArgs e)
        {
            FrmDoctoresUpdate frmDoctoresUpdate = new FrmDoctoresUpdate();

            if(frmDoctoresUpdate.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
