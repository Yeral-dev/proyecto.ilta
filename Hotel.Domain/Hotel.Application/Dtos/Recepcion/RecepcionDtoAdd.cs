using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Application.Dtos.Recepcion
{
   public class RecepcionDtoAdd : RecepcionDtoBase
    {

   
        public DateTime? CreationDate { get; set; }

        public int? CreationUser { get; set; }

    }
}
