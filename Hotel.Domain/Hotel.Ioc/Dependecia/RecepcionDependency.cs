using hotel.domino.Entities;
using Hotel.Infrastructure.Core;
using Hotel.Infrastructure.Interfaces;
using Hotel.Application.Servicies;
namespace Hotel.Ioc.Dependecia
{
    public static class RecepcionDependency
    {
        public static void AddRecepcionDependency(this IServiceCollection service)
        {
            service.AddScoped<IRecepcion, RECEPCION>();
            service.AddTransient<IBaseService, RecepcionService>();
        }
    }
}
