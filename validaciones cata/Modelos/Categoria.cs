using System;
using System.ComponentModel.DataAnnotations;

namespace Abstracciones.Modelos
{
    public class Categoria
    {
        [Required(ErrorMessage = "El ID de la categoría es requerido")]
        public Guid? ID { get; set; }

        [Required(ErrorMessage = "El nombre de la categoría es requerido")]
        [StringLength(100, ErrorMessage = "El nombre de la categoría debe tener entre 3 y 100 caracteres", MinimumLength = 3)]
        public string? Nombre { get; set; }
    }
}
