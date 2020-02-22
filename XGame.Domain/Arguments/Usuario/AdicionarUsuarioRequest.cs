using Desafio.Domain.Interfaces.Arguments;
using Desafio.Domain.ValueObjects;

namespace Desafio.Domain.Arguments.Usuario
{
    public class AdicionarUsuarioRequest : IRequest
    {
        public string Email { get; set; }
        public string Senha { get; set; }
        
    }
}
