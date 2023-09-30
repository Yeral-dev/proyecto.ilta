using hotel.domino.core;
using System;
using System.Collections.Generic;
using System.Text;

namespace hotel.domino.Entities
{
    public class Usuario : BaseEntity
    {

        public string? NombreCompleto { get; set; }

        public string? Correo { get; set; }

        public string? clave { get; set; }

    }
}
