using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;
using Desafio.Domain.Entities.Base;
using Desafio.Domain.Resources;

namespace Desafio.Domain.Entities
{
    public class Pessoa : EntityBase
    {
        protected Pessoa()
        {

        }
        public Pessoa(string nome, string cpf, string uf, string datanascimento)
        {
            Nome = nome;
            Cpf = cpf;
            Uf = uf;
            Datanascimento = datanascimento;
            

            ValidarEntidade();
            

        }

        private void ValidarEntidade()
        {
            new AddNotifications<Pessoa>(this)
                .IfNullOrInvalidLength(x => x.Nome, 1, 100, Message.X0_OBRIGATORIO_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("Nome", "1", "100"))
                .IfNullOrInvalidLength(x => x.Cpf, 11, 11, Message.X0_E_OBRIGATORIO_E_DEVE_CONTER_X1_CARACTERES.ToFormat("CPF", "11"));
        }

        public void Alterar(string nome, string cpf, string uf, string datanascimento)
        {
            Nome = nome;
            Cpf = cpf;
            Uf = uf;
            Datanascimento = datanascimento;
           

            ValidarEntidade();

        }
        public string Nome { get; private set; }

        public string Cpf { get; private set; }

        public string Uf { get; private set; }

        public string Datanascimento { get; private set; }

        
    }
}
