using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter items, quantity and price :  ");
            string[] input = Console.ReadLine().Split(' ');
            var prices = new Dictionary<string, double>();
            var quantities = new Dictionary<string, int>();
            double grandtotal = 0.0;
            
            while (input[0] != "stocked")
            {
                if (!(quantities.ContainsKey(input[0])))
                {
                    quantities[input[0]] = 0;
                }
                prices[input[0]] = double.Parse(input[1]);
                quantities[input[0]] = quantities[input[0]] + int.Parse(input[2]);
                input = Console.ReadLine().Split(' ');
            }
           
            Console.WriteLine();

            foreach (var item in prices)
            {
                double totalprice = item.Value * quantities[item.Key];
                Console.WriteLine($"{item.Key}: ${item.Value:f2} * {quantities[item.Key]} = ${totalprice:f2}");
                grandtotal = grandtotal + totalprice;
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: ${grandtotal:f2}");
        }
    }
}
