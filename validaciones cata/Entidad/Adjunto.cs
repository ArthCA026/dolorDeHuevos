using System;

namespace Abstracciones.Entidad
{
    public class Adjunto
    {
        public Guid? IdReceta { get; set; }
        public byte[] Base64 { get; set; }
        public bool? Firma { get; set; }

    }
}
