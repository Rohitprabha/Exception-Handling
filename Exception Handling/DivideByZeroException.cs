using System;

namespace Exception_Handling_1
{
    class DivideByZeroException
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 0;
            int result = a / b;                             //System.DivideByZeroException: 'Attempted to divide by zero.'
            Console.WriteLine("result is " + result);
        }
    }
}
