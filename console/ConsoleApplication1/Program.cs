using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Check("abcba", true);
            Check("abcde", false);
            Check("Mr owl ate my metal worm", true);
            Check("Never Odd Or Even", true);
            Check("Never Even Or Odd", false);

            Console.ReadKey(); //to exit
        }

        public static void Check(string s, bool shouldBePalindrome)
        {
            Console.WriteLine(IsPalindrome(s) == shouldBePalindrome ? "pass" : "FAIL");
        }

        public static bool IsPalindrome(string s)
        {
            var index = 0;
            var lengthOfString = s.Length - 1;

            while (index < lengthOfString) 
            {
                if (s[index] != s[lengthOfString])
                {
                    return false;
                }

                index ++;
                lengthOfString--;
            }

            return true;
        }
    }
}
