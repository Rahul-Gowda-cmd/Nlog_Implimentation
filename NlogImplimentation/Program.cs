﻿using Microsoft.Extensions.Logging;
using NLog;
using System;

namespace NlogImplimentation
{
    class Program
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
           //public static Logger logger = LogManager.GetCurrentClassLogger();
            Console.WriteLine("Addition problem \n Enter a,b values");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            AddNumber add = new AddNumber();
            Console.WriteLine("Result is " + " " + add.Sum(a, b));
        }
    }
}
