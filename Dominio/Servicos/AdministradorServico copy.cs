using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Minimal_Api.Dominio.DTOs;
using Minimal_Api.Dominio.Entidades;
using Minimal_Api.Infraestrutura.Db;

namespace Minimal_Api.Dominio.Servicos;

public class AdministradorServico : IAdministradorServico
{
    private readonly DbContexto _db;
    public AdministradorServico(DbContexto db)
    {
        _db = db;
    }

    public List<Administrador> Login(LoginDTO login)
    {
        throw new NotImplementedException();
    }
}