using System;
using System.ComponentModel.DataAnnotations;

namespace Abstracciones.Entidad
{
    public class RecetaMedicamento
    {
        [Required(ErrorMessage = "El ID de la receta es requerido")]
        public Guid IdReceta { get; set; }

        [Required(ErrorMessage = "El ID del medicamento es requerido")]
        public Guid IdMedicamento { get; set; }
    }
}
