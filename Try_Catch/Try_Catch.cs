using System;

namespace Exception_Handling_3
{
    class Try_Catch
    {
        static void Main(string[] args)
        {

            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int result = a / b;
                Console.WriteLine("result is " + result);

            }
            catch (DivideByZeroException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            catch (FormatException ex2)
            {
                Console.WriteLine("Input must be numeric.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
