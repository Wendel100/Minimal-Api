namespace Minimal_Api.Dominio.DTOs
{
    public class LoginDTO(string nome, string senha)
    {
        public string Email { get; set; } = nome;
        public string Senha { get; set; } = senha;
    }
}