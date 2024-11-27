using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinForm.ViewModel
{
    /*
     * Nota: Inicialmente use un ViewModel para personalizar la lista de citas en el read. Pero en vista de que era más sencillo declarar una propedad NombreCompleto
     * con solo get como en Pacientes y Doctores, al final opté por hacer eso para citas también. Dejo esto como alternativa a lo que hubiese hecho en un principio.
     */
    public class CitaViewModel
    {
        public int CitaId { get; set; }
        public DateTime FechaCita { get; set; }
        public string Motivo { get; set; }
        public bool EstaCancelada { get; set; } = false;
        public DateTime? FechaCancelacion { get; set; }
        public string? MotivoCancelacion { get; set; }

        public string NombreCompletoPaciente { get; set; }

        public string NombreCompletoDoctor { get; set; }
        
    }
}
