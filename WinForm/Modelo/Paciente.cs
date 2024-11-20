using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm.Modelo
{
    public class Paciente
    {
        public int PacienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion {  get; set; }
        public string CodigoPostal { get; set; }
        public string Poblacion { get; set; } 
        public string Provincia { get; set; }
        public string Telefono1 { get; set; }
        public string? Telefono2 { get; set; }
        public string NombreCompleto
        {
            get
            {
                return $"{Apellidos}, {Nombre}";
            }
        }

        public List<Cita>? Citas { get; set; }
    }
}
