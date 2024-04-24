using System;
using System.ComponentModel.DataAnnotations;

namespace Abstracciones.Modelos
{
    public class Medicamento
    {
        [Required(ErrorMessage = "El ID del medicamento es requerido")]
        public Guid? ID { get; set; }

        [Required(ErrorMessage = "El ID de la categoría es requerido")]
        public Guid? IdCategoria { get; set; }

        [Required(ErrorMessage = "El nombre del medicamento es requerido")]
        [StringLength(100, ErrorMessage = "El nombre del medicamento debe tener entre 3 y 100 caracteres", MinimumLength = 3)]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "La cantidad del medicamento es requerida")]
        [Range(0.01, 300.00, ErrorMessage = "La cantidad debe estar entre 0.01 y 300")]
        public decimal? Cantidad { get; set; }

        // Relación con Categorias
        public virtual Categoria? Categoria { get; set; }
    }
}
