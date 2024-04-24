using System;
using System.ComponentModel.DataAnnotations;

namespace Abstracciones.Modelos
{
    public class MedicamentoDetalle
    {
        [Required(ErrorMessage = "El ID del medicamento es requerido")]
        public Guid? IdMedicamento { get; set; }

        [Required(ErrorMessage = "El nombre del medicamento es requerido")]
        [StringLength(100, ErrorMessage = "El nombre debe tener entre 3 y 100 caracteres", MinimumLength = 3)]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "La cantidad del medicamento es requerida")]
        [Range(0.01, 10000.00, ErrorMessage = "La cantidad debe estar entre 0.01 y 10000")]
        public decimal? Cantidad { get; set; }

        [Required(ErrorMessage = "La categoría del medicamento es requerida")]
        [StringLength(100, ErrorMessage = "El nombre de la categoría debe tener entre 3 y 100 caracteres", MinimumLength = 3)]
        public string? Categoria { get; set; }
    }
}
