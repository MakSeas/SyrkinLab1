using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyrkinLab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine(Taylor(1,3));
            
        }

        static ulong Factorial(ulong N)//Задание 1
        {
            ulong Result=1;
            
            for(ulong i=0; i < N; i++) 
            {        
                    Result *= i+1;   
            }

            return Result;
        }

        static double Procedure(double x)//Задание 2
        {
            return Math.Sqrt(Math.Log(4/x))-(1/x)-Math.Exp(Math.Sin(x));
        }

        static string Fibonachi(int n) // Задание 3
        {
            int[] str = new int[n];

            string fibstr="0, 1, 1";

            str[0] = 0;
            str[1] = 1;
            str[2] = 1;

            for(int i = 3; i < n; i++)
            {
                str[i] = str[i-1] + str[i-2];

                fibstr += $", {str[i]}";
            }

            return fibstr;
        }

        static string Taylor(int x,int n)//Задание 4
        {
            double result = 1;

            int Digits=0;
            int PastDigits=1;

            ulong k=0;

            while(true)
            {
                result+=(Math.Pow(x,k)/Factorial(k));
                Digits = (int)(result * Math.Pow(10, n)/1);

                if(Digits==PastDigits) break;

                PastDigits = Digits;

                Console.WriteLine($"{result} || {Digits}");

                k++;
            }
            Console.WriteLine($"- {result} -");

            return $"Первые {n} цифр после запятой начинают повторяться на числе {result}";
        }
    }
}
