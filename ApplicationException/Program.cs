using System;

namespace Exception_Handling_6
{
    public class DivideByOddNoException : ApplicationException
    {
        public override string Message
        {
            get 
            {
                return "Attempted to divide by Odd number";
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (b % 2 > 0)
            {
                throw new DivideByOddNoException();
            }
            int result = a / b;
            Console.WriteLine("result is " + result);
        }
    }
}
