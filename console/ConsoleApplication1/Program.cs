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
            //remove string spaces
            var whiteSpaceRemovedString = s.Replace(" ", "");
            Console.WriteLine(IsPalindrome(whiteSpaceRemovedString) == shouldBePalindrome ? "pass" : "FAIL");
        }

        public static bool IsPalindrome(string sentence)
        {
            var index = 0;
            var lengthOfString = sentence.Length - 1;

            while (index < lengthOfString)
            {
                var sentenceStart = Convert.ToString(sentence[index]).ToLower();
                var sentenceEnd = Convert.ToString(sentence[lengthOfString]).ToLower();
                if (sentenceStart != sentenceEnd)
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
