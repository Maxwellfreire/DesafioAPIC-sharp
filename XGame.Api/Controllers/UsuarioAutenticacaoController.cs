using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Desafio.Api.Controllers.Base;
using Desafio.Domain.Arguments.Usuario;
using Desafio.Domain.Interfaces.Services;
using Desafio.Infra.Transactions;

namespace Desafio.Api.Controllers
{
    [RoutePrefix("api/usuario")]
    public class UsuarioautenticacaoController : ControllerBase
    {
        private readonly IServiceUsuario _serviceUsuario;

        public UsuarioautenticacaoController(IUnitOfWork unitOfWork,  IServiceUsuario serviceUsuario) : base(unitOfWork)
        {
            _serviceUsuario = serviceUsuario;
        }

        [Route("Adicionar")]
        [HttpPost]
        public async Task<HttpResponseMessage> Adicionar(AdicionarUsuarioRequest request)
        {
            try
            {
                var response = _serviceUsuario.AdicionarUsuario(request);

                return await ResponseAsync(response, _serviceUsuario);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        [Route("Listar")]
        [HttpGet]
        public async Task<HttpResponseMessage> Listar()
        {
            try
            {
                var response = _serviceUsuario.ListarUsuario();

                return await ResponseAsync(response, _serviceUsuario);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }


    }
}