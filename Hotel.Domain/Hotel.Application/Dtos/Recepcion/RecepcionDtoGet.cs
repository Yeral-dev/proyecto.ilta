﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Application.Dtos.Recepcion
{
    public class RecepcionDtoGet
    {
        public int? IdCliente { get; set; }
        public string? cliente { get; set; }
        public int? IdHabitacion { get; set; }

        public string? Numero {  get; set; }

        public DateTime? FechaEntrada { get; set; }
        public DateTime? FechaSalida { get; set; }
        public DateTime? FechaSalidaConfirmacion { get; set; }
        public decimal? PrecioInicial { get; set; }
        public decimal? Adelanto { get; set; }
        public decimal? PrecioRestante { get; set; }
        public decimal? TotalPagado { get; set; }
        public decimal? CostoPenalidad { get; set; }
        public string? Observacion { get; set; }
        public bool Estado { get; set; }
    }
}
