using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Minimal_Api.Dominio.DTOs;
using Minimal_Api.Dominio.Entidades;
using Minimal_Api.Infraestrutura.Db;

namespace Minimal_Api.Dominio.Servicos;

public class VeiculoSerico : IVeiculoServico
{
    private readonly DbContexto _db;
    public VeiculoSerico(DbContexto db)
    {
        _db = db;
    }

    public void Apagar(Veiculo veiculo)
    {
        _db.Remove(veiculo);
        _db.SaveChanges();
    }

    public void Atualizar(Veiculo veiculo)
    {
        throw new NotImplementedException();
    }

    public Veiculo BuscarId(int id)
    {
        throw new NotImplementedException();
    }

    public void Incluir(Veiculo veiculo)
    {
        throw new NotImplementedException();
    }

    public List<Veiculo> Lista(int pagina = 1, string? nome = null, string? marca = null)
    {
        throw new NotImplementedException();
    }
}