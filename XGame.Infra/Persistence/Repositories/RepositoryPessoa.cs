using System;
using Desafio.Domain.Entities;
using Desafio.Domain.Interfaces.Repositories;
using Desafio.Infra.Persistence.Repositories.Base;

namespace Desafio.Infra.Persistence.Repositories
{
    public class RepositoryPessoa : RepositoryBase<Pessoa, Guid>, IRepositoryPessoa
    {
        protected readonly DesafioContext _context;

        public RepositoryPessoa(DesafioContext context) : base(context)
        {
            _context = context;
        }
    }
}
