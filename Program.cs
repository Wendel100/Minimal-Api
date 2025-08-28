using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapGet("/", () =>
{
    return Results.Ok("Seja bem vindo");
});
app.MapGet("/login{login},{senha}", (string login, string senha) =>
{
    if (login == "@gmal.com" & senha == "24")
    {
        return Results.Ok("Login feito com sucesso...");
    }
    else
    {
        return Results.Unauthorized();
    }
});


app.Run();

class LoginDTO
{
    public LoginDTO(string login, string senha)
    {
        Login = login;
        Senha = senha;
    }

    public string Login { get; set; }
    public string Senha { get; set; }
}