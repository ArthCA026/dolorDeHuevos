using System;
using System.ComponentModel.DataAnnotations;

namespace Abstracciones.Modelos
{
    public class Receta
    {
        public Guid? ID { get; set; }

        [Required(ErrorMessage = "El paciente es requerido")]
        public Guid? IdPaciente { get; set; }

        [Required(ErrorMessage = "El ID del doctor es requerido")]
        public Guid? IdDoctor { get; set; }

        [Required(ErrorMessage = "La fecha de la receta es requerida")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? Fecha { get; set; }

        [Required(ErrorMessage = "El estado de la receta es requerido")]
        [RegularExpression(@"^(Digitada|Revisada|Recibida|Entregada|Preparada)$", ErrorMessage = "Estado no válido")]
        public string? Status { get; set; }

        [Required(ErrorMessage = "El consecutivo es requerido")]
        [StringLength(50, ErrorMessage = "El consecutivo no debe exceder los 50 caracteres")]
        public string Consecutivo { get; set; }

        [Required(ErrorMessage = "Las indicaciones son requeridas")]
        [StringLength(500, ErrorMessage = "Las indicaciones no deben exceder los 500 caracteres")]
        public string Indicaciones { get; set; }

        [Required(ErrorMessage = "La fecha de recibido es requerida")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? FechaRecibido { get; set; }

        // Relaciones
        public virtual Persona Paciente { get; set; }
        public virtual Persona Doctor { get; set; }
    }

}
