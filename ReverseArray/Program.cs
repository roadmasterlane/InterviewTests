using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReverseArray
{
    [TestClass]
    public class Program
    {
        static void Main(string[] args)
        {
            //FindFirstNonRepeatingCharacterWithIndex("hello");
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
        static int ComputeExponentialValue(int baseValue,int power)
        {
            
            // calculate a^b
            if (power==0)
            {
                return 1;
            }
           
            return baseValue * ComputeExponentialValue(baseValue,power-1);

        }

        static int Modulus(int dividend, int divisor)
        {
            int remainder = 0;
            int temp = dividend / divisor;
            remainder = dividend - (divisor * temp);
            return remainder;
        }

        static int SquareRoot(int input)
        {
            return 0;
            // if input is 25 then the result is 5 but if 
            // it is not a perfect square root then return 0

        }

        static string ReverseString(string s)
        {
            int forward = 0;
            char[] array = new char[s.Length];
            for (int jIndex =s.Length-1 ; jIndex >=0 ; jIndex--)
            {
                array[jIndex] = s[forward++];
            }

            return new string(array);
        }

        static void FindFirstRepeatingCharacterWithIndex(string input)
        {
           
            char[] charArray = new char[input.Length];
            for (int j = 0; j < charArray.Length; j++)
            {
                if (charArray.Contains(input[j]))
                {
                    Console.WriteLine("first character is: " + input[j] + 
                        " index is " + j);
                }
                else
                {
                    charArray[j] = input[j];
                }
            }

            
        }

        [TestMethod]
        public void FindFirstNonRepeatingCharacterWithIndex()
        {
           string input = "hello";
            char charValue = input.FirstOrDefault(p => input.IndexOf(p) == input.LastIndexOf(p));
            // ie. whether we go from from or come from back ....the index matches
            Assert.AreEqual(input,"hello");
        }

       

    }
}
