using System.Collections.Generic;
using System.Threading.Tasks;
using BP.Console.Domain.Entity;

namespace BP.Console.Domain.Interface
{
    public interface IRepositoryBase
    {
        Task<IEnumerable<Word>> GetAll();

    }
}