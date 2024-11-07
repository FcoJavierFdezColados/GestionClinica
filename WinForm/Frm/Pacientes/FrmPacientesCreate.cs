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

            paciente.Nombre = tbPacientesNombreFrmCreate.Text;
            paciente.Apellidos = tbPacientesApellidosFrmCreate.Text;
            paciente.Direccion = tbPacientesDireccionFrmCreate.Text;
            paciente.Poblacion = tbPacientesPoblacionFrmCreate.Text;
            paciente.CodigoPostal = tbPacientesCódigoPostalFrmCreate.Text;
            paciente.Provincia = tbPacientesProvinciaFrmCreate.Text;
            paciente.Telefono1 = tbPacientesTelefono1FrmCreate.Text;
            paciente.Telefono2 = tbPacientesTelefono2FrmCreate.Text;

            Data.DataPaciente.GetInstance().InsertarPacinte(paciente);

            MessageBox.Show("Paciente añadido correctamente");
        }
    }
}
