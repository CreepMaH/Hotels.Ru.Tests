﻿using MoreLinq;

namespace Hotels.Ru.Tests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание №1
            string comp28Name = ComputersCount.GetComputersCountName(28);
            Console.WriteLine(comp28Name);  //"28 компьютеров"

            //Задание №2
            int[] input = [42, 12, 18];
            int[] output = CommonDividers.GetCommonDividers(input);
            Console.WriteLine(output.ToDelimitedString(", "));
        }

        
    }
}
