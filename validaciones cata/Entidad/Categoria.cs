using System;
using System.ComponentModel.DataAnnotations;

namespace Abstracciones.Entidad
{
    public class Categoria
    {
        [Required(ErrorMessage = "El nombre de la categoría es requerido")]
        [StringLength(100, ErrorMessage = "El nombre de la categoría debe tener entre 1 y 100 caracteres", MinimumLength = 1)]
        public string Nombre { get; set; }
    }
}
