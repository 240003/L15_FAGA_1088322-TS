
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace L15_FAGA_1088322
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            {
                int[,] matriz = new int[40, 50];
                int sumaTotal = 0;
                Random r = new Random();
                for (int i = 0; i < 40; i++)
                {
                    for (int j = 0; j < 50; j++)
                    {
                        matriz[i, j] = r.Next(-150, 25);
                    }
                }
                for (int i = 0; i < 40; i++)
                {
                    for (int j = 0; j < 50; j++)
                    {
                        Console.Write(" " + matriz[i, j]);
                        sumaTotal += matriz[i, j];
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("El resultado de toda la matriz es: " + sumaTotal);
                Console.ReadKey();
            }
        }
    }
}