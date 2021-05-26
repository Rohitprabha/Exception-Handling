using System;

namespace Exception_Handling_2
{
    class FormatException
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());          // x = 4
            int y = int.Parse(Console.ReadLine());          // y = y        System.FormatException: 'Input string was not in a correct format.'
            int result = x + y;
            Console.WriteLine(result);

        }
    }
}
