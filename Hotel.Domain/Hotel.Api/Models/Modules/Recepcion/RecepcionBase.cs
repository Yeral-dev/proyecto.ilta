using Hotel.Api.Core;

namespace Hotel.Api.Models.Modules.Recepcion
{
    public abstract class RecepcionBase : ModelBase
    {
    
        public DateTime? CreationDate { get; set; }
        public DateTime? FechaEntrada { get; set; }
        public DateTime? FechaSalida { get; set; }
        public DateTime? FechaSalidaConfirmacion { get; set; }
        public decimal? PrecioInicial { get; set; }
        public decimal? Adelanto { get; set; }
        public decimal? PrecioRestante { get; set; }
        public decimal? TotalPagado { get; set; }
        public string? Observacion { get; set; }
        public decimal? CostoPenalidad { get; set; }
        public bool? Estado { get; set; }

    }
}
