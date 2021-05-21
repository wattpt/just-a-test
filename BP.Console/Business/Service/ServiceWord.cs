using System.Collections.Generic;
using System.Threading.Tasks;
using BP.Console.Domain.Entity;
using BP.Console.Domain.Interface;

namespace BP.Console.Business.Service
{
    public class ServiceWord : IServiceBase
    {
        public Task<IEnumerable<Word>> FindList(string startWord, string endWord, string[] words)
        {
            throw new System.NotImplementedException();
        }
    }
}