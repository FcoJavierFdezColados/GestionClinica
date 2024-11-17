using Microsoft.Data.SqlClient;
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
                cargarDatos();
            }
        }

        private void tsbFrmPacientesEditar_Click(object sender, EventArgs e)
        {
            if (dgwPacientesRead.SelectedRows.Count > 0)
            {
                int pacienteId = (int)dgwPacientesRead.SelectedRows[0].Cells["PacienteId"].Value;
                FrmPacientesUpdate frmPacientesUpdate = new FrmPacientesUpdate(pacienteId);

                if (frmPacientesUpdate.ShowDialog() == DialogResult.OK)
                {
                    cargarDatos();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar toda la fila.");
            }
        }

        private void FrmPacientesRead_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void cargarDatos()
        {
            try
            {
                dgwPacientesRead.DataSource = Data.DataPaciente.GetInstance().ListarPacientes();
            }

            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
