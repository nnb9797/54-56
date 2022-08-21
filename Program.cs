using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54_56
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void Zadacha54()
            {
                //Задайте двумерный массив.Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
                //Например, задан массив:
                //1 4 7 2
                //5 9 2 3
                //8 4 2 4
                //В итоге получается вот такой массив:
                //7 4 2 1
                //9 5 3 2
                //8 4 4 2
                int rows = 5;
                int columns = 6;
                int[,] array = new int[rows, columns];
                FillArray(array);
                PrintArray(array);

                Sort(array);
                Console.WriteLine();
                Console.WriteLine("Отсортированный массив");
                PrintArray(array);




            }

            void Zadacha56()
            {
                //Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
                //Например, задан массив:
                //1 4 7 2
                //5 9 2 3
                //8 4 2 4
                //5 2 6 7
                //Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
                int rows = 5;
                int columns = 6;
                int[,] array = new int[rows, columns];
                FillArray(array);
                PrintArray(array);

                int indexMin = 0;
                int sumMin = Int32.MaxValue;

                for (int i = 0; i < rows; i++)
                {
                    int sum = Rowsum(array, i);
                    Console.WriteLine($"В строке {i + 1} сумма элементов равна {sum}");
                    if (sum < sumMin)
                    {
                        sumMin = sum;
                        indexMin = i;
                    }
                }
                Console.WriteLine();
                Console.WriteLine($"Минимальная сумма равна {sumMin} и находится в строке {indexMin + 1}");

                int Rowsum(int[,] Array, int i)

                {
                    int sum = 0;
                    int column = array.GetLength(1);
                    for (int j = 0; j < columns; j++)
                    {
                        sum += array[i, j];
                    }
                    return sum;
                }

            }


            void Sort(int[,] array)
            {
                int rows = array.GetLength(0);
                int columns = array.GetLength(1);
                for (int i = 0; i < rows; i++)
                {
                    for (int j = columns - 1; j > 0; j--)
                    {
                        for (int k = 0; k < j; k++)
                        {

                            if (array[i, k] < array[i, k + 1])
                            {
                                int temp = array[i, k];
                                array[i, k] = array[i, k + 1];
                                array[i, k + 1] = temp;

                            }
                        }


                    }
                }
            }
            void FillArray(int[,] array, int startNumber = 0, int finishNumber = 50)
            {
                finishNumber++;
                Random random = new Random();
                int rows = array.GetLength(0);
                int columns = array.GetLength(1);


                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        array[i, j] = random.Next(startNumber, finishNumber);
                    }
                }
            }
            void PrintArray(int[,] array)
            {
                int rows = array.GetLength(0);
                int columns = array.GetLength(1);
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write(array[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

            }
            //Zadacha54();
            //Zadacha56();

        }
    }
}
