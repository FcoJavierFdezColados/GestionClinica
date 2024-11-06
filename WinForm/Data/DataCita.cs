using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm.Data
{
    public class DataCita
    {
        private static DataCita instance;

        public static DataCita GetInstance()
        {
            if (instance == null)
                instance = new DataCita();

            return instance;
        }

        public List<Modelo.Cita> ListarCitas()
        {
            using(var context = new Modelo.GestionClinicaContextSqlServer())
            {
                return context.Citas.ToList();
            }
        }

        public void InsertarCita(Modelo.Cita cita)
        {
            using(var context = new Modelo.GestionClinicaContextSqlServer())
            {
                context.Citas.Add(cita);
                context.SaveChanges();
            }
        }

        public void ActualizarCita(int citaId, Modelo.Cita cita)
        {
            using(var context = new Modelo.GestionClinicaContextSqlServer())
            {
                var citaData = context.Citas.FirstOrDefault( x => x.CitaId == citaId );

                if (citaData != null)
                {
                    context.Entry(citaData).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.Entry(citaData).CurrentValues.SetValues(cita);
                    context.SaveChanges();
                }

            }
        }
    }
}
