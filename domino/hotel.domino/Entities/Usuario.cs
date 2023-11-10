
using hotel.domino.core;
using System;
using System.ComponentModel.DataAnnotations;

namespace hotel.domino.Entities
{
    public class  Usuario : BaseEntity

    {
        
        public int? IdRolUsuario {  get; set; }
        [Key]
        public int IdUsuario { get; set; }
        
        public string? NombreCompleto { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public string? Clave { get; set; }

       public string? Correo { get; set; }   
    }
}
