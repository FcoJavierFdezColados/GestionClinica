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
    public partial class FrmDoctoresUpdate : Form
    {
        private int _doctorId;
        private Modelo.Doctor doctor;
        public FrmDoctoresUpdate(int doctorId)
        {
            InitializeComponent();
            _doctorId = doctorId;
            try
            {
                doctor = Data.DataDoctor.GetInstance().ListarDoctores().FirstOrDefault(x => x.DoctorId == doctorId);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al obtener el registro de la base de datos. Cierre el formulario e intentelo más tarde.");
                Console.Error.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.StackTrace);
            }
        }

        private void FrmDoctoresUpdate_Load(object sender, EventArgs e)
        {
            CargarDatos(doctor);
        }

        private void btnDoctoresUpdateAceptar_Click(object sender, EventArgs e)
        {
            if(ValidarDatos() && doctor != null)
            {
                doctor.Nombre = tbNombreFrmDocUpdate.Text;
                doctor.Apellidos = tbApellidosFrmDocUpdate.Text;
                doctor.NumColegiado = tbNumColegiadoFrmDocUpdate.Text;

                Data.DataDoctor.GetInstance().ActualizarDoctor(_doctorId, doctor);

                MessageBox.Show("Doctor editado correctamente");
            }
            else
            {
                DialogResult = DialogResult.None;
            }
        }

        private bool ValidarDatos()
        {
            if (tbNombreFrmDocUpdate.Text == "")
            {
                MessageBox.Show("El campo nombre debe estar relleno.");
                tbNombreFrmDocUpdate.Focus();
                return false;
            }
            else if (tbApellidosFrmDocUpdate.Text == "")
            {
                MessageBox.Show("El campo apellidos debe estar relleno.");
                tbApellidosFrmDocUpdate.Focus();
                return false;
            }
            else if (tbNumColegiadoFrmDocUpdate.Text == "")
            {
                MessageBox.Show("El campo número de colegiado debe estar relleno.");
                tbNumColegiadoFrmDocUpdate.Focus();
                return false;
            }

            return true;
        }

        private void CargarDatos(Modelo.Doctor doctor)
        {
            if(doctor != null)
            {
                tbNombreFrmDocUpdate.Text = doctor.Nombre;
                tbApellidosFrmDocUpdate.Text = doctor.Apellidos;
                tbNumColegiadoFrmDocUpdate.Text = doctor.NumColegiado;
            }
            else
            {
                MessageBox.Show("El doctor no se encontró en la base de datos");
            }
        }
    }
}
