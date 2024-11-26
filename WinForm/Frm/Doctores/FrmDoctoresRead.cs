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
                try
                {
                    int doctorId = (int)DgvwDoctoresRead.SelectedRows[0].Cells["DoctorId"].Value;
                    FrmDoctoresUpdate frmDoctoresUpdate = new FrmDoctoresUpdate(doctorId);

                    if (frmDoctoresUpdate.ShowDialog() == DialogResult.OK)
                    {
                        CargarDatos();
                    }
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show("No se encontró la columna seleccionada.");
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
                    try
                    {
                        int doctorId = (int)DgvwDoctoresRead.SelectedRows[0].Cells["DoctorId"].Value;
                        Data.DataDoctor.GetInstance().BorrarDoctor(doctorId);
                        tstbBuscarFrmDocRead.Text = "";
                        CargarDatos();
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show("No se encontró la columna seleccionada.");
                        Console.Error.WriteLine(ex.StackTrace);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                        Console.Error.WriteLine(ex.StackTrace);
                    }

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
                DgvwDoctoresRead.DataSource = Data.DataDoctor.GetInstance().ListarDoctores().OrderBy(x => x.Apellidos).ToList();
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
                try
                {
                    DgvwDoctoresRead.DataSource = Data.DataDoctor.GetInstance().ListarDoctores().Where
                    (
                        x => x.Apellidos.ToLower().Contains(tstbBuscarFrmDocRead.Text.ToLower())
                    )
                    .ToList();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ocurrió un error al buscar la cita en la base de datos.");
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
                CargarDatos();
            }
        }
    }
}