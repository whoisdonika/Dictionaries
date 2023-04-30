using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var phonebook = new Dictionary<string, string>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
               
                if (input[0] == "END")
                {
                    break;
                }

                if (input[0] == "A")
                {
                    string name = input[1];
                    string phoneNum = input[2];

                    phonebook[name] = phoneNum;
                }

                if (input[0] == "S")
                {
                    string name = input[1];
                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }

            }
        }
    }
}
