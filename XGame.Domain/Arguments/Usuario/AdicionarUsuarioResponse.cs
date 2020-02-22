using System;
using Desafio.Domain.Interfaces.Arguments;

namespace Desafio.Domain.Arguments.Usuario
{
    public class AdicionarUsuarioResponse : IResponse
    {
        public Guid Id { get; set; }

        public string Message { get; set; }

        public static explicit operator AdicionarUsuarioResponse(Entities.Usuario entidade)
        {
            return new AdicionarUsuarioResponse() {
                Id = entidade.Id,
                Message = Desafio.Domain.Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO
            };
        }
    }
}
