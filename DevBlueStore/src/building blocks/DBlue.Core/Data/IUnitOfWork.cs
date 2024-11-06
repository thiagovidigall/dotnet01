using System.Threading.Tasks;

namespace DBlue.Core.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}