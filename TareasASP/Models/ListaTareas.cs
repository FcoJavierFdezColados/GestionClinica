using System.ComponentModel.DataAnnotations;

namespace TareasASP.Models
{
    public class ListaTareas
    {
        public required int Id { get; set; }

        [Required(ErrorMessage = "El nombre de lal ista de tareas es Obligatorio")]
        public required string Name { get; set; }

        public List<Tarea>? Tareas { get; set; }


    }
}
