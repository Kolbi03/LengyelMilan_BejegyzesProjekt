﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lengyel_Milán_BejegyzésProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bejegyzes bejegyzes1 = new Bejegyzes("Petőfi", "aaa");

            Console.WriteLine(bejegyzes1.ToString());

            Console.ReadKey();
        }
    }
}
