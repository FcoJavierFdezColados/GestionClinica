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
                Data.DataDoctor.GetInstance().ListarDoctores();
                Data.DataPaciente.GetInstance().ListarPacientes();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al precargar los datos.");
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
            Modelo.Usuario usuario = new Modelo.Usuario();
            usuario.Nombre = "Administrador";
            usuario.Apellidos = "Administrador";
            usuario.NombreUsuario = "admin";
            usuario.EstaBloqueado = false;
            usuario.Password = Auxiliar.Password.GetInstance().GenerarHash("123456");

            Data.DataUsuario.GetInstance().InsertarUsuario(usuario);
        }
    }
}