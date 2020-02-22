using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Desafio.Api.Controllers.Base;
using Desafio.Domain.Arguments.Pessoa;
using Desafio.Domain.Interfaces.Services;
using Desafio.Infra.Transactions;

namespace Desafio.Api.Controllers
{
    
    [RoutePrefix("api/pessoa")]
    public class PessoaController : ControllerBase
    {
        private readonly IServicePessoa _servicePessoa;

        public PessoaController(IUnitOfWork unitOfWork,  IServicePessoa servicePessoa) : base(unitOfWork)
        {
            _servicePessoa = servicePessoa;
        }
        [Authorize]
        [Route("Adicionar")]
        [HttpPost]
        public async Task<HttpResponseMessage> Adicionar(AdicionarPessoaRequest request)
        {
            try
            {
                var response = _servicePessoa.AdicionarPessoa(request);

                return await ResponseAsync(response, _servicePessoa);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }
        [Authorize]
        [Route("Alterar")]
        [HttpPut]
        public async Task<HttpResponseMessage> Alterar(AlterarPessoaRequest request)
        {
            try
            {
                var response = _servicePessoa.AlterarPessoa(request);

                return await ResponseAsync(response, _servicePessoa);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        [Authorize]
        [Route("Excluir")]
        [HttpDelete]
        public async Task<HttpResponseMessage> Excluir(Guid id)
        {
            try
            {
                var response = _servicePessoa.ExcluirPessoa(id);

                return await ResponseAsync(response, _servicePessoa);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }
        [Authorize]
        [Route("Listar")]
        [HttpGet]
        public async Task<HttpResponseMessage> Listar()
        {
            try
            {
                var response = _servicePessoa.ListarPessoa();

                return await ResponseAsync(response, _servicePessoa);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

       






    }
}