using System;
using System.IO;

namespace alexisTest
{
    public static class InputFileManager
    {
        public static int[] ExtractFileLines(){
            string[] inputsLines = File.ReadAllLines(@"printInstructions.txt");
            // Fast cast without any error checks
            return Array.ConvertAll(inputsLines, int.Parse);
        }
    }
}
