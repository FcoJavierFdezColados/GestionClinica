using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm.Data
{
    public class DataPaciente
    {
        private static DataPaciente instance;

        public static DataPaciente GetInstance()
        {
            if (instance == null)
                instance = new DataPaciente();

            return instance;
        }

        public List<Modelo.Paciente> ListarPacientes()
        {
            using (var context = new Modelo.GestionClinicaContextSqlServer())
            {
                return context.Pacientes.ToList();
            }

        }

        public void InsertarPacinte(Modelo.Paciente paciente)
        {
            try
            {
                using (var context = new Modelo.GestionClinicaContextSqlServer())
                {
                    context.Pacientes.Add(paciente);
                    context.SaveChanges();
                }
            }
            catch (SqlException ex)
            {
                Console.Error.WriteLine($"Error: {ex.Message}");
                Console.Error.WriteLine($"Stack Trace: {ex.StackTrace}");
            }
            catch (Exception ex)
            {
                Console.Error.Write($"Error: {ex.Message}");
                Console.Error.WriteLine($"Stack Trace: {ex.StackTrace}");
            }
        }

        public void ActualizarPaciente(int pacienteId, Modelo.Paciente paciente)
        {
            try
            {

                using (var context = new Modelo.GestionClinicaContextSqlServer())
                {
                    var pacienteData = context.Pacientes.FirstOrDefault(x => x.PacienteId == pacienteId);

                    if (pacienteData != null)
                    {
                        context.Entry(pacienteData).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                        context.Entry(pacienteData).CurrentValues.SetValues(paciente);
                        context.SaveChanges();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.Error.WriteLine($"Error: {ex.Message}");
                Console.Error.WriteLine($"Stack Trace: {ex.StackTrace}");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Error: {ex.Message}");
                Console.Error.WriteLine($"Stack Trace: {ex.StackTrace}");
            }
        }

        public void BorrarPaciente(int pacienteId)
        {
            try
            {

                using (var context = new Modelo.GestionClinicaContextSqlServer())
                {
                    var pacienteData = context.Pacientes.FirstOrDefault(x => x.PacienteId == pacienteId);

                    if (pacienteData != null)
                    {
                        context.Entry(pacienteData).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                        context.SaveChanges();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.Error.WriteLine($"Error: {ex.Message}");
                Console.Error.WriteLine($"Stack Trace: {ex.StackTrace}");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Error: {ex.Message}");
                Console.Error.WriteLine($"Stack Trace: {ex.StackTrace}");
            }
        }
    }
}
