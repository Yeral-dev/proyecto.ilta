using hotel.domino.Entities;
using Microsoft.EntityFrameworkCore;

namespace hotel.infractructure.context
{
    
        public class Hotelcontext : DbContext
        {
            public Hotelcontext(DbContextOptions<Hotelcontext> options) : base(options)
            {

            }
            public DbSet<Usuario> Usuario { get; set; }

        }
    
}
