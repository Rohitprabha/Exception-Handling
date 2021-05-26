using System;

namespace Exception_Handling_4
{
    class Finally
    {
        static void Main(string[] args)
        {
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                if (b == 1)
                {
                    return;                          //return to outside of the Main even though finally block will execute
                }
                int result = a / b;
                Console.WriteLine("result is " + result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("finally block executed");
            }
            Console.WriteLine("End of the program");
        }
    }
}
