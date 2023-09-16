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
            string usertInput = " ";  
            Console.WriteLine("Input 'exit' to exit or somethimg else for something else");
            while (usertInput != "exit") 
            {
                usertInput = Console.ReadLine();
            }
        }
    }
}
