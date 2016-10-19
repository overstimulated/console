﻿using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
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

            var arr = new[] {7, 4, 2, 1, 3, 8, 9, 6, 5};

            Sort(arr);

            foreach(var a in arr)
                Console.WriteLine(a);

            Console.ReadKey(); //to exit
        }

        public static int[] Sort(int[] arr)
        {
            var smallest = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    Console.WriteLine(arr.Length - 1);
                    if (arr[sort] > arr[sort + 1])
                    {
                        smallest = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = smallest;

                    }

                }
            }

            return arr;
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
