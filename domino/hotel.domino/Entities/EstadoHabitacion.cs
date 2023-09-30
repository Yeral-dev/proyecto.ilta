using Hotel.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Domain.Entities
{
    public  class EstadoHabitacion: BaseEntity
    {
      public int IdEstadoHabitacion { get; set; }
      public string? Descripcion { get; set; }

    }
}
