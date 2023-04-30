using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var resources = new Dictionary<string, int>();
            
            while (input != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (!(resources.ContainsKey(input))) 
                {
                    resources[input] = 0;
                }
                resources[input] = resources[input] + quantity;
                input = Console.ReadLine();
            }
            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key}  --> {item.Value}");
            }
        }
    }
    
}
