﻿using System;
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
            int[,]PascalArray = new int[level,level];
            for (int rowIndex = 0; rowIndex < level; rowIndex++)
            {
                for (int colIndex = 0; colIndex <= rowIndex; colIndex++)
                {
                    if (rowIndex==colIndex)
                    {
                        PascalArray[rowIndex, colIndex] = 1;
                        Console.Write(PascalArray[rowIndex,colIndex]);
                        Console.Write(" ");
                    }

                    else if (colIndex==0)
                    {
                        PascalArray[rowIndex, colIndex] = 1;

                        Console.Write(PascalArray[rowIndex, colIndex]);
                        Console.Write(" ");
                    }

                    else
                    {
                        PascalArray[rowIndex, colIndex] = PascalArray[rowIndex - 1, colIndex - 1] +
                                                          PascalArray[rowIndex - 1, colIndex];

                        Console.Write(PascalArray[rowIndex,colIndex]);
                        Console.Write(" ");
                    }

                }
                Console.Write("\n");



            }
        }
    }
}
