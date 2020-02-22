namespace Desafio.Domain.Arguments.Base
{
    public class ResponseBase
    {
        public ResponseBase()
        {
            Message = Desafio.Domain.Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO;
        }
        public string Message { get; set; }

        public static explicit operator ResponseBase(Entities.Pessoa entidade)
        {
            return new ResponseBase() {
                Message = Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO
            };
        }

        
    }
}
