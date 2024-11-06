using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm.Data
{
    public class DataDoctor
    {
        public static DataDoctor instance;

        public static DataDoctor GetInstance()
        {
            if(instance == null) 
                instance = new DataDoctor();

            return instance;
        }

        public List<Modelo.Doctor> ListarDoctores()
        {
            using(var context = new Modelo.GestionClinicaContextSqlServer())
            {
                return context.Doctores.ToList();
            }
        }

        public void InsertarDoctor(Modelo.Doctor doctor)
        {
            using(var context = new Modelo.GestionClinicaContextSqlServer())
            {
                context.Doctores.Add(doctor);
            }
        }

        public void ActualizarDoctor (int doctorId, Modelo.Doctor doctor)
        {
            using(var context = new Modelo.GestionClinicaContextSqlServer())
            {
                var doctorData = context.Doctores.FirstOrDefault( x => x.DoctorId == doctorId );

                if(doctorData != null)
                {
                    context.Entry(doctorData).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.Entry(doctorData).CurrentValues.SetValues(doctor);
                    context.SaveChanges();
                }
            }
        }

        public void BorrarDoctor (int doctorId)
        {
            using (var context = new Modelo.GestionClinicaContextSqlServer())
            {
                var doctorData = context.Doctores.FirstOrDefault(x => x.DoctorId == doctorId);

                if(doctorData != null)
                {
                    context.Entry(doctorData).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                    context.SaveChanges();
                }
            }
        }
    }
}
