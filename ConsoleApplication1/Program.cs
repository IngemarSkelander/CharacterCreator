using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int n = Int32.Parse(Console.ReadLine());
            string[] a = Console.ReadLine().Split(' ');
            int[] input = new int[n];
            for (int i = 0; i < n; i++)
            {
                input[i] = Int32.Parse(a[i]);
            }

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += input[i];
            }

            int mean = sum / n;

            double squareSum = 0;
            for (int i = 0; i < n; i++)
            {
                squareSum += (Math.Pow(input[i] - mean, 2));
            }

            Console.WriteLine(Math.Sqrt( squareSum / n).ToString("#.#"));
            Console.Read();
        }

    }
}
