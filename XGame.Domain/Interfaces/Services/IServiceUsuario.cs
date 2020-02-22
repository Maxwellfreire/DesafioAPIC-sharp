using System;
using System.Collections.Generic;
using Desafio.Domain.Arguments.Base;
using Desafio.Domain.Arguments.Usuario;
using Desafio.Domain.Interfaces.Services.Base;

namespace Desafio.Domain.Interfaces.Services
{
    public interface IServiceUsuario : IServiceBase
    {
        AutenticarUsuarioResponse AutenticarUsuario(AutenticarUsuarioRequest request);

        AdicionarUsuarioResponse AdicionarUsuario(AdicionarUsuarioRequest request);

        AlterarUsuarioResponse AlterarUsuario(AlterarUsuarioRequest request);

        IEnumerable<UsuarioResponse> ListarUsuario();

        ResponseBase ExcluirUsuario(Guid id);
    }
}
