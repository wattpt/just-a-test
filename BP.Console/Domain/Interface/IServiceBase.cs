using System.Collections.Generic;
using System.Threading.Tasks;
using BP.Console.Domain.Entity;

namespace BP.Console.Domain.Interface
{
    public interface IServiceBase
    {
        Task<IEnumerable<Word>> FindList(string startWord, string endWord, string[] words);
    }
}