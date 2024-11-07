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
            using(var context = new Modelo.GestionClinicaContextSqlServer())
            {
                context.Pacientes.Add(paciente);
                context.SaveChanges();
            }
        }

        public void ActualizarPaciente(int pacienteId, Modelo.Paciente paciente)
        {
            using (var context = new Modelo.GestionClinicaContextSqlServer())
            {
                var pacienteData = context.Pacientes.FirstOrDefault( x => x.PacienteId == pacienteId ); 

                if (pacienteData != null)
                {
                    context.Entry(pacienteData).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.Entry(pacienteData).CurrentValues.SetValues(paciente);
                    context.SaveChanges();
                }
            }
        }

        public void BorrarPaciente(int pacienteId)
        {
            using(var context = new Modelo.GestionClinicaContextSqlServer())
            {
                var pacienteData = context.Pacientes.FirstOrDefault( x => x.PacienteId == pacienteId );

                if(pacienteData != null)
                {
                    context.Entry(pacienteData).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                    context.SaveChanges();
                }
            }
        }
    }
}
