using System;
using Desafio.Domain.Entities;
using Desafio.Domain.Interfaces.Repositories;
using Desafio.Infra.Persistence.Repositories.Base;

namespace Desafio.Infra.Persistence.Repositories
{
    public class RepositoryUsuario : RepositoryBase<Usuario, Guid>, IRepositoryUsuario
    {
        protected readonly DesafioContext _context;

        public RepositoryUsuario(DesafioContext context) : base(context)
        {
            _context = context;
        }
    }
}
