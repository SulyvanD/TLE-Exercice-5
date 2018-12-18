using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLE___Exercice_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            numbers.Add(6);

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Insert(0, 1);
            numbers.Add(7);

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
