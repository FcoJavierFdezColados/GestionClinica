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
    public partial class FrmPacientesUpdate : Form
    {
        private int _pacienteId;
        private Modelo.Paciente paciente;
        public FrmPacientesUpdate(int pacienteId)
        {
            InitializeComponent();
            _pacienteId = pacienteId;
            try
            {
                paciente = Data.DataPaciente.GetInstance().ListarPacientes().FirstOrDefault(x => x.PacienteId == pacienteId);
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

        private void btnFrmPacientesUpdateAceptar_Click(object sender, EventArgs e)
        {
            if (validarCampos() && paciente != null)
            {
                paciente.Nombre = tbNombreFrmPacientesUpdate.Text;
                paciente.Apellidos = tbApellidosFrmPacientesUpdate.Text;
                paciente.Direccion = tbDireccionFrmPacientesUpdate.Text;
                paciente.Poblacion = tbPoblacionFrmPacientesUpdate.Text;
                paciente.CodigoPostal = tbCodigoPostaFrmPacientesUpdate.Text;
                paciente.Provincia = tbProvinciaFrmPacientesUpdate.Text;
                paciente.Telefono1 = tbTelofono1FrmPacientesUpdate.Text;
                paciente.Telefono2 = tbTelefono2FrmPacientesUpdate.Text;

                Data.DataPaciente.GetInstance().ActualizarPaciente(_pacienteId, paciente);

                MessageBox.Show("Paciente añadido correctamente");
            }
            else
            {
                DialogResult = DialogResult.None;
            }
        }

        private void cargarDatos(Modelo.Paciente paciente)
        {
            
            if (paciente != null)
            {
                tbNombreFrmPacientesUpdate.Text = paciente.Nombre;
                tbApellidosFrmPacientesUpdate.Text = paciente.Apellidos;
                tbDireccionFrmPacientesUpdate.Text = paciente.Direccion;
                tbPoblacionFrmPacientesUpdate.Text = paciente.Poblacion;
                tbProvinciaFrmPacientesUpdate.Text = paciente.Provincia;
                tbTelofono1FrmPacientesUpdate.Text = paciente.Telefono1;
                tbTelefono2FrmPacientesUpdate.Text = paciente.Telefono2;
                tbCodigoPostaFrmPacientesUpdate.Text = paciente.CodigoPostal;
            }
            else
            {
                MessageBox.Show("El paciente no se encontró en la base de datos");
            }
        }

        private void FrmPacientesUpdate_Load(object sender, EventArgs e)
        {
            cargarDatos(paciente);
        }

        private bool validarCampos()
        {
            if (tbNombreFrmPacientesUpdate.Text == "")
            {
                MessageBox.Show("El campo nombre debe estar relleno.");
                tbNombreFrmPacientesUpdate.Focus();
                return false;
            }
            else if (tbApellidosFrmPacientesUpdate.Text == "")
            {
                MessageBox.Show("El campo apellidos debe estar relleno.");
                tbApellidosFrmPacientesUpdate.Focus();
                return false;
            }
            else if (tbDireccionFrmPacientesUpdate.Text == "")
            {
                MessageBox.Show("El campo dirección debe estar relleno.");
                tbDireccionFrmPacientesUpdate.Focus();
                return false;
            }
            else if (tbPoblacionFrmPacientesUpdate.Text == "")
            {
                MessageBox.Show("El campo población debe estar relleno.");
                tbPoblacionFrmPacientesUpdate.Focus();
                return false;
            }
            else if (tbCodigoPostaFrmPacientesUpdate.Text == "")
            {
                MessageBox.Show("El campo código postal debe estar relleno.");
                tbCodigoPostaFrmPacientesUpdate.Focus();
                return false;
            }
            else if (tbProvinciaFrmPacientesUpdate.Text == "")
            {
                MessageBox.Show("El campo Provincia debe estar relleno.");
                tbProvinciaFrmPacientesUpdate.Focus();
                return false;
            }
            else if (tbTelofono1FrmPacientesUpdate.Text == "")
            {
                MessageBox.Show("El campo teléfono 1 debe estar relleno.");
                tbTelofono1FrmPacientesUpdate.Focus();
                return false;
            }

            return true;
        }
    }
}
