using System;

namespace BP.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args?.Length != 4)
                throw new ArgumentException($"Arguments expected: startWord, endWord, fileLocation, outputFileLocation.");

            string startFile = args[0];
            string endFile = args[1];
            string fileLocation = args[2];
            string outputFileLocation = args[3];

        }
    }
}
