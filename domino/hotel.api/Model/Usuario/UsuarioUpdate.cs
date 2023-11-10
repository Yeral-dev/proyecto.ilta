namespace hotel.api.Model.Usuario
{
    public class UsuarioUpdate
    {
        public int IdUsuario { get; set; } 
        public string? FirstName { get; set; }   

        public DateTime? FechaRegistro { get; set; }

        public int? IdUsuarioMod { get; set; }

        public DateTime? FechaMod { get; set; }

    }
}
