using System;
using System.ComponentModel.DataAnnotations;

namespace Abstracciones.Entidad
{
    public class Medicamento
    {
        [Required(ErrorMessage = "El ID de la categoría es requerido")]
        public Guid IdCategoria { get; set; }

        [Required(ErrorMessage = "El nombre del medicamento es requerido")]
        [StringLength(100, ErrorMessage = "El nombre del medicamento debe tener entre 1 y 100 caracteres", MinimumLength = 1)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La cantidad es requerida")]
        [Range(0.01, 300.00, ErrorMessage = "La cantidad debe estar entre 0.01 y 300")]
        public decimal Cantidad { get; set; }
    }
}
