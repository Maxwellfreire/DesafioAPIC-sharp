using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using Desafio.Domain.Arguments.Base;
using Desafio.Domain.Arguments.Pessoa;
using Desafio.Domain.Entities;
using Desafio.Domain.Interfaces.Repositories;
using Desafio.Domain.Interfaces.Services;
using Desafio.Domain.Resources;

namespace Desafio.Domain.Services
{
    public class ServicePessoa : Notifiable, IServicePessoa
    {
        private readonly IRepositoryPessoa _repositoryPessoa;
        public ServicePessoa()
        {

        }

        public ServicePessoa(IRepositoryPessoa repositoryPessoa)
        {
            _repositoryPessoa = repositoryPessoa;
        }

        public AdicionarPessoaResponse AdicionarPessoa(AdicionarPessoaRequest request)
        {
            if (request == null)
            {
                AddNotification("Adicionar", Message.OBJETO_X0_E_OBRIGATORIO.ToFormat("AdicionarPessoaRequest"));
                return null;
            }

            var pessoa = new Pessoa(request.Nome, request.Cpf, request.Uf, request.Datanascimento);

            AddNotifications(pessoa);

            if (this.IsInvalid())
            {
                return null;
            }

            pessoa = _repositoryPessoa.Adicionar(pessoa);


            return (AdicionarPessoaResponse)pessoa;
        }

        public AlterarPessoaResponse AlterarPessoa(AlterarPessoaRequest request)
        {
            if (request == null)
            {
                AddNotification("Alterar", Message.OBJETO_X0_E_OBRIGATORIO.ToFormat("AlterarPessoaRequest"));
                return null;
            }

            var pessoa = _repositoryPessoa.ObterPorId(request.Id);

            if (pessoa == null)
            {
                AddNotification("Id", Message.DADOS_NAO_ENCONTRADOS);
                return null;
            }

            pessoa.Alterar(request.Nome, request.Cpf, request.Uf, request.Datanascimento);

            if (IsInvalid())
            {
                return null;
            }

            _repositoryPessoa.Editar(pessoa);

            return (AlterarPessoaResponse)pessoa;
        }

        public ResponseBase ExcluirPessoa(Guid id)
        {
            var pessoa = _repositoryPessoa.ObterPorId(id);

            if (pessoa == null)
            {
                AddNotification("Id", Message.DADOS_NAO_ENCONTRADOS);
                return null;
            }

            _repositoryPessoa.Remover(pessoa);

            return new ResponseBase() { Message = Message.OPERACAO_REALIZADA_COM_SUCESSO };
        }

        public IEnumerable<PessoaResponsecod> ListarPessoa()
        {
            return _repositoryPessoa.Listar().ToList().Select(jogo => (PessoaResponsecod)jogo).ToList();
        }

        
    }
}
