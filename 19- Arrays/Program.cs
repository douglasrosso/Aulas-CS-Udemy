using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19__Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 19- Arrays

            //Array de uma dimensão
            int[] num1 = new int[3];
            num1[0] = 10;
            num1[1] = 100;
            num1[2] = 1000;
            Console.WriteLine(num1[0]);
            Console.WriteLine(num1[1]);
            Console.WriteLine(num1[2]);

            Console.WriteLine("\r\n");

            //Outras maneiras de criar um array 
            int[] num2 = { 20, 200, 2000 };
            Console.WriteLine(num2[0]);
            Console.WriteLine(num2[1]);
            Console.WriteLine(num2[2]);

            Console.WriteLine("\r\n");

            int[] num3 = new int[] { 30, 300, 3000 };
            Console.WriteLine(num3[0]);
            Console.WriteLine(num3[1]);
            Console.WriteLine(num3[2]);

            Console.WriteLine("\r\n");

            //Array de duas dimensões
            string[,] num4 = new string[2, 3];
            num4[0, 0] = "1";
            num4[0, 1] = "2";
            num4[0, 2] = "3";
            num4[1, 0] = "11";
            num4[1, 1] = "12";
            num4[1, 2] = "13";

            Console.WriteLine(num4[0, 0]);
            Console.WriteLine(num4[0, 1]);
            Console.WriteLine(num4[0, 2]);
            Console.WriteLine(num4[1, 0]);
            Console.WriteLine(num4[1, 1]);
            Console.WriteLine(num4[1, 2]);

            Console.WriteLine("\n---------------------------------------------------------------------------\n");
            Console.WriteLine("Precione qualquer tecla para sair!");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
