
using hotel.domino.Entities;
using hotel.domino.repository;
using hotel.infractructure.context;
using hotel.infractructure.Coree;
using hotel.infractructure.interfaces;

namespace hotel.infractructure.repositories
{

    public class UsuarioRepository : BaseRepository<Usuario> , IUsuarioRepository
    {
        private readonly Hotelcontext context;

        public UsuarioRepository(Hotelcontext context) : base(context)
        { 
            this.context = context;
        }
        public override void Save(Usuario entity)
        {
            context.Usuario.Add(entity);
            context.SaveChanges();  
        }

        public override void Update(Usuario entity)
        {
            var UsuarioToUpdate = base.GetEntity(entity.IdUsuario);

            UsuarioToUpdate.NombreCompleto = entity.NombreCompleto;
            UsuarioToUpdate.FechaRegistro = entity.FechaRegistro;
            UsuarioToUpdate.FechaMod = entity.FechaMod;
            UsuarioToUpdate.IdUsuarioMod = entity.IdUsuarioMod;

            context.Usuario.Update(UsuarioToUpdate);
            context.SaveChanges();  
        }


    }

 }
