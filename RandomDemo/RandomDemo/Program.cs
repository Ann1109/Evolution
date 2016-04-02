using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomDemo
{
    class Program
    {
        static void Main(string[] args)
        {   Random rnd = new Random();
            int value = rnd.Next(0, 100);
            Console.WriteLine(value); 
            Console.ReadKey();
        }
    }
}

