using System;
using System.Collections.Generic;
using System.Linq;

namespace alexisTest
{
    public static class PrinterHelper
    {
         public static void PrintPrinterPageSelectionInput(List<List<int>> findPages){
            int findPagesLength = findPages.Count;

            for (int index = 0; index < findPagesLength; index++){
                List<int> selection = findPages[index];

                PrintIntervalOrOnePage(selection);
                PrintCommaExceptOnEnd(index, findPagesLength);
            }
        }

        public static void PrintIntervalOrOnePage(List<int> selection)
        {
            if (selection.Count > 1)
            {
                Console.Write($"{selection.First()}-{selection.Last()}");
            }
            else
            {
                Console.Write($"{selection.First()}");
            }
        }

        public static void PrintCommaExceptOnEnd(int index, int findPagesLength)
        {
            if(index != findPagesLength-1){
                    Console.Write(";");
                }
        }
    }
}
