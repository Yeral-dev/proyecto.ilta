using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Application.Dtos.Recepcion
{
    internal class RecepcionDtoRemove
    {
        public int IdRecepcion { get; set; }
        public int? UserDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool Deleted { get; set; }
    }
}
