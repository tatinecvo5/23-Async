using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _23_Async
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Factorial(n);
            Console.ReadKey();
        }
        static void Factorial(int n)
        {
            int f = 1;
            for (int i = n; i>1; i--)
            {
                f *= i;
                Thread.Sleep(100);
            }
            Console.WriteLine(f);
                   }
        static async void FactorialAsync(int n)
        {
            await Task.Run(()=>Factorial(n));
        }
    }
}
