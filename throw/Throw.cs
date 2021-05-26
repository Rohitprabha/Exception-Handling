using System;

namespace Exception_Handling_5
{
    class Throw
    {
        static void Main(string[] args)
        {
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                if (b % 2 > 0)
                {
                    throw new ApplicationException("Divisor value can't be odd no.");
                    //ApplicationException ex = new ApplicationException("Divisor value can't be odd no.");
                    //throw ex;
                }
                int result = a / b;
                Console.WriteLine("result is " + result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
