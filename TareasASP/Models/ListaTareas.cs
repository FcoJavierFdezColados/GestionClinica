using System.ComponentModel.DataAnnotations;

namespace TareasASP.Models
{
    public class ListaTareas
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de lal ista de tareas es Obligatorio")]
        [Display(Name = "Nombre de la lista")]
        public required string Name { get; set; }

        public List<Tarea>? Tareas { get; set; }


    }
}
