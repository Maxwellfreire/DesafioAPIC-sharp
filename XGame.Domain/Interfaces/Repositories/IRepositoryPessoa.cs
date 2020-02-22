using System;
using Desafio.Domain.Entities;
using Desafio.Domain.Interfaces.Repositories.Base;

namespace Desafio.Domain.Interfaces.Repositories
{
    public interface IRepositoryPessoa : IRepositoryBase<Pessoa, Guid>
    {
        
    }

}
