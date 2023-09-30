using hotel.domino.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace hotel.infractructure.context
{
    internal class Hotel
    {
        internal class Hotelcontex : DbContext
        {
            public Hotelcontex(DbContextOptions<Hotelcontex> options) : base(options)
            {

            }
            public DbSet<Usuario> Usuarios { get; set; }

        }
    }
}
