using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, i, j;
            Console.Write("Sütun Sayısını Giriniz : ");
            a = Convert.ToInt16(Console.ReadLine());
            Console.Write("Satır Sayısını Giriniz : ");
            b = Convert.ToInt16(Console.ReadLine());

            int[,] X = new int[10,10];
            Console.Write("\nBirinci matrisi giriniz : \n");
            for (i = 0; i < a; i++)
            {
                for (j = 0; j < b; j++)
                {
                    X[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }

            int[,] Y = new int[10,10];
            Console.Write("\nIkinci matrisi giriniz : \n");
            for (i = 0; i < a; i++)
            {
                for (j = 0; j < b; j++)
                {
                    Y[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }

            int[,] Z = new int[10,10];
            for (i = 0; i < a; i++)
            {
                for (j = 0; j < b; j++)
                {
                    Z[i, j] = X[i, j] + Y[i, j];
                }
            }
            Console.Write("\nMatrislerin Toplamı : \n");
            for (i = 0; i < a; i++)
            {
                for (j = 0; j < b; j++)
                {
                    Console.Write(Z[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
