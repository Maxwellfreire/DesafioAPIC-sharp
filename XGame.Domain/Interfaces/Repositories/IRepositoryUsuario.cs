using System;
using Desafio.Domain.Entities;
using Desafio.Domain.Interfaces.Repositories.Base;

namespace Desafio.Domain.Interfaces.Repositories
{
    public interface IRepositoryUsuario : IRepositoryBase<Usuario, Guid>
    {
    }

}
