﻿namespace _02.RadianstoDegrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radians = double.Parse(Console.ReadLine());
            Console.WriteLine(radians * 180 / Math.PI);
        }
    }
}