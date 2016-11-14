using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexExpander
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Count() < 1)
            {
                Console.WriteLine("No input");
                return;
            }

            string input = args[0];

            if (input.IndexOf('[') < 0)
            {
                Console.WriteLine("No regex");
                return;
            }
        }
    }
}
