using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinForm.ViewModel
{
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
