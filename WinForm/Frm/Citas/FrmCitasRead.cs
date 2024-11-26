using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

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
                cargarDatos();
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                frmCitaCreate.Close();
            }
        }

        private void tsbFrmCitasCancelar_Click(object sender, EventArgs e)
        {

            if (dgwCitasRead.SelectedRows.Count > 0)
            {
                try
                {
                    int citaId = (int)dgwCitasRead.SelectedRows[0].Cells["CitaId"].Value;
                    FrmCitaUpdate frmCitaUpdate = new FrmCitaUpdate(citaId);
                    if (frmCitaUpdate.ShowDialog() == DialogResult.OK)
                    {
                        cargarDatos();
                    }
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show("El nombre de columna que se recibe por argumento no es el correcto.");
                    Console.Error.WriteLine(ex.StackTrace);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                    Console.Error.WriteLine(ex.StackTrace);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar toda la fila.");
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

        private void tsbFrmCitasCancelar_MouseHover(object sender, EventArgs e)
        {
            tsslFrmCitasRead.Text = ((ToolStripButton)sender).Tag.ToString();
        }

        private void tsbFrmCitasCancelar_MouseLeave(object sender, EventArgs e)
        {
            tsslFrmCitasRead.Text = "";
        }

        private void FrmCitasRead_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void cargarDatos()
        {
            try
            {

                var fechaCita = dtpFechaCitaFrmCitasRead.Value.Date;

                dgwCitasRead.DataSource = Data.DataCita.GetInstance().ListarCitas().
                    Where
                    (
                        x => x.FechaCita.Date == fechaCita
                    )
                    .OrderBy
                    (
                        x => x.NombreCompletoPaciente
                    )
                    .ToList();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                Console.Error.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                Console.Error.WriteLine(ex.StackTrace);
            }
        }

        private void dtpFechaCitaFrmCitasRead_ValueChanged(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void tbBuscarCitaFrmCitasRead_TextChanged(object sender, EventArgs e)
        {
            if (tbBuscarCitaFrmCitasRead.Text.Length > 0)
            {
                try
                {
                    dgwCitasRead.DataSource = Data.DataCita.GetInstance().ListarCitas().Where
                        (
                            x => x.NombreCompletoPaciente.ToLower().Contains(tbBuscarCitaFrmCitasRead.Text.ToLower())
                        )
                        .ToList();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ocurrio un error al buscar la cita en base de datos.");
                    Console.Error.WriteLine(ex.StackTrace);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                    Console.Error.WriteLine(ex.StackTrace);
                }
            }
            else
            {
                cargarDatos();
            }
        }
    }
}
