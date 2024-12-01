using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

        Console.WriteLine("************************");
        Console.WriteLine("");
        Console.WriteLine($"Part 1 sample: {Solves2024.Day2Part1(inputs2024.day2s)}");
        Console.WriteLine($"Part Full:     {Solves2024.Day2Part1(inputs2024.day2)}");
        Console.WriteLine($"Part 2 sample: {Solves2024.Day2Part2(inputs2024.day2s)}");
        Console.WriteLine($"Part 2 full:   {Solves2024.Day2Part2(inputs2024.day2)}");
        Console.WriteLine("");
        Console.WriteLine("************************");

        }
    }
}

  