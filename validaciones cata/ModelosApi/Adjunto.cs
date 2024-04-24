using System;

namespace Abstracciones.Modelos
{
    public class Adjunto
    {
        public Guid? ID { get; set; }
        public Guid? IdReceta { get; set; }
        public byte[]? Base64 { get; set; }
        public bool? Firma { get; set; }

        // Propiedad de navegación
        public virtual Receta? Receta { get; set; }
    }
}
