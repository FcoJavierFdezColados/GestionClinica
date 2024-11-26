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
    public partial class FrmCitaCreate : Form
    {
        
        public FrmCitaCreate()
        {
            
            InitializeComponent();
        }

        private void btnCancelarFrmCitaCreate_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FrmCitaCreate_Load(object sender, EventArgs e)
        {
            CargarDatos();
            
        }

        private void CargarDatos()
        {
            try
            {
                dtpFechaCitaFrmCitaCreate.MinDate = DateTime.Now;
                dtpFechaCitaFrmCitaCreate.Focus();
                cbPacienteFrmCitaCreate.DataSource = Data.DataPaciente.GetInstance().ListarPacientes().ToList();
                cbDoctorFrmCitaCreate.DataSource = Data.DataDoctor.GetInstance().ListarDoctores().ToList();
                cbPacienteFrmCitaCreate.DisplayMember = "NombreCompleto";
                cbDoctorFrmCitaCreate.DisplayMember = "NombreCompleto";
                cbPacienteFrmCitaCreate.ValueMember = "PacienteId";
                cbDoctorFrmCitaCreate.ValueMember = "DoctorId";
            }
            catch(SqlException ex)
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

        private void btnAceptarFrmCitaCreate_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                Modelo.Cita cita = new Modelo.Cita();
                cita.FechaCita = dtpFechaCitaFrmCitaCreate.Value;                
                cita.PacienteId = (int)cbPacienteFrmCitaCreate.SelectedValue;
                cita.DoctorId = (int) cbDoctorFrmCitaCreate.SelectedValue;
                /*
                 * Otra forma de hacerlo sería:
                 * var doctor = (Modelo.Doctor) cbDoctorFrmCitaCreate.SelectedItem;
                 * cita.DoctorId = doctor.DoctorId;
                */                
                cita.Motivo = tbMotivoCitaFrmCitaCreate.Text;

                Data.DataCita.GetInstance().InsertarCita(cita);
                MessageBox.Show("Cita reservada correctamente.");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }
        }

        private bool ValidarDatos()
        {
            if (dtpFechaCitaFrmCitaCreate.Text == "")
            {
                MessageBox.Show("El campo Fecha de la cita es obligatorio.");
                dtpFechaCitaFrmCitaCreate.Focus();
                return false;
            } 
            else if (dtpFechaCitaFrmCitaCreate.Value.DayOfWeek == DayOfWeek.Saturday)
            {
                MessageBox.Show("No se puede reservar una cita un sabado. Seleccione un día de lunes a viernes.");
                dtpFechaCitaFrmCitaCreate.Focus();
                return false;
            }
            else if (dtpFechaCitaFrmCitaCreate.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("No se puede reservar una cita un domingo. Seleccione un día de lunes a viernes.");
                dtpFechaCitaFrmCitaCreate.Focus();
                return false;
            }
            else if (cbPacienteFrmCitaCreate.Text == "")
            {
                MessageBox.Show("El campo Paciente es obligatorio.");
                cbPacienteFrmCitaCreate.Focus();
                return false;
            }
            else if (cbDoctorFrmCitaCreate.Text == "")
            {
                MessageBox.Show("El campo Doctor es obligatorio.");
                cbDoctorFrmCitaCreate.Focus();
                return false;
            }
            else if(tbMotivoCitaFrmCitaCreate.Text == "")
            {
                MessageBox.Show("El campo Motivo de la cita es obligatorio.");
                tbMotivoCitaFrmCitaCreate.Focus();
                return false;
            }

            return true;
        }
    }
}
