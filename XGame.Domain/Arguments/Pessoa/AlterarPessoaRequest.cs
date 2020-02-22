using System;

namespace Desafio.Domain.Arguments.Pessoa
{
    public class AlterarPessoaRequest
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string Cpf { get; set; }

        public string Uf { get; set; }

        public string Datanascimento { get; set; }

       
    }
}
