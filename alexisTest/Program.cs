using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace alexisTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Encode numbers, do not use magic numbers !
            int NUMBER_OF_PAGES_POSITION = 0;

            // Put in array all line of input file
            int[] lines = InputFileManager.ExtractFileLines();

            // Get the number of page to print
            int numberOfPagesToPrint = lines[NUMBER_OF_PAGES_POSITION];

            // Define a structure to store the values
            List<List<int>> intervalsToPrint = new List<List<int>>();

            // Init substructure etc.
            List<int> subList = new List<int>();
            subList.Add(lines[1]);

            int linesLength = lines.Length;

            //Console.WriteLine($"****{linesLength}****");

            // Dispatch values in subarrays
            for (int i = 2; i < linesLength; i++){
                int subListLength = subList.Count;

                if ((subList[subListLength-1]+1)==lines[i]){
                    subList.Add(lines[i]);
                }else{
                    intervalsToPrint.Add(subList);
                    subList= new List<int>();
                    subList.Add(lines[i]);
                }
            }
            intervalsToPrint.Add(subList);

            PrinterHelper.PrintPrinterPageSelectionInput(intervalsToPrint);
        }
    }
}
