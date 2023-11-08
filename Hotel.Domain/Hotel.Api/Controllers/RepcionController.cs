
using hotel.domino.Entities;
using Hotel.Api.Models.Modules.EstadoHabitacion;
using Hotel.Api.Models.Modules.Recepcion;
using Hotel.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;




namespace hotel.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepcionController : ControllerBase
    {
        private readonly IRecepcion recepcion;

        public RepcionController(IRecepcion recepcion) {
            this.recepcion = recepcion;
        }
        // GET: api/<RepcionController>
        [HttpGet("GetRECEPCION")]
        public IActionResult Get()
        {
            var recep = this.recepcion.GetEntities()
                                       .Select(st => 
                                       new GetRecepcionModel() 
                                       { 
                                        CreationDate = st.CreationDate,
                                        Estado = st.Estado,
                                        Observacion = st.Observacion,
                                        CostoPenalidad = st.CostoPenalidad,
                                        TotalPagado = st.TotalPagado,
                                        PrecioRestante = st.PrecioRestante,
                                        PrecioInicial = st.PrecioInicial,
                                        FechaSalidaConfirmacion = st.FechaSalidaConfirmacion,
                                        FechaSalida = st.FechaSalida,
                                           FechaEntrada = st.FechaEntrada,
                                          
                                       });


            return Ok(recep);
        }
        // GET api/<RepcionController>/5
        [HttpGet ("GetRECEPCIONs")]
        public IActionResult Get(int id)
        {
            var recp = this.recepcion.GetEntity(id);

            GetRecepcionModel recepcionModel = new GetRecepcionModel()
            {
                CreationDate = recp.CreationDate,
                Estado = recp.Estado,
                Observacion = recp.Observacion,
                CostoPenalidad = recp.CostoPenalidad,
                TotalPagado = recp.TotalPagado,
                PrecioRestante = recp.PrecioRestante,
                PrecioInicial = recp.PrecioInicial,
                FechaSalidaConfirmacion = recp.FechaSalidaConfirmacion,
                FechaSalida = recp.FechaSalida,
                FechaEntrada = recp.FechaEntrada,
             

            };
            return Ok(recp);
        }

        // POST api/<RepcionController>
        [HttpPost("SaveRecepcion")]
        public IActionResult Post([FromBody] GetRecepcionModel getRecepcion)
        {
            this.recepcion.Save(new RECEPCION()
            {
                CreationDate = getRecepcion.ChanageDate,
                CreationUser = getRecepcion.ChangeUser,
                FechaEntrada = getRecepcion.FechaEntrada,
                FechaSalida = getRecepcion.FechaSalida,
                FechaSalidaConfirmacion =  getRecepcion.FechaSalidaConfirmacion,
                PrecioInicial = getRecepcion.PrecioInicial,
                Adelanto = getRecepcion.Adelanto,
                Observacion = getRecepcion.Observacion,
                TotalPagado = getRecepcion.TotalPagado,
                CostoPenalidad = getRecepcion.CostoPenalidad
              
            });
            return Ok();
        }

        // PUT api/<RepcionController>/5
        [HttpPut("UpdateRecepcion")]
        public IActionResult Put( [FromBody] RecepcionUpdatesModel recepcionUpdates)
        {
            this.recepcion.Update(new RECEPCION()
            {
                ModifyDate = recepcionUpdates.ChanageDate,
                UserMod = recepcionUpdates.ChangeUser,
                FechaEntrada = recepcionUpdates.FechaEntrada,
                FechaSalida = recepcionUpdates.FechaSalida,
                FechaSalidaConfirmacion = recepcionUpdates.FechaSalidaConfirmacion,
                PrecioInicial = recepcionUpdates.PrecioInicial,
                Adelanto = recepcionUpdates.Adelanto,
                Observacion = recepcionUpdates.Observacion,
                TotalPagado = recepcionUpdates.TotalPagado,
                CostoPenalidad = recepcionUpdates.CostoPenalidad,
                IdCliente = recepcionUpdates.IdCliente,
                IdHabitacion = recepcionUpdates.IdHabitacion,
                IdRecepcion = recepcionUpdates.IdRecepcion

            });
            return Ok();
        }

        // DELETE api/<RepcionController>/5
       // [HttpDelete("{id}")]
        //public void Delete(int id)
        //{
       // }//
    }
}
