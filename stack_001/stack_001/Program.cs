using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_001
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stk = new Stack<string>();

            stk.Push("one");
            stk.Push("two");
            stk.Push("three");
         


            foreach (string tegn in stk)
                Console.WriteLine(tegn);

            Console.ReadLine();
            string r = stk.Pop();
            string rom = stk.Pop();
            Console.WriteLine(rom + "111");
            Console.WriteLine(r + "222");
            foreach (string tegn in stk)
                Console.WriteLine(tegn);
            string s1 = "He said, \"This is the last \x0021hance\u0063\"";
            string s2 = @"He said, ""This is the last \x0021hance\u0063""";

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            string @string = "sdsdsdsd";
            Console.WriteLine(@string);
            Console.ReadKey();
        }
    }
}
