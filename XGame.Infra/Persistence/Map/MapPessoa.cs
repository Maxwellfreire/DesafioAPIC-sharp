using System.Data.Entity.ModelConfiguration;
using Desafio.Domain.Entities;

namespace Desafio.Infra.Persistence.Map
{
    public class MapPessoa : EntityTypeConfiguration<Pessoa>
    {
        public MapPessoa()
        {
            ToTable("Pessoa");

            Property(p => p.Nome).HasMaxLength(100).IsRequired();
            Property(p => p.Cpf).HasMaxLength(255).IsRequired();
            Property(p => p.Uf).HasMaxLength(50);
            Property(p => p.Datanascimento).HasMaxLength(50);
        }
    }
}
