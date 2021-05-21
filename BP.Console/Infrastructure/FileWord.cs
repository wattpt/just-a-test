using System.Collections.Generic;
using System.IO;

namespace BP.Console.Infrastructure
{
    public class FileWord
    {
        private Dictionary<string, bool> _list;
        public FileWord(string fileName){
                        try
            {
                if (!File.Exists(fileName)) throw new FileNotFoundException("File not exist", fileName);
                _list = new Dictionary<string, bool>();
                using var sr = new StreamReader(fileName);
                string word = "";
                while ((word = sr.ReadLine()) != null)
                {
                    _list.Add(word, false);
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}