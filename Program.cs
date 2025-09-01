using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Minimal_Api.Dominio.DTOs;
using Minimal_Api.Dominio.Entidades;
using Minimal_Api.Dominio.Servicos;
using Minimal_Api.Infraestrutura.Db;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IAdministradorServico, AdministradorServico>();
builder.Services.AddDbContext<DbContexto>(
    Options =>
    {
        Options.UseMySql(
            builder.Configuration.GetConnectionString("conexao"),
            ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("conexao")
            ));
    }
);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.MapGet("/", () =>
{
    return Results.Ok("Faz acontecer");
});
app.MapPost("/login", ([FromBody] LoginDTO loginDTO, IAdministradorServico admin) =>
{
    if (admin.Login(loginDTO)!= null)
    {
        return Results.Ok("Login feito com sucesso");
    }
    else
    {
        return Results.Unauthorized();
    }
});

app.UseHttpsRedirection();
app.Run();