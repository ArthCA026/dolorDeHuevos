using System;
using System.ComponentModel.DataAnnotations;

namespace Abstracciones.Modelos
{
    public class RecetaMedicamento
    {
        [Required(ErrorMessage = "El ID de la receta es requerido")]
        public Guid? IdReceta { get; set; }

        [Required(ErrorMessage = "El ID del medicamento es requerido")]
        public Guid? IdMedicamento { get; set; }

        // Propiedades de navegación
        public virtual Receta? Receta { get; set; }
        public virtual Medicamento? Medicamento { get; set; }
    }
}
