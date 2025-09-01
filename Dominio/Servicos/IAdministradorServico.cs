using Minimal_Api.Dominio.DTOs;
using Minimal_Api.Dominio.Entidades;

namespace Minimal_Api.Dominio.Servicos;

public interface IAdministradorServico
{
  public  List<Administrador>Login(LoginDTO login);
}