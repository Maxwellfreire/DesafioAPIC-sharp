using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Domain.Arguments.Pessoa
{
    public class AlterarPessoaResponse
    {

        public string Nome { get; set; }

        public string Cpf { get; set; }

        public string Uf { get; set; }

        public string Datanascimento { get; set; }

        public string Message { get; set; }

        public static explicit operator AlterarPessoaResponse(Entities.Pessoa entidade)
        {
            return new AlterarPessoaResponse()
            {
                
                Nome = entidade.Nome,
                Cpf = entidade.Cpf,
                Uf = entidade.Uf,
                Datanascimento = entidade.Datanascimento,
                Message = Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO
            };
        }

    }
}
