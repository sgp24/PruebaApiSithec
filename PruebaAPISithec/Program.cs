using Microsoft.EntityFrameworkCore;
using PruebaAPISithec;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
//Se instancia la conexion a la base de datos postgreSQL
builder.Services.AddDbContext<HumanDataContext>(o=> o.UseNpgsql(builder.Configuration.GetConnectionString("HumanDb")));
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
