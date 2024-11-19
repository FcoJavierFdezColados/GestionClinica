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
                Data.DataDoctor.GetInstance().ListarDoctores();
                Data.DataPaciente.GetInstance().ListarPacientes();
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
    }
}