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

            string stub = input.Substring(0, input.IndexOf('['));
            string regex = input.Substring(input.IndexOf('[') + 1);
            regex = regex.Substring(0, regex.Length - 1);
            string[] regexes = regex.Split(new string[] { "][" }, StringSplitOptions.RemoveEmptyEntries);

            List<List<char>> parts = new List<List<char>>();
            foreach (string rx in regexes)
            {
                if (rx.Contains("-"))
                {
                    List<char> bits = new List<char>();

                    char start = rx.ElementAt(rx.IndexOf('-') - 1);
                    char end = rx.ElementAt(rx.IndexOf('-') + 1);

                    while (start != end)
                    {
                        bits.Add(start);
                        start++;
                    }
                    bits.Add(end);

                    parts.Add(bits);
                }
                else
                {
                    parts.Add(new List<char>(rx.ToCharArray()));
                }
            }
        }
    }
}
