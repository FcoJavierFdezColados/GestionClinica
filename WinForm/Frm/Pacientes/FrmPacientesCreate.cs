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
    public partial class FrmPacientesCreate : Form
    {
        public FrmPacientesCreate()
        {
            InitializeComponent();
        }

        private void btnFrmPacientesCreateAceptar_Click(object sender, EventArgs e)
        {
            Modelo.Paciente paciente = new Modelo.Paciente();

            if (validarCampos())
            {
                paciente.Nombre = tbPacientesNombreFrmCreate.Text;
                paciente.Apellidos = tbPacientesApellidosFrmCreate.Text;
                paciente.Direccion = tbPacientesDireccionFrmCreate.Text;
                paciente.Poblacion = tbPacientesPoblacionFrmCreate.Text;
                paciente.CodigoPostal = tbPacientesCodigoPostalFrmCreate.Text;
                paciente.Provincia = tbPacientesProvinciaFrmCreate.Text;
                paciente.Telefono1 = tbPacientesTelefono1FrmCreate.Text;
                paciente.Telefono2 = tbPacientesTelefono2FrmCreate.Text;

                Data.DataPaciente.GetInstance().InsertarPacinte(paciente);

                MessageBox.Show("Paciente añadido correctamente");
            }
            else
            {
                DialogResult = DialogResult.None;
            }

        }

        private bool validarCampos()
        {
            if(tbPacientesNombreFrmCreate.Text == "")
            {
                MessageBox.Show("El campo nombre debe estar relleno.");
                tbPacientesNombreFrmCreate.Focus();
                return false;
            }
            else if(tbPacientesApellidosFrmCreate.Text == "")
            {
                MessageBox.Show("El campo apellidos debe estar relleno.");
                tbPacientesApellidosFrmCreate.Focus();
                return false;
            }
            else if (tbPacientesDireccionFrmCreate.Text == "")
            {
                MessageBox.Show("El campo dirección debe estar relleno.");
                tbPacientesDireccionFrmCreate.Focus();
                return false;
            }
            else if (tbPacientesPoblacionFrmCreate.Text == "")
            {
                MessageBox.Show("El campo población debe estar relleno.");
                tbPacientesPoblacionFrmCreate.Focus();
                return false;
            }
            else if (tbPacientesCodigoPostalFrmCreate.Text == "")
            {
                MessageBox.Show("El campo código postal debe estar relleno.");
                tbPacientesCodigoPostalFrmCreate.Focus();
                return false;
            }
            else if (tbPacientesProvinciaFrmCreate.Text == "")
            {
                MessageBox.Show("El campo Provincia debe estar relleno.");
                tbPacientesProvinciaFrmCreate.Focus();
                return false;
            }
            else if (tbPacientesTelefono1FrmCreate.Text == "")
            {
                MessageBox.Show("El campo teléfono 1 debe estar relleno.");
                tbPacientesTelefono1FrmCreate.Focus();
                return false;
            }

            return true;
        }
    }
}
