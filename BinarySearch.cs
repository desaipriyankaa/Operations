using System;
using System.Collections.Generic;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>
            { 
                "priyanka",
                "Suraj",
                "vishu",
                "Raj"
            };
            Console.WriteLine("List :");
            foreach (var item in list)
            {
                Console.Write(item);
                Console.Write("  ");
            }
           
            Console.WriteLine("\n\n***** Binary search operation *****");
            string search = "Suraj";
            Console.WriteLine($"Binary search for : {search}");
            int result = list.BinarySearch(search);
            ShowWhere<string>(list, result);
            Console.WriteLine($"{(result > 0 ? "Found" : "Did not find")} {search}");


            void ShowWhere<T>(IList<T> collection, int index)
            {
                Console.WriteLine($"{search} found at index : {index}");
            }
        }
    }
}
