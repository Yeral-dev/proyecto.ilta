﻿using Hotel.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Domain.Entities
{
   
    public class Habitacion : BaseEntity
    {
       public int IdHabitacion { get; set;}
       public string? Numero { get; set; }
        public string? Detalle { get; set;}
        public decimal Precio { get; set;}

        public int IdEstadoHabitacion { get; set;}
        public int IdPiso { get; set;}
        public int IdCategoria { get; set;}
    }
}
