using System;

namespace FourthHomeWork
{
    public class FourthHW
    {
        //Найти минимальный элемент массива
        //Найти индекс минимального элемента массива
        public void SolveTask1_3_4()
        {
            int lenght = GetIntNumberFromUser("Введите длину массива:");
            int a = GetIntNumberFromUser("Введите диапазон чисел для заполнения массива от:");
            int b = GetIntNumberFromUser("до:");

            int[] array = FormingAndFillingAnArray(lenght, a, b);

            string result = SearchMinElementArray(array);  

            Console.WriteLine($"Минимальный эллемент массива = {result}");
        }

        public string SearchMinElementArray(int[] array)
        {
            int i = 0;
            int minIndex = 0;
            int minValue = array[i];

            for (i = 0; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                    minIndex = i;
                }
            }

            string message = $"{minValue}[{minIndex}]";

            return message;
        }

        //Найти максимальный элемент массива
        //Найти индекс максимального элемента массива
        public void SolveTask2_4_4()
        {
            int lenght = GetIntNumberFromUser("Введите длину массива:");
            int a = GetIntNumberFromUser("Введите диапазон чисел для заполнения массива от:");
            int b = GetIntNumberFromUser("до:");

            int[] array = FormingAndFillingAnArray(lenght, a, b);

            string result = SearchMaxElementArray(array);

            Console.WriteLine($"Максимальный эллемент массива = {result}");
        }

        public string SearchMaxElementArray(int[] array)
        {
            int i = 0;
            int maxIndex = 0;
            int maxValue = array[i];

            for (i = 0; i < array.Length; i++)
            {
                if (array[i] < maxValue)
                {
                    maxValue = array[i];
                    maxIndex = i;
                }
            }

            string message = $"{maxValue}[{maxIndex}]";

            return message;
        }

        //Посчитать сумму элементов массива с нечетными индексами
        public void SolveTask5_4()
        {
            int lenght = GetIntNumberFromUser("Введите длину массива:");
            int a = GetIntNumberFromUser("Введите диапазон чисел для заполнения массива от:");
            int b = GetIntNumberFromUser("до:");

            int[] array = FormingAndFillingAnArray(lenght, a, b);

            int result = FindingTheSumOfTheElementsOfAnArrayWithAnOddIndex(array);

            Console.WriteLine($"Cумма элементов массива с нечетными индексами = {result}");
        }

        public int FindingTheSumOfTheElementsOfAnArrayWithAnOddIndex(int[] array)
        {
            int sum = 0;
            int i = 0;

            for (i = 1; i < array.Length; i += 2)
            {
                sum += array[i];
            }

            return sum;
        }

        //Сделать реверс массива (массив в обратном направлении)
        public void SolveTask6_4()
        {
            int lenght = GetIntNumberFromUser("Введите длину массива:");
            int a = GetIntNumberFromUser("Введите диапазон чисел для заполнения массива от:");
            int b = GetIntNumberFromUser("до:");

            int[] array = FormingAndFillingAnArray(lenght, a, b);

            int[] result = ReverseArray(array);

            Console.WriteLine(result);
        }

        public int [] ReverseArray(int[] array)
        {
            int tmp = 0;
            int j = array.Length - 1;

            for (int i = 0; i < array.Length / 2; i++)
            {
                tmp = array[i];
                array[i] = array[j - i];
                array[j - i] = tmp;
            }

            return array;
        }


        //Посчитать количество нечетных элементов массива
        public void SolveTask7_4()
        {
            int lenght = GetIntNumberFromUser("Введите длину массива:");
            int a = GetIntNumberFromUser("Введите диапазон чисел для заполнения массива от:");
            int b = GetIntNumberFromUser("до:");

            int[] array = FormingAndFillingAnArray(lenght, a, b);

            int result = FindingTheSumOfTheElementsOfAnArrayWithAnOddIndex(array);

            Console.WriteLine($"Количество нечетных элементов массива = {result}");
        }

        public int FindTheNumberOfOddArrayElements(int[] array)
        {
            int j = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    j++;
                }
            }

            return j;
        }


        //Поменять местами первую и вторую половину массива,
        //например, для массива 1 2 3 4, результат 3 4 1 2,  или для 12345 - 45312.
        public void SolveTask8_4()
        {
            int lenght = GetIntNumberFromUser("Введите длину массива:");
            int a = GetIntNumberFromUser("Введите диапазон чисел для заполнения массива от:");
            int b = GetIntNumberFromUser("до:");

            int[] array = FormingAndFillingAnArray(lenght, a, b);

            int[] result = ReplacingTheFirstAndSecondHalfOfTheArray(array);

            Console.WriteLine(result);
        }

        public int[] ReplacingTheFirstAndSecondHalfOfTheArray(int[] array)
        {
            int tmp = 0;
            int j = array.Length / 2;
            int c = array.Length % 2;

            for (int i = 0; i < j; i++)
            {
                tmp = array[i];
                array[i] = array[j + i + c];
                array[j + i + c] = tmp;
            }

            return array;
        }

        //Отсортировать массив по возрастанию одним из способов:
        //пузырьком(Bubble), выбором(Select) или вставками(Insert)) 
        public void SolveTask9_4()
        {
            int lenght = GetIntNumberFromUser("Введите длину массива:");
            int a = GetIntNumberFromUser("Введите диапазон чисел для заполнения массива от:");
            int b = GetIntNumberFromUser("до:");

            int[] array = FormingAndFillingAnArray(lenght, a, b);

            int[] result = SortArrayAscendingUsingSelect(array);

            Console.WriteLine(result);
        }

        public int[] SortArrayAscendingUsingSelect(int[] array)
        {
            int minIndex = 0;
            int minValue = 0;

            //index
            int i = 0;
            int j = 0;

            for (i = 0; i < array.Length - 1; i++)
            {
                minIndex = i;
                minValue = array[i];

                for (j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < minValue)
                    {
                        minValue = array[j];
                        minIndex = j;
                    }
                }

                minValue = array[i];
                array[i] = array[minIndex];
                array[minIndex] = minValue;

            }

            return array;
        }


        //Отсортировать массив по убыванию одним из способов, (отличным от способа в 9-м задании) :
        //пузырьком(Bubble), выбором(Select) или вставками(Insert))
        public void SolveTask10_4()
        {
            int lenght = GetIntNumberFromUser("Введите длину массива:");
            int a = GetIntNumberFromUser("Введите диапазон чисел для заполнения массива от:");
            int b = GetIntNumberFromUser("до:");

            int[] array = FormingAndFillingAnArray(lenght, a, b);

            int[] result = SortingArrayDescendingUsingInsert(array);

            Console.WriteLine(result);
        }

        public int[] SortingArrayDescendingUsingInsert(int[] array)
        {
            int tmp = 0;
            int j = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                j = i;
                while (j < array.Length - 1 && array[j] < array[j + 1])
                {
                    tmp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = tmp;

                    j++;
                }
            }

            return array;
        }

        //
        public int[] FormingAndFillingAnArray(int lenght, int a, int b)
        {
            int [] array = new int[lenght];
            Random rnd = new Random();

            int i = 0;

            for (i = 0; i < lenght; i++)
            {
                array[i] = rnd.Next(a, b);
            }

            return array;
        }

        public int GetIntNumberFromUser(string message)
        {
            Console.WriteLine(message);

            int number = Convert.ToInt32(Console.ReadLine());

            return number;
        }

    }
}
