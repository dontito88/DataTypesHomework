﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    class Greeting
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string family = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello, {0} {1}. You are {2} years old.", name, family, age);
        }
    }
}
