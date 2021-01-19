using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 34.1;
            var y = 10.3;
            var result = x + y;
            var numbers = new double[3];
            numbers[0] = 12.7;
            numbers[1] = 10.3;
            numbers[2] = 6.11;

            // var result2 = numbers[0];
            // result2 = result2 + numbers[1];
            // result2 = result2 + numbers[2];

            var result2 = 0.0;
            foreach (double number in numbers)
            {
                result2 += number;
            }
            System.Console.WriteLine(result2);

            List<double> grades = new List<double>();
            grades.Add(10.9);
            grades.Add(19.9);
            System.Console.WriteLine($"{grades[0]:N1}");
            


            System.Console.WriteLine($"{result}");

            if (args.Length > 0)
            {
                Console.WriteLine($"Hello {args[0]} !");
            }
            else
            {
                Console.WriteLine("Hello!");
            }
        }
    }
}
