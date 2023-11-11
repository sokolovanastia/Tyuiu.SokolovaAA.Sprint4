using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SokolovaAA.Sprint4.Task4.V27.Lib;
namespace Tyuiu.SokolovaAA.Sprint4.Task4.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Соколова А.А. | АСОиУб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (ввод с клавиатуры)                             *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнила: Соколова Анастасия Александровна | АСОиУб-23-3               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 9. Найдите сумму нечетных   *");
            Console.WriteLine("* элементов массива.                                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int rows = 5;
            int columns = 5;
            Console.WriteLine("Количество строк в массиве = " + rows);
            Console.WriteLine("Количество столбцов в массиве = " + columns);

            Console.WriteLine("***************************************************************************");

            int[,] Array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"Введите {i}, {j} элемент массива: ");
                    Array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine("Массив: ");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{Array[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(Array);
            Console.WriteLine("Сумма нечётных элементов массива = " + result);

            Console.ReadKey();
        }
    }
}
