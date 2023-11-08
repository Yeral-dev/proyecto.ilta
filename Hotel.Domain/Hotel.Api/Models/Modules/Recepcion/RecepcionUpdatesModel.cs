namespace Hotel.Api.Models.Modules.Recepcion
{
    public class RecepcionUpdatesModel : RecepcionBase
    {

        public int IdRecepcion { get; set; }
        public int? IdCliente { get; set; }
        public int? IdHabitacion { get; set; }
        
      
    }
}
