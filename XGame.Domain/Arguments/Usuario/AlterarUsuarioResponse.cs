using System;

namespace Desafio.Domain.Arguments.Usuario
{
    public class AlterarUsuarioResponse
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        
        public string Message { get; set; }

        public static explicit operator AlterarUsuarioResponse(Entities.Usuario entidade)
        {
            return new AlterarUsuarioResponse() {
                Email = entidade.Email.Endereco,
                Id = entidade.Id,
               
                Message = Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO

            };
        }
    }
}
