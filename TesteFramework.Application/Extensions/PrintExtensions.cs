using System;
using System.Collections.Generic;

namespace TesteFramework.Application.Extensions
{
    public static class PrintExtensions
    {

        public static void PrintarArray (this IEnumerable<int> array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
        
    }
}
