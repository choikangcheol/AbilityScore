using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbilityScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public static int ReadInt(int lastUsedValue, string prompt)
        {            
            Console.Write($"{prompt}[{lastUsedValue}]: ");
            string line = Console.ReadLine();
            if (int.TryParse(line, out int value))
            {
                Console.WriteLine($"    using value {value}");
                return value;
            }
            else
            {
                Console.WriteLine($"    using default value {lastUsedValue}");
                return lastUsedValue;
            }
        }

        public static double ReadDouble(double lastUsedValue, string prompt)
        {
            Console.Write($"{prompt}[{lastUsedValue}]: ");
            string line = Console.ReadLine();
            if (double.TryParse(line, out double value))
            {
                Console.WriteLine($"    using value {value}");
                return value;
            }
            else
            {
                Console.WriteLine($"    using default value {lastUsedValue}");
                return lastUsedValue;
            }
        }
    }
}
