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
    public partial class FrmCitaUpdate : Form
    {
        /*
         * Nota: Este es el único formulario que por su diseño he deshabilitado el que se pueda maximizar y redimensionar. Tal y como están colocados los elementos
         * es difícil redimiensionarlo o reposicionarlos con las herramientas que da WinForms. Y tampoco quiero tener que rediseñarlo a última hora (27/11) como el
         * de Pacientes que era más sencillo. El proyecto ya esta terminado y solo estoy haciendo un repaso general a elementos que pueden ser útiles, como el manejo
         * del foco, revisar los try/catch de los read (ya que el resto se controlan en los Data de los crud), limpieza de búsquedas, revisión de la nomenclatura usada 
         * para elementos, etc.
         */
        private int _citaId;
        private Modelo.Cita cita;
        public FrmCitaUpdate(int citaId)
        {
            InitializeComponent();
            _citaId = citaId;

            try
            {
                cita = Data.DataCita.GetInstance().ListarCitas().FirstOrDefault(x => x.CitaId == citaId);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al obtener el registro de la base de datos. Cierre el formulario e intentelo más tarde.");
                Console.Error.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}.");
                Console.Error.WriteLine(ex.StackTrace);
            }
        }

        private void FrmCitaUpdate_Load(object sender, EventArgs e)
        {
            CargarDatos(cita);
        }

        private void CargarDatos(Modelo.Cita cita)
        {
            if (cita != null)
            {
                try
                {
                    //Datos Cita:
                    dtpFechaCitaFrmCitaUpdate.Value = cita.FechaCita;
                    tbPacienteFrmCitaUpdate.Text = cita.NombreCompletoPaciente;
                    tbDoctorFrmCitaUpdate.Text = cita.NombreCompletoDoctor;
                    tbMotivoCitaFrmCitaUpdate.Text = cita.Motivo;

                    //Datos Cancelación:
                    if (cita.EstaCancelada)
                    {
                        tbMotivoCancelFrmCitaUpdate.Enabled = false;
                        tbMotivoCancelFrmCitaUpdate.Text = cita.MotivoCancelacion;
                        dtpFechaCancelFrmCitaUpdate.Value = cita.FechaCancelacion.Value;
                    }
                    else
                    {
                        tbMotivoCancelFrmCitaUpdate.Enabled = true;
                        dtpFechaCancelFrmCitaUpdate.Value = DateTime.Now;
                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al cargar los datos desde la base de datos.");
                    Console.Error.WriteLine(ex.StackTrace);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                    Console.Error.WriteLine(ex.StackTrace);
                }
            }
        }

        private void btnAceptarFrmCitaUpdate_Click(object sender, EventArgs e)
        {
            if (cita.EstaCancelada)
            {
                MessageBox.Show("Esta cita ya se canceló");
            }
            else if (cita != null)
            {
                if (ValidarDatos())
                {
                    cita.EstaCancelada = true;
                    cita.MotivoCancelacion = tbMotivoCancelFrmCitaUpdate.Text;
                    cita.FechaCancelacion = DateTime.Now;

                    Data.DataCita.GetInstance().ActualizarCita(_citaId, cita);
                    MessageBox.Show("Cita cancelada.");
                }
                else
                {
                    this.DialogResult = DialogResult.None;
                }

            }
        }

        private bool ValidarDatos()
        {
            if (tbMotivoCancelFrmCitaUpdate.Text == "")
            {
                MessageBox.Show("El campo motivo de la cancilación es obligatorio.");
                tbMotivoCancelFrmCitaUpdate.Focus();
                return false;
            }
            return true;
        }
    }
}
