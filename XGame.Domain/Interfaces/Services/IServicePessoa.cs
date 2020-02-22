using System;
using System.Collections.Generic;
using Desafio.Domain.Arguments.Base;
using Desafio.Domain.Arguments.Pessoa;
using Desafio.Domain.Interfaces.Services.Base;

namespace Desafio.Domain.Interfaces.Services
{
    public interface IServicePessoa : IServiceBase
    {
        IEnumerable<PessoaResponsecod> ListarPessoa();


        AdicionarPessoaResponse AdicionarPessoa(AdicionarPessoaRequest request);

        AlterarPessoaResponse AlterarPessoa(AlterarPessoaRequest request);

        ResponseBase ExcluirPessoa(Guid id);

        



    }
}
