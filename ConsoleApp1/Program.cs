using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    class Class
    {
        static int[][] Input()
        {
            Console.WriteLine("Введите размерность массива");
            Console.Write("n = ");
            int[][] a;
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Неверный формат данных. Введите целое число.");
                Console.Write("n = ");
            }
            a = new int[n][];
            for (int i = 0; i < n; ++i)
            {
                a[i] = new int[n];
                for (int j = 0; j < n; ++j)
                {
                    Console.Write("a[{0},{1}]= ", i, j);
                    while (!int.TryParse(Console.ReadLine(), out a[i][j]))
                    {
                        Console.WriteLine("Неверный формат данных. Введите целое число.");
                        Console.Write("a[{0},{1}]= ", i, j);
                    }
                }
            }
            Console.Clear();
            return a;
        }
    static void Print1(int[] a)
            {
                for (int i = 0; i < a.Length; ++i)
                    Console.Write("{0,5} ", a[i]);
            }

            static void Print2(int[][] a)
            {
                for (int i = 0; i < a.Length; ++i, Console.WriteLine())
                    for (int j = 0; j < a[i].Length; ++j)
                        Console.Write("{0,5} ", a[i][j]);
            }

            static int Min(int[][] a, int j)
            {
                int max = a[0][j];
                for (int i = 1; i < a.Length; ++i)
                    if (a[i][j] > max) { max = a[i][j]; }
                return max;
            }

            static void Main()
            {
                int[][] myArray = Input();
                Console.WriteLine("Исходный массив:");
                Print2(myArray);
                int[] rez = new int[myArray.Length];
                for (int i = 0; i < myArray.Length; ++i)
                    rez[i] = Min(myArray, i);
                Console.WriteLine("Новый массив:");
                Print1(rez);
                Console.ReadLine();
        }
        }
    }