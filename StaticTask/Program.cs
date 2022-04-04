using System;

namespace StaticTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("eded daxil edin : ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(ExtentionMethods.IsOdd(num));
            Console.WriteLine(ExtentionMethods.IsEven(num));
            Console.WriteLine("string deyer daxil edin : ");
            string str = Console.ReadLine();
            Console.WriteLine(ExtentionMethods.IsContainsDigit(str));
            Console.WriteLine(ExtentionMethods.ToCapitalize(str));
            char chr = char.Parse(Console.ReadLine());
            Console.WriteLine(ExtentionMethods.GetValueIndexes(str, chr));
        }
    }
}
