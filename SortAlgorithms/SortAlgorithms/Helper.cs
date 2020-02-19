using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    public static class Helper
    {
        //in doc it says static class can't have constructor but you can add static constr  
        //static class used to make extention  methods   Those are interview questions
        public static void insertionsort(int[] Numbers)
        {

            for (int i = 0; i < Numbers.Length - 1; i++)
            {

                for (int j = i + 1; j < Numbers.Length; j++)
                {
                    if (Numbers[j] <= Numbers[i])
                    {
                        //swaping the 2 numbers
                        int temp = Numbers[j];
                        Numbers[j] = Numbers[i];
                        Numbers[i] = temp;

                    }

                }
            }

        }
        public static int RecursiveFactorial(int Number)
        {
            //i will use this to show stack call and we should focuse cuz we will need it in Binary Search Tree
            // if i got time i will explan how to claculate the asympotic notation of recusive if not it yours duty
            if (Number == 0)
            {
                return 1;
            }
            else
            {
                return Number * RecursiveFactorial(Number - 1);
            }

        }

        //from first session we know that NonRecusive is better than recusive
        //Iterative approuch
        public static int Factorial(int Number)
        {
            int result = 1;
            for (int i = Number; i <= 1; i--)
            {
                result *= i;
            }
            return result;
        }

        public static bool PalindromComplex(string Input)
        {
            //YOu should understand the Recusrive from those 2 examples so you could continue
            Input = Input.ToLower();
            //if we cut the string down untill it no longer can be cut toot  or tozot both are palindrom
            if (Input.Length == 0 || Input.Length == 1)
            {
                return true;
            }
            //by this way i cut the first and last letter if they are the same
            if (Input[0] == Input[Input.Length - 1])
            {
                return PalindromComplex(Input.Substring(1, Input.Length - 2));
            }
            else
            {
                return false;
            }


        }
        //Search How to Make fibo 
        //get me the O of them

        public static int Fibonnic(int n)
        {
            //The Fibonacci Sequence is the series of numbers: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, ... 
            //The next number is found by adding up the two numbers before it.
            //T(n<=1) = O(1)
            //O(2^n) T(n) = T(n-1) + T(n-2) + O(1)
            // you can draw the recursion tree, 
            //which will have depth n and intuitively figure out that this function is asymptotically O(2n)
            //the another approuch
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return Fibonnic(n - 1) + Fibonnic(n - 2);
            }
        }

        public static int Fibonnic2(int n)
        {
            //O(n)
            //go and draw O(n) vs O(2^n)
            int a = 1;
            int b = 1;
            int c = 0;
            for (int i = 1; i < n; i++)
            {

                c = a + b;
                b = a;
                a = c;

                Console.WriteLine(c);
            }
            return c;
        }
    }
}
