using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TareasASP.Models
{
    public class Tarea
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la tarea es obligatorio.")]
        [Display(Name="Nombre de la tarea")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "La descripción es obligatoria")]
        [Display(Name="Descripción")]
        public required string Description { get; set; }

        [Required(ErrorMessage = "La fecha de creación de la tarea es obligatoria.")]
        [Display(Name="Fecha de creación")]
        public required DateTime CreateDate { get; set; }

        [ForeignKey("ListaTareasId")]
        public ListaTareas? ListaTareas { get; set; }
        public int ListaTareasId { get; set; }

    }
}
