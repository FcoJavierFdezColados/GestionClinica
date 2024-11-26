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
            tbNombreFrmPacientesCreate.Focus();
        }

        private void btnAceptarFrmPacientesCreate_Click(object sender, EventArgs e)
        {
            Modelo.Paciente paciente = new Modelo.Paciente();

            if (validarCampos())
            {
                paciente.Nombre = tbNombreFrmPacientesCreate.Text;
                paciente.Apellidos = tbApellidosFrmPacientesCreate.Text;
                paciente.Direccion = tbDireccionFrmPacientesCreate.Text;
                paciente.Poblacion = tbPoblacionFrmPacientesCreate.Text;
                paciente.CodigoPostal = tbCodigoPostalFrmPacientesCreate.Text;
                paciente.Provincia = tbProvinciaFrmPacientesCreate.Text;
                paciente.Telefono1 = tbTelefono1FrmPacientesCreate.Text;
                paciente.Telefono2 = tbTelefono2FrmPacientesCreate.Text;

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
            if (tbNombreFrmPacientesCreate.Text == "")
            {
                MessageBox.Show("El campo nombre debe estar relleno.");
                tbNombreFrmPacientesCreate.Focus();
                return false;
            }
            else if (tbApellidosFrmPacientesCreate.Text == "")
            {
                MessageBox.Show("El campo apellidos debe estar relleno.");
                tbApellidosFrmPacientesCreate.Focus();
                return false;
            }
            else if (tbDireccionFrmPacientesCreate.Text == "")
            {
                MessageBox.Show("El campo dirección debe estar relleno.");
                tbDireccionFrmPacientesCreate.Focus();
                return false;
            }
            else if (tbPoblacionFrmPacientesCreate.Text == "")
            {
                MessageBox.Show("El campo población debe estar relleno.");
                tbPoblacionFrmPacientesCreate.Focus();
                return false;
            }
            else if (tbCodigoPostalFrmPacientesCreate.Text == "")
            {
                MessageBox.Show("El campo código postal debe estar relleno.");
                tbCodigoPostalFrmPacientesCreate.Focus();
                return false;
            }
            else if (tbProvinciaFrmPacientesCreate.Text == "")
            {
                MessageBox.Show("El campo Provincia debe estar relleno.");
                tbProvinciaFrmPacientesCreate.Focus();
                return false;
            }
            else if (tbTelefono1FrmPacientesCreate.Text == "")
            {
                MessageBox.Show("El campo teléfono 1 debe estar relleno.");
                tbTelefono1FrmPacientesCreate.Focus();
                return false;
            }

            return true;
        }

        private void btnCancelarPacientesCreate_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
