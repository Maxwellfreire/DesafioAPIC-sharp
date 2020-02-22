using System;

namespace Desafio.Domain.Arguments.Usuario
{
    public class UsuarioResponse
    {
        public Guid Id { get;  set; }

        

        public string Email { get;  set; }

        

        public static explicit operator UsuarioResponse(Entities.Usuario entidade)
        {
            return new UsuarioResponse() {
                Email = entidade.Email.Endereco,
                
                
                Id = entidade.Id
                
            };
        }
    }
}
