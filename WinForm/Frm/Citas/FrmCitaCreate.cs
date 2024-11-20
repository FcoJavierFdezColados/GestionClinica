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
            dtpFechaCitaFrmCitaCreate.MinDate = DateTime.Now;
            dtpFechaCitaFrmCitaCreate.Focus();
            cbPacienteFrmCitaCreate.DataSource = Data.DataPaciente.GetInstance().ListarPacientes().ToList();
            cbDoctorFrmCitaCreate.DataSource = Data.DataDoctor.GetInstance().ListarDoctores().ToList();
            cbPacienteFrmCitaCreate.DisplayMember = "NombreCompleto";
            cbDoctorFrmCitaCreate.DisplayMember = "NombreCompleto";
            cbPacienteFrmCitaCreate.ValueMember = "PacienteId";
            cbDoctorFrmCitaCreate.ValueMember = "DoctorId";
        }

        private void btnAceptarFrmCitaCreate_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                Modelo.Cita cita = new Modelo.Cita();
                cita.FechaCita = dtpFechaCitaFrmCitaCreate.Value;
                MessageBox.Show(cbPacienteFrmCitaCreate.SelectedValue.ToString());
                cita.PacienteId = (int)cbPacienteFrmCitaCreate.SelectedValue;
                cita.DoctorId = (int) cbDoctorFrmCitaCreate.SelectedValue;
                /*
                 * Otra forma de hacerlo sería:
                 * var doctor = (Modelo.Doctor) cbDoctorFrmCitaCreate.SelectedItem;
                 * cita.DoctorId = doctor.DoctorId;
                */
                MessageBox.Show(cita.DoctorId.ToString());
                cita.Motivo = tbMotivoCitaFrmCitaCreate.Text;

                Data.DataCita.GetInstance().InsertarCita(cita);
                MessageBox.Show("Cita creada correctamente");
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
