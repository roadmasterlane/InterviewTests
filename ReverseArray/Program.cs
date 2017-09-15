using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintPascalTriangles(5);
            Console.Read();
        }

        static int Factorial(int n)
        {
            if (n < 0)
                return -1;
            if (n==0)
            {
                return 1;
            }
            /*if (n==1)
            {
                return 1;
            }*/

            return Factorial(n - 1) * n;
        }

        static int i = 0;
        static int PowersOf2(int n)
        {
            
            if (n== 0) return 1;
            while (i<n)
            {
                i++;
                return 2 * PowersOf2(n);
            }

            return 1;

        }


        static int PowersOf2Other(int n)
        {
            if (n<1)
            {
                return 0;
            }

            else if (n==1)
            {
               Console.Write(1);
                return 1;
            }

            else
            {
                int prev = PowersOf2Other(n / 2);
                int curr = prev * 2;
                Console.Write(curr);
                return curr;
            }
        }


        static void PrintPascalTriangles(int level)
        {

        }

    }
}
