using System;

namespace Desafio.Domain.Arguments.Pessoa
{
    public class PessoaResponsecod
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        public string Cpf { get; set; }

        public string Uf { get; set; }

        public string Datanascimento { get; set; }

        

        public static explicit operator PessoaResponsecod(Entities.Pessoa entidade)
        {
            return new PessoaResponsecod() {
                Cpf = entidade.Cpf,
                Datanascimento = entidade.Datanascimento,                
                Id = entidade.Id,
                 Nome = entidade.Nome,
                 Uf = entidade.Uf
                 
            };
        }
    }
}
