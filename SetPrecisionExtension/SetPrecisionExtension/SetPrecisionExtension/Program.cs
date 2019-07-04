using System;
using SetPrecisionExtensions;

namespace Example
{
    internal static class Examples
    {
        static void Main(string[] args)
        {
            float number = 3.574857f;
            Console.WriteLine(number.SetPrecision(0));
            Console.WriteLine(number.SetPrecision(2));
            Console.WriteLine(number.SetPrecision(8));
            Console.WriteLine(5.545454576586758675687f.SetPrecision(2));
            Console.ReadKey();
        }
    }
}
