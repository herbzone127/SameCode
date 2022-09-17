using System.Threading.Tasks;
using Registro.Service.IRepositories;

namespace Registro.Service.IConfiguration
{
    public interface IUnitOfWork
    {
         IUserRepository Users {get;}

         Task CompleteAsync();
    }
}