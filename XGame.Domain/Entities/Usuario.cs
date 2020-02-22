using prmToolkit.NotificationPattern;
using Desafio.Domain.Entities.Base;
using Desafio.Domain.Extensions;
using Desafio.Domain.ValueObjects;

namespace Desafio.Domain.Entities
{
    public class Usuario : EntityBase
    {
        protected Usuario()
        {

        }
        public Usuario(Email email, string senha)
        {
            Email = email;
            Senha = senha;

            new AddNotifications<Usuario>(this).IfNullOrInvalidLength(x => x.Senha, 6, 32, "A senha deve ter entre 6 a 32 caracteres");

            if (IsValid())
            {
                Senha = Senha.ConvertToMD5();
            }
        }

        

        public void AlterarJogador( Email email)
        {
           
            Email = email;

            

            AddNotifications(email);
        }
        

        public Email Email { get; private set; }

        public string Senha { get; private set; }

        


        

        
    }
}
