using hotel.infractructure.context;
using hotel.infractructure.interfaces;
using hotel.infractructure.repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<IUsuarioRepository, UsuarioRepository >();


builder.Services.AddDbContext<Hotelcontext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Hotelcontext")));


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
