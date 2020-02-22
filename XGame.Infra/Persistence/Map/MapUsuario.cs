using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using Desafio.Domain.Entities;

namespace Desafio.Infra.Persistence.Map
{
    public class MapUsuario : EntityTypeConfiguration<Usuario>
    {
        public MapUsuario()
        {
            ToTable("Usuario");

            Property(p => p.Email.Endereco).HasMaxLength(200).IsRequired().HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("UK_JOGADOR_EMAIL") { IsUnique = true })).HasColumnName("Email");
            
            Property(p => p.Senha).IsRequired();

        }
    }
}
