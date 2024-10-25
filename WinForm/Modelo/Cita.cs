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
        public bool EstaCancelada { get; set; }
        public DateTime FechaCancelacion { get; set; }
        public string MotivoCancelacion { get; set; }
    }
}
