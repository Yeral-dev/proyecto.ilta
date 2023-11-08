using hotel.domino.Entities;
using Hotel.Domain.Core;
using Hotel.Infrastructure.Context;
using Hotel.Infrastructure.Core;
using Hotel.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Hotel.Infrastructure.Repositories
{
    public class RecepcionRepository :IBaseService<RECEPCION> ,IRecepcion
    {
        private readonly Hotelcontex _context;

        public RecepcionRepository(Hotelcontex context) : base(context)
        {
            _context = context;
        }
        public override void Save(RECEPCION entity)
        {
            _context.RECEPCION.Add(entity);
            _context.SaveChanges();

        }
        public override void Update(RECEPCION entity)
        {

          
            var RecepcionToUpdate = base.GetEntity(entity.IdRecepcion);
            RecepcionToUpdate.UserMod = entity.UserMod;
            RecepcionToUpdate.ModifyDate = entity.ModifyDate;
            RecepcionToUpdate.Estado = entity.Estado;
            _context.RECEPCION.Update(RecepcionToUpdate);
            _context.SaveChanges();
        }
        public override void Remove(RECEPCION entity)
        {
            RECEPCION rECEPCION = this.GetEntity(entity.IdRecepcion);
            rECEPCION.IdRecepcion = entity.IdRecepcion;
            rECEPCION.Deleted = entity.Deleted;
            rECEPCION.DeletedDate = entity.DeletedDate;
            rECEPCION.UserDeleted = entity.UserDeleted;
            this._context.Update(rECEPCION);
            this._context.SaveChanges();
        }


    }
    }

