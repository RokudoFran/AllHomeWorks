using System;

namespace FifthHomeWork
{
    public class FifthHW
    {
        //Найти минимальный элемент массива
        //Найти индекс минимального элемента массива
        public void SolveTask1_3_5()
        {
            int line = GetIntNumberFromUser("Введите длину массива:");
            int column = GetIntNumberFromUser("Введите ширину массива:");
            int a = GetIntNumberFromUser("Введите диапазон чисел для заполнения массива от:");
            int b = GetIntNumberFromUser("до:");

            int[,] array = CreateAndPopulatAnDoubleArray(line,column, a, b);

            Console.WriteLine("Массив");
            OutputArray(array);

            string result = SearchMinElementAndItsIndex(array);

            Console.WriteLine($"Минимальный эллемент массива = {result}");
        }

        public string SearchMinElementAndItsIndex(int[,] array)
        {
            int i = 0;
            int j = 0;

            int line = array.GetLength(0);
            int column = array.GetLength(1);

            string minIndex = "";
            int minValue = array[i, j];

            string message = "";


            for (i = 0; i < line; i++)
            {
                for (j = 0; j < column; j++)
                {
                    if (array[i, j] < minValue)
                    {
                        minValue = array[i, j];
                        minIndex = $"[ {i};{j} ]";
                    }
                }
            }

            message = $"{minValue}{minIndex}";

            return message;
        }

        //Найти максимальный элемент массива
        //Найти индекс максимального элемента массива
        public void SolveTask2_4_5()
        {
            int line = GetIntNumberFromUser("Введите длину массива:");
            int column = GetIntNumberFromUser("Введите ширину массива:");
            int a = GetIntNumberFromUser("Введите диапазон чисел для заполнения массива от:");
            int b = GetIntNumberFromUser("до:");

            int[,] array = CreateAndPopulatAnDoubleArray(line, column, a, b);

            Console.WriteLine("Массив");
            OutputArray(array);

            string result = SearchMaxElementAndItsIndex(array);

            Console.WriteLine($"Максимальный эллемент массива = {result}");
        }

        public string SearchMaxElementAndItsIndex(int[,] array)
        {
            int i = 0;
            int j = 0;

            int line = array.GetLength(0);
            int column = array.GetLength(1);

            string maxIndex = "";
            int maxValue = array[i, j];

            string message = "";

            for (i = 0; i < line; i++)
            {
                for (j = 0; j < column; j++)
                {
                    if (array[i, j] > maxValue)
                    {
                        maxValue = array[i, j];
                        maxIndex = $"[ {i};{j} ]";
                    }
                }
            }

            message = $" {maxValue}{maxIndex}";

            return message;
        }

        //Найти количество элементов массива, которые больше всех своих соседей одновременно
        public void SolveTask5_5()
        {
            int line = GetIntNumberFromUser("Введите длину массива:");
            int column = GetIntNumberFromUser("Введите ширину массива:");
            int a = GetIntNumberFromUser("Введите диапазон чисел для заполнения массива от:");
            int b = GetIntNumberFromUser("до:");

            int[,] array = CreateAndPopulatAnDoubleArray(line, column, a, b);

            Console.WriteLine("Массив");
            OutputArray(array);

            string result = GetElementsLargerThanNeighbors(array);

            Console.WriteLine
            ($"Количество элементов массива, которые больше всех своих соседей одновременно равно{result}");
        }

        public string GetElementsLargerThanNeighbors(int[,] array)
        {
            int i = 0;
            int j = 0;

            int line = array.GetLength(0);
            int column = array.GetLength(1);

            int tmp = 0;

            string elements = "";

            string message = "";

            for (i = 0; i < line; i++)
            {
                for (j = 0; j < column; j++)
                {
                    if (
                            ( (j == column - 1) || (array[i, j] > array[i, j + 1]) ) &&
                            ( (j == 0) || (array[i, j] > array[i, j - 1]) ) &&
                            ( (i == 0) || (array[i, j] > array[i - 1, j]) ) &&
                            ( (i == line - 1) || (array[i, j] > array[i + 1, j]) )
                        )
                    {
                        elements += $" {array[i, j]} [{i},{j}] ;";
                        tmp++;
                    }
                }
            }

            message = $"{tmp}:{elements}";

            return message;
        }

        //Отразите массив относительно его главной диагонали
        public void SolveTask6_5()
        {
            int line = GetIntNumberFromUser("Введите размер квадтратного массива:");
            int a = GetIntNumberFromUser("Введите диапазон чисел для заполнения массива от:");
            int b = GetIntNumberFromUser("до:");

            int[,] array = CreateAndPopulatAnDoubleArray(line, line, a, b);

            Console.WriteLine("Массив до");
            OutputArray(array);

            FlipAnArrayAlongTheMainDiagonal(array);

            Console.WriteLine("Массив после");
            OutputArray(array);

        }

        public void FlipAnArrayAlongTheMainDiagonal(int[,] array)
        {
            int i = 0;
            int j = 0;

            int line = array.GetLength(0);

            int tmp = 0;

            for (i = 0; i < line; i++)
            {
                for (j = 1 + i; j < line; j++)
                {
                    tmp = array[i, j];
                    array[i, j] = array[j, i];
                    array[j, i] = tmp;
                }
            }

        }

        //
        public int[,] CreateAndPopulatAnDoubleArray(int line, int column, int a, int b)
        {
            int[,] array = new int[line,column];
            Random rnd = new Random();

            int i = 0;
            int j = 0;

            for (i = 0; i < line; i++)
            {
                Console.WriteLine();
                for (j = 0; j < column; j++)
                {
                    array[i, j] = rnd.Next(a, b);
                }
            }

            return array;
        }

        public int GetIntNumberFromUser(string message)
        {
            Console.WriteLine(message);

            int number = Convert.ToInt32(Console.ReadLine());

            return number;
        }

        public void OutputArray(int[,] array)
        {
            int i = 0;
            int j = 0;

            int line = array.GetLength(0);
            int column = array.GetLength(1);

            for (i = 0; i < line; i++)
            {
                for (j = 0; j < column; j++ )
                {
                    Console.Write($"{array[i,j]}\t");
                }

                Console.WriteLine();
            }
        }
    }
}
