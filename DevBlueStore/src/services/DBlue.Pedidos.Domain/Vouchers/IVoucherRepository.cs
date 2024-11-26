using System.Threading.Tasks;
using DBlue.Core.Data;

namespace DBlue.Pedidos.Domain
{
    public interface IVoucherRepository : IRepository<Voucher>
    {
        Task<Voucher> ObterVoucherPorCodigo(string codigo);
        void Atualizar(Voucher voucher);
    }
}