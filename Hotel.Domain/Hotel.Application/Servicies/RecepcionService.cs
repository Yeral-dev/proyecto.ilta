using hotel.domino.Entities;
using Hotel.Application.Contracts;
using Hotel.Application.Core;
using Hotel.Application.Dtos.Recepcion;
using Hotel.Infrastructure.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Hotel.Application.Servicies
{
    public class RecepcionService : IRecepcionService
    {

        private readonly IRecepcion recepcion;
        private readonly ILogger<RecepcionService> logger;

        public RecepcionService(IRecepcion recepcion,
                                ILogger<RecepcionService> logger)
        {
            this.recepcion = recepcion;
            this.logger = logger;
        }
        public ServicesResult GetAll()
        {
            ServicesResult result = new ServicesResult();
            try
            {
                var Recepcion = this.recepcion.GetEntities()
                                                  .Where(co => !co.Deleted)
                                                          .Select(co => new RecepcionDtoGet()
                                                          {
                                                              IdCliente = co.IdCliente,
                                                              cliente = "",
                                                              IdHabitacion = co.IdHabitacion,
                                                              Numero = "",
                                                              FechaEntrada = co.FechaEntrada,
                                                              FechaSalida = co.FechaSalida,
                                                              FechaSalidaConfirmacion = co.FechaSalidaConfirmacion,
                                                              PrecioInicial = co.PrecioInicial,
                                                              Adelanto = co.Adelanto,
                                                              PrecioRestante = co.PrecioRestante,
                                                              TotalPagado = co.TotalPagado,
                                                              Observacion = co.Observacion,
                                                              Estado = co.Estado

                                                          });
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"Error obteniando las Recepcion";
                this.logger.LogError($"{result.Message}", ex.ToString());
            }
            return result;
        }

        public ServicesResult GetById(int id)
        {
            ServicesResult result = new ServicesResult();
            try
            {

            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"Error obteniando las Recepcion";
                this.logger.LogError($"{result.Message}", ex.ToString());
            }

            return result;
        }

        public ServicesResult Save(RecepcionDtoAdd dtoAdd)
        {
            ServicesResult result = new ServicesResult() ;
            try
            {
                RECEPCION recep = new RECEPCION()
                {
                    CreationDate = dtoAdd .CreationDate,
                    CreationUser = dtoAdd .CreationUser,
                    IdHabitacion = dtoAdd .IdHabitacion,
                 IdCliente = dtoAdd .IdCliente,
                 FechaEntrada = dtoAdd .FechaEntrada,
                 FechaSalidaConfirmacion = dtoAdd.FechaSalidaConfirmacion,
                 FechaSalida = dtoAdd .FechaSalida,
                 Adelanto = dtoAdd .Adelanto,
                 CostoPenalidad  = dtoAdd .CostoPenalidad


                };
                this.recepcion.Save(recep);
                result.Message = "";
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"Error guardando en Recepcion";
                this.logger.LogError($"{result.Message}", ex.ToString());
            }

            return result;
        }

        public ServicesResult Update(RecepcionDtoUpadte dtoUpdate)
        {
            ServicesResult result = new ServicesResult();
            try
            {
                RECEPCION recep = new RECEPCION()
                {
                   IdRecepcion = dtoUpdate .IdRecepcion,
                   UserMod = dtoUpdate .UserMod,
                   ModifyDate = dtoUpdate.ChanageDate,
                   PrecioInicial = dtoUpdate .PrecioInicial,
                   PrecioRestante = dtoUpdate .PrecioRestante,
                   TotalPagado = dtoUpdate .TotalPagado,
                   Adelanto = dtoUpdate .Adelanto,
                   



                };
                this.recepcion.Update(recep);
                result.Message = "";
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"Error Actulizado en Recepcion";
                this.logger.LogError($"{result.Message}", ex.ToString());
            }

            return result;  
        }

        ServicesResult IBaseService<RecepcionDtoAdd, RecepcionDtoUpadte, RecepcionDtoRemove>.Remove(RecepcionDtoRemove dtoRemove)
        {
            throw new NotImplementedException();
        }

        ServicesResult Remove(RecepcionDtoRemove dtoRemove)
        {
            ServicesResult result = new ServicesResult();
            try
            {
                RECEPCION recep = new RECEPCION() 
                { 
                IdRecepcion = dtoRemove.IdRecepcion,
                Deleted = dtoRemove.Deleted,
                DeletedDate = dtoRemove.DeletedDate,
                UserDeleted = dtoRemove.UserDeleted

                };
                this.recepcion.Remove(recep);
                result.Message = "";
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"Error moviendo el Recepcion";
                this.logger.LogError($"{result.Message}", ex.ToString());
            }

         
            return result;
        }




    }
}

