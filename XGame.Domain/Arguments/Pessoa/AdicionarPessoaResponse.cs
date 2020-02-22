using System;

namespace Desafio.Domain.Arguments.Pessoa
{
    public class AdicionarPessoaResponse
    {
        public Guid Id { get; set; }

        public string Nome { get; private set; }

        public string Cpf { get; private set; }

        public string Uf { get; private set; }

        public string Datanascimento { get; private set; }

        public string Message { get; set; }

        public static explicit operator AdicionarPessoaResponse(Entities.Pessoa entidade)
        {
            return new AdicionarPessoaResponse() {
                Id = entidade.Id,
                Nome = entidade.Nome,
                Cpf = entidade.Cpf,
                Uf = entidade.Uf,
                Datanascimento = entidade.Datanascimento,
                Message = Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO
            };
        }
    }
}
