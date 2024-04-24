using System;
using System.ComponentModel.DataAnnotations;

namespace Abstracciones.Modelos
{
    public class Persona
    {
        [Required(ErrorMessage = "El ID de la persona es requerido")]
        public Guid? ID { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(250, ErrorMessage = "El nombre debe tener entre 2 y 250 caracteres", MinimumLength = 2)]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "La cédula es requerida")]
        [StringLength(15, ErrorMessage = "La cédula debe tener entre 8 y 15 caracteres", MinimumLength = 8)]
        [RegularExpression("^[0-9]+$", ErrorMessage = "La cédula debe contener solo números")]
        public string? Cedula { get; set; }

        public bool? Seguro { get; set; }

        [Required(ErrorMessage = "El primer apellido es requerido")]
        [StringLength(50, ErrorMessage = "El apellido debe tener entre 2 y 50 caracteres", MinimumLength = 2)]
        public string? Apellido1 { get; set; }

        [StringLength(50, ErrorMessage = "El segundo apellido debe tener entre 2 y 50 caracteres", MinimumLength = 2)]
        public string? Apellido2 { get; set; }

        [Required(ErrorMessage = "El correo es requerido")]
        [EmailAddress(ErrorMessage = "Formato de correo no válido")]
        [StringLength(100, ErrorMessage = "El correo debe tener entre 1 y 100 caracteres", MinimumLength = 1)]
        public string? Correo { get; set; }

        [Required(ErrorMessage = "El tipo es requerido")]
        [StringLength(50, ErrorMessage = "El tipo debe estar entre 1 y 50 caracteres", MinimumLength = 1)]
        public string? Tipo { get; set; }
    }
}
