using System;

namespace Summator
{
    public class Program
    {
        static void Main(string[] args)
        {
            long sum = Summator.Sum(new int[] { 1, 2, 3, 4, 5, 6 });
           Console.WriteLine(sum);   
            
           if(sum == 21)
            {
                Console.WriteLine("Test PASS");
            } else
            {
                Console.WriteLine("Test FAIL");
            }

            double average = Summator.Average(new int[] { 7, 8, 9, 10 });
            Console.WriteLine(average.ToString());
            if(average == 8.5)
            {
                Console.WriteLine("Test PASS");
            } else
            {
                Console.WriteLine("Test FAIL");
            }
        }
    }
}