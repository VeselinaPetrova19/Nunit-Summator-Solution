using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summator
{
    public class Summator
    {
        public static long Sum(int[] arr)
        {
            long sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum; 
        }
        public static double Average(int[] arr)
        {
            double average = 0; 
            for(int i = 0; i < arr.Length; i++)
            {
                average += arr[i];
            }
            return average / arr.Length;
        }
    }
}
