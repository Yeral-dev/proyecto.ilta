using System;
using System.Collections.Generic;
using System.Text;

namespace hotel.domino.core
{
    public abstract class BaseEntity
    {
       public BaseEntity()
        {
            this.FechaRegistro = DateTime.Now;
            this.Eliminado = false;
        }
        public DateTime? FechaRegistro { get; set; }
        public int? IdUsuarioCreacion { get; set; }
        public DateTime? Fechamod { get; set; }
        public int? IdUsuarioMod { get; set; }
        public int? IdUsuarioElimino { get; set; }
        public DateTime? FechaElimio { get; set; }
        public bool? Eliminado { get; set; }
        public bool? Estado { get; set; }

    }
}

