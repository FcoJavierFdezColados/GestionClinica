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
                CargarDatos();
            }
        }

        private void tsbFrmDoctoresEditar_Click(object sender, EventArgs e)
        {
            if (DgvwDoctoresRead.SelectedRows.Count > 0)
            {
                int doctorId = (int)DgvwDoctoresRead.SelectedRows[0].Cells["DoctorId"].Value;
                FrmDoctoresUpdate frmDoctoresUpdate = new FrmDoctoresUpdate(doctorId);

                if (frmDoctoresUpdate.ShowDialog() == DialogResult.OK)
                {
                    CargarDatos();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar toda la fila.");
            }
        }

        private void FrmDoctoresRead_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void tsbFrmDoctoresEliminar_Click(object sender, EventArgs e)
        {
            if (DgvwDoctoresRead.Rows.Count > 0)
            {
                var result = MessageBox.Show
                    (
                        "¿Esta seguro de querer eliminar el registro de la tabla?",
                        "Aviso", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning
                    );
                if (result == DialogResult.OK)
                {
                    int doctorId = (int)DgvwDoctoresRead.SelectedRows[0].Cells["DoctorId"].Value;
                    Data.DataDoctor.GetInstance().BorrarDoctor(doctorId);
                    CargarDatos();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar toda la fila.");
            }
        }

        private void CargarDatos()
        {
            try
            {
                DgvwDoctoresRead.DataSource = Data.DataDoctor.GetInstance().ListarDoctores();
            }
            catch (SqlException ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.StackTrace);
            }
        }

        private void tstbBuscarFrmDocRead_TextChanged(object sender, EventArgs e)
        {
            if (tstbBuscarFrmDocRead.Text.Length > 0)
            {
                DgvwDoctoresRead.DataSource = Data.DataDoctor.GetInstance().ListarDoctores().Where
                (
                    x => x.Apellidos.ToLower().Contains(tstbBuscarFrmDocRead.Text.ToLower())
                )
                .ToList();
            }
            else
            {
                CargarDatos();
            }
        }
    }
}
