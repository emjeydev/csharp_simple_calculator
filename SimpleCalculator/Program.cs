﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This file is made by EmJey
// Project: SimpleCalculator
// FileName: SimpleCalculator
// Date: 2023/02/02
// Email: emjeydev@gmail.com
// Github: emjeydev

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2);

            Console.ReadLine();
        }
    }
}
