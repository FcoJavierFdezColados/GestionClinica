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
                CargarDatos();
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
                    CargarDatos();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar toda la fila.");
            }
        }

        private void FrmPacientesRead_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                dgwPacientesRead.DataSource = Data.DataPaciente.GetInstance().ListarPacientes();
            }
            catch (SqlException e)
            {
                Console.Error.WriteLine(e.Message);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.StackTrace);
            }
        }

        private void tsbFrmPacientesEliminar_Click(object sender, EventArgs e)
        {
            if (dgwPacientesRead.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show
                    (
                        "¿Esta seguro de querer eliminar el registro de la tabla?",
                        "Aviso", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning
                    );
                if (result == DialogResult.OK)
                {
                    int pacienteId = (int)dgwPacientesRead.SelectedRows[0].Cells["PacienteId"].Value;
                    Data.DataPaciente.GetInstance().BorrarPaciente(pacienteId);
                    CargarDatos();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar toda la fila.");
            }
        }
    }
}
