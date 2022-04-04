using System;
using System.Collections.Generic;
using System.Text;

namespace StaticTask
{
    internal static class ExtentionMethods
    {
        public static bool IsOdd(this int num)
        {
            if (num%2!=0)
            {
                return true;
            }
            return false;
        }

        public static bool IsEven(this int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public static bool IsContainsDigit(this string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    return true;
                }              
            }
            return false;

        }

        public static string ToCapitalize(this string str)
        {

            if (!string.IsNullOrEmpty(str) && str.Length > 1)

            {
                var words = str.Split(' ');

                var t = "";
                foreach (var word in words)
                {
                    t += char.ToUpper(word[0]) + word.Substring(1) + ' ';
                }
                return t.Trim();
            }

            return str.ToUpper();
        }

        public static int[] GetValueIndexes(string str, char chr)
        {

            //int count = 0;
            //int[] indexs = new int[0];
            //int index = str.IndexOf(chr);
            //count++;

            //Array.Resize(ref indexs, indexs.Length + 1);
            //indexs[indexs.Length - 1] = index;
            //int[] indexes = new int[count];
            //return indexes;
            ////if (count==0)
            ////{
                
            ////}

            
            
        }
    }
}
