using System;

namespace Desafio.Domain.Arguments.Usuario
{
    public class AlterarUsuarioRequest
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        
    }
}
