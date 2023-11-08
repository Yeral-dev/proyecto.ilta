


using hotel.domino.Entities;
using Microsoft.EntityFrameworkCore;


namespace Hotel.Infrastructure.Context
{
    public class Hotelcontex : DbContext
    {
        public Hotelcontex(DbContextOptions<Hotelcontex> options) : base(options) { }

        public DbSet<RECEPCION> RECEPCION { get; set; }
       

      
    }
}
