using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(2);
            numbers.Add(4);
            numbers.Add(8);
            var squaredNumbers = numbers.Select(x => x + "labas");
            Console.WriteLine("labas Ignai");

            foreach (var item in squaredNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
