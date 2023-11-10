namespace hotel.api.Modules.Usuario
{
    public class GetUsuarioModel
    {
        public int IdUsuario { get; set; }

        public string? Nombrecompleto { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public bool? Estado { get; set; }


    }
}
