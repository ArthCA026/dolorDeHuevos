using System;
using System.ComponentModel.DataAnnotations;

namespace Abstracciones.Modelos
{
    public class RecetaMedicamento
    {
        public Guid? IdReceta { get; set; }

        [Required(ErrorMessage = "El medicamento es requerido")]
        public Guid? IdMedicamento { get; set; }

        // Propiedades de navegación
        public virtual Receta? Receta { get; set; }
        public virtual Medicamento? Medicamento { get; set; }
    }
}
