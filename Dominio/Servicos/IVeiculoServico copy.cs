using Minimal_Api.Dominio.DTOs;
using Minimal_Api.Dominio.Entidades;

namespace Minimal_Api.Dominio.Servicos;

public interface IVeiculoServico
{
  public List<Veiculo> Lista(int pagina = 1, string? nome = null, string? marca = null);
  Veiculo BuscarId(int id);
  void Incluir(Veiculo veiculo);
  void Atualizar(Veiculo veiculo);
  void Apagar(Veiculo veiculo);
}