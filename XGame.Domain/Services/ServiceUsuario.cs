using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;
using Desafio.Domain.Arguments.Usuario;
using Desafio.Domain.Entities;
using Desafio.Domain.Interfaces.Repositories;
using Desafio.Domain.Interfaces.Services;
using Desafio.Domain.Resources;
using Desafio.Domain.ValueObjects;
using System.Collections.Generic;
using System.Linq;
using Desafio.Domain.Arguments.Base;

namespace Desafio.Domain.Services
{
    public class ServiceUsuario : Notifiable, IServiceUsuario
    {
        private readonly IRepositoryUsuario _repositoryUsuario;
        public ServiceUsuario()
        {

        }
        public ServiceUsuario(IRepositoryUsuario repositoryUsuario)
        {
            _repositoryUsuario = repositoryUsuario;
        }

        public AdicionarUsuarioResponse AdicionarUsuario(AdicionarUsuarioRequest request)
        {
            
            var email = new Email(request.Email);

            Usuario jogador = new Usuario(email, request.Senha);

            AddNotifications( email);

            if (_repositoryUsuario.Existe(x=>x.Email.Endereco == request.Email))
            {
                AddNotification("E-mail", Message.JA_EXISTE_UM_X0_CHAMADO_X1.ToFormat("e-mail", request.Email));
            }

            if (this.IsInvalid())
            {
                return null;
            }

            jogador = _repositoryUsuario.Adicionar(jogador);


            return (AdicionarUsuarioResponse)jogador;
        }

        public AlterarUsuarioResponse AlterarUsuario(AlterarUsuarioRequest request)
        {
            if (request == null)
            {
                AddNotification("AlterarUsuarioRequest", Message.X0_E_OBRIGATORIO.ToFormat("AlterarUsuarioRequest"));
            }

            Usuario usuario = _repositoryUsuario.ObterPorId(request.Id);

            if (usuario == null)
            {
                AddNotification("Id", Message.DADOS_NAO_ENCONTRADOS);
                return null;
            }

            
            var email = new Email(request.Email);
            
            usuario.AlterarJogador(email);

            AddNotifications(usuario);

            if (IsInvalid())
            {
                return null;
            }

            _repositoryUsuario.Editar(usuario);

            return (AlterarUsuarioResponse)usuario;
        }

        public AutenticarUsuarioResponse AutenticarUsuario(AutenticarUsuarioRequest request)
        {
            if (request == null)
            {
                AddNotification("AutenticarUsuarioRequest", Message.X0_E_OBRIGATORIO.ToFormat("AutenticarUsuarioRequest"));
            }

            var email = new Email(request.Email);
            var usuario = new Usuario(email, request.Senha);

            AddNotifications(usuario, email);

            if (usuario.IsInvalid())
            {
                return null;
            }

            usuario = _repositoryUsuario.ObterPor(x => x.Email.Endereco == usuario.Email.Endereco && x.Senha == usuario.Senha);

            return (AutenticarUsuarioResponse)usuario;
        }

        public IEnumerable<UsuarioResponse> ListarUsuario()
        {
            return _repositoryUsuario.Listar().ToList().Select(jogador => (UsuarioResponse)jogador).ToList();
        }
        public ResponseBase ExcluirUsuario(Guid id)
        {
            Usuario usuario = _repositoryUsuario.ObterPorId(id);

            if (usuario == null)
            {
                AddNotification("Id", Message.DADOS_NAO_ENCONTRADOS);
                return null;
            }

            _repositoryUsuario.Remover(usuario);

            return new ResponseBase();
        }
    }
}
