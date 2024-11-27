using Microsoft.Data.SqlClient;
using WinForm.Frm;

namespace WinForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            try
            {
                IniciarDatos();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al precargar los datos de la base de datos.");
                Console.Error.WriteLine(ex.StackTrace);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                Console.Error.WriteLine(ex.StackTrace);
            }

            //Application.Run(new FrmSplash());
            Application.Run(new FrmPpal());
        }

        private static void IniciarDatos()
        {
            Modelo.Paciente paciente = new Modelo.Paciente();
            paciente.Nombre = "Pedro";
            paciente.Apellidos = "Picapiedra";
            paciente.Telefono1 = "123456789";
            paciente.Direccion = "calle1";
            paciente.Poblacion = "rocavilla";
            paciente.Provincia = "Hanna Barbera";
            paciente.CodigoPostal = "33355";

            Modelo.Doctor doctor = new Modelo.Doctor();
            doctor.Nombre = "Roberto";
            doctor.Apellidos = "Romero";
            doctor.NumColegiado = "77744";

            

            var pacientes = Data.DataPaciente.GetInstance().ListarPacientes();
            var doctores = Data.DataDoctor.GetInstance().ListarDoctores();

            if(pacientes.Count == 0 && doctores.Count == 0)
            {
                Data.DataPaciente.GetInstance().InsertarPacinte(paciente);
                Data.DataDoctor.GetInstance().InsertarDoctor(doctor);
                //Aquí debajo intenté insertar una cita, pero me saltaba la excepcion sql que indico debajo.
            }

            /**
             * Nota: He intentado insertar una cita, pero cuando llega a la inserción me salta esta excepcion SQL:
             * 
             * SqlException: Cannot insert explicit value for identity column in table 'Doctores' when IDENTITY_INSERT is set to OFF.
             * Cannot insert explicit value for identity column in table 'Pacientes' when IDENTITY_INSERT is set to OFF.
             * 
             * Tanto si inserto los dato sde paciente o doctor, como si intento traermelos de base de datos (tras la insercción).
             * 
             * He investigado un poco, pero dado que es 27 / 11 y hay más asignaturas que atender. Lo voy a dejar aquí.
             */
        }
    }
}