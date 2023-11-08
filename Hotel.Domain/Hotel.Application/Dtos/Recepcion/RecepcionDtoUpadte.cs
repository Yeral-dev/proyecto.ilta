using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Application.Dtos.Recepcion
{
  public class RecepcionDtoUpadte : RecepcionDtoBase
    {
        public int IdRecepcion { get; set; }
        
        public DateTime? ModifyDate { get; set; }
        public int? UserMod { get; set; }

    }
}
