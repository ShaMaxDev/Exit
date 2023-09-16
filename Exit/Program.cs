using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string exitWord = "exit";
            string usertInput = " ";  
            Console.WriteLine($"Input {exitWord} to exit or somethimg else for something else");
            
            while (usertInput != exitWord) 
            {
                usertInput = Console.ReadLine();
            }

        }
    }
}
