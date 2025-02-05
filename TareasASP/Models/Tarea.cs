using System.ComponentModel.DataAnnotations;

namespace TareasASP.Models
{
    public class Tarea
    {
        public required int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la tarea es obligatorio.")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "La descripción es obligatoria")]
        public required string Description { get; set; }

        [Required(ErrorMessage = "La fecha de creación de la tarea es obligatoria.")]
        public required DateTime CreateDate { get; set; }


        public ListaTareas? ListaTareas { get; set; }
        public int ListaTareasId { get; set; }

    }
}
