using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm.Modelo
{
    public class Cita
    {
        public int CitaId { get; set; }
        public DateTime FechaCita { get; set; }
        public string Motivo { get; set; }
        public bool EstaCancelada { get; set; } = false;
        public DateTime? FechaCancelacion { get; set; }
        public string? MotivoCancelacion { get; set; }

        public string NombreCompletoPaciente
        {
            get
            {
                return $"{Paciente.Apellidos}, {Paciente.Nombre}";
            }
        }

        public string NombreCompletoDoctor
        {
            get
            {
                return $"{Doctor.Apellidos}, {Doctor.Nombre}";
            }
        }

        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }

        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }
}
