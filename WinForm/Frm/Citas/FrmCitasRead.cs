using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm.Frm.Citas
{
    public partial class FrmCitasRead : Form
    {
        public FrmCitasRead()
        {
            InitializeComponent();
        }

        private void tsbFrmCitasAgregar_Click(object sender, EventArgs e)
        {
            FrmCitaCreate frmCitaCreate = new FrmCitaCreate();
            DialogResult dialogResult = frmCitaCreate.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {

            }
            else if (dialogResult == DialogResult.Cancel)
            {
                frmCitaCreate.Close();
            }
        }

        private void tsbFrmCitasEditar_Click(object sender, EventArgs e)
        {
            FrmCitaUpdate frmCitaUpdate = new FrmCitaUpdate();
            DialogResult dialogResult = frmCitaUpdate.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {

            }
            else if (dialogResult == DialogResult.Cancel)
            {
                frmCitaUpdate.Close();
            }
        }

        private void tsbFrmCitasAgregar_MouseHover(object sender, EventArgs e)
        {
            tsslFrmCitasRead.Text = ((ToolStripButton)sender).Tag.ToString();
        }

        private void tsbFrmCitasAgregar_MouseLeave(object sender, EventArgs e)
        {
            tsslFrmCitasRead.Text = "";
        }

        private void tsbFrmCitasEditar_MouseHover(object sender, EventArgs e)
        {
            tsslFrmCitasRead.Text = ((ToolStripButton)sender).Tag.ToString();
        }

        private void tsbFrmCitasEditar_MouseLeave(object sender, EventArgs e)
        {
            tsslFrmCitasRead.Text = "";
        }

        private void tsbFrmCitasEliminar_MouseHover(object sender, EventArgs e)
        {
            tsslFrmCitasRead.Text = ((ToolStripButton)sender).Tag.ToString();
        }

        private void tsbFrmCitasEliminar_MouseLeave(object sender, EventArgs e)
        {
            tsslFrmCitasRead.Text = "";
        }

        private void FrmCitasRead_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void cargarDatos()
        {
            dgwCitasRead.DataSource = Data.DataCita.GetInstance().ListarCitasConDoctorPaciente();
        }

    }
}
