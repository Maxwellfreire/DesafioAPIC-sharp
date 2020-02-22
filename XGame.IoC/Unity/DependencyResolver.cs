using Microsoft.Practices.Unity;
using prmToolkit.NotificationPattern;
using System.Data.Entity;
using Desafio.Domain.Interfaces.Repositories;
using Desafio.Domain.Interfaces.Repositories.Base;
using Desafio.Domain.Interfaces.Services;
using Desafio.Domain.Services;
using Desafio.Infra.Persistence;
using Desafio.Infra.Persistence.Repositories;
using Desafio.Infra.Persistence.Repositories.Base;
using Desafio.Infra.Transactions;

namespace Desafio.IoC.Unity
{
    public static class DependencyResolver
    {
        public static void Resolve(UnityContainer container)
        {

            container.RegisterType<DbContext, DesafioContext>(new HierarchicalLifetimeManager());
            //UnitOfWork
            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());
            container.RegisterType<INotifiable, Notifiable>(new HierarchicalLifetimeManager());

            //Serviço de Domain
            //container.RegisterType(typeof(IServiceBase<,>), typeof(ServiceBase<,>));

            container.RegisterType<IServiceUsuario, ServiceUsuario>(new HierarchicalLifetimeManager());
            container.RegisterType<IServicePessoa, ServicePessoa>(new HierarchicalLifetimeManager());
            


            //Repository
            container.RegisterType(typeof(IRepositoryBase<,>), typeof(RepositoryBase<,>));

            container.RegisterType<IRepositoryUsuario, RepositoryUsuario>(new HierarchicalLifetimeManager());
            container.RegisterType<IRepositoryPessoa, RepositoryPessoa>(new HierarchicalLifetimeManager());
            
            

        }
    }
}
