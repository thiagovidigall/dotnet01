using System;
using System.Threading.Tasks;
using DBlue.Core.Messages.Integration;
using DBlue.Pagamentos.API.Models;

namespace DBlue.Pagamentos.API.Services
{
    public interface IPagamentoService
    {
        Task<ResponseMessage> AutorizarPagamento(Pagamento pagamento);
        Task<ResponseMessage> CapturarPagamento(Guid pedidoId);
        Task<ResponseMessage> CancelarPagamento(Guid pedidoId);
    }
}