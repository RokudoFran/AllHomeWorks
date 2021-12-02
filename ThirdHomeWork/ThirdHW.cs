using System;

namespace ThirdHomeWork
{
    public class ThirdHW
    {
        //Пользователь вводит 2 числа (A и B). Возвести число A в степень B.
        public void SolveTask1_3()
        {
            double a = GetDoubleNumberFromUser("Введите число A:");
            int b = GetIntNumberFromUser("Введите введите степень числа B:");

            double result = RaiseNumberAToPowerB(a, b);

            Console.WriteLine($"Число {a} в степени {b} = {result}");
        }

        public double RaiseNumberAToPowerB(double a, int b)
        {
            double c = 1;
            int b1 = Math.Abs(b);

            if (a == 0)
            {
                throw new ArgumentNullException("Введите число А не равное нулю");
            }
            
            if (b != 0)
            {
                    
                for (int i = 1; i <= b1; i++)
                {
                    c *= a;
                }

                if ( b < 0 )
                {
                    c = 1 / c;
                }
            }            

            return c;
        }

        //Пользователь вводит 1 число (A).
        //Вывести все числа от 1 до 1000, которые делятся на A.
        public void SolveTask2_3()
        {
            int a = GetIntNumberFromUser("Введите число A:");

            int[] result = GetNumbersDivisibleByA(a);

            Console.WriteLine($"Числа кратные A от 1 до 1000 : {result}");
        }

        public int[] GetNumbersDivisibleByA(int a)
        {
            if ((a == 0) || (Math.Abs( a ) > 1000))
            {
                throw new ArgumentOutOfRangeException(" Число a равно нулю или больше 1000 по модулю ");
            }

            int lengthM = 1000 / a;
            int[] result = new int[lengthM];
            int n = 0;

            
            for (int i = 1; i <= 1000; i++)
            {
                if (i % a == 0)
                {
                    result[n] = i;
                    n++;
                }
            }
            
            return result;
        }

        //Пользователь вводит 1 число(A).
        //Найдите количество положительных целых чисел, квадрат которых меньше A.
        public void SolveTask3_3()
        {
            int a = GetIntNumberFromUser("Введите число A:");

            int result = FindTheSomeNumberOfPositiveIntegersWhoseSquareIsLessThanA(a);

            Console.WriteLine($" Количество положительных целых чисел, квадрат которых меньше A = {a}, равно {result}");
        }

        public int FindTheSomeNumberOfPositiveIntegersWhoseSquareIsLessThanA(int a)
        {
            if (a <= 0)
            {
                throw new ArgumentOutOfRangeException (" Число A меньше, либо равно нулю ");
            }
            
            int b = 1;

            while (b * b < a)
            {
                b++;
            }

            b--;

            return b;
            

        }

        //Пользователь вводит 1 число (A).
        //Вывести наибольший делитель (кроме самого A) числа A.
        public void SolveTask4_3()
        {
            int a = GetIntNumberFromUser("Введите число A:");

            int result = FindGreatestDivisor(a);

            Console.WriteLine($" Наибольшим делителем числа А = {a}, является число равное {result}");
        }

        public int FindGreatestDivisor(int a)
        {
            int delitel = 0;

            if (a == 0)
            {
                throw new ArgumentNullException(" Число A равно нулю ");
            }
            
            for (int i = a / 2; i > 1; i--)
            {
                if (a % i == 0)
                {

                    if (i > delitel)
                    {
                        delitel = i;
                            
                        break;
                    }
                }
            }

            return delitel;

        }

        //Пользователь вводит 2 числа (A и B).
        //Вывести сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7.
        //(Учтите, что при вводе B может оказаться меньше A).
        public void SolveTask5_3()
        {
            int a = GetIntNumberFromUser("Введите число A:");
            int b = GetIntNumberFromUser("Введите число B:");

            int result = FindMultiplesOfSeven(ref a, ref b);

            Console.WriteLine($"Сумма всех чисел из диапазона от {a} до {b} , которые делятся без остатка на 7, равна {result}");
        }

        public int FindMultiplesOfSeven(ref int a, ref int b)
        {
            
            int c = 0;

            if (a == 0 && b == 0)
            {
                throw new ArgumentNullException("Числа A и B равны нулю");
            }

            SwapOfValues(ref a, ref b);

            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0)
                {
                    c += i;
                }
            }

            return c;
            
        }

        public void SwapOfValues(ref int a, ref int b)
        {
            int c = 0;

            if ( b < a )
            {
                c = a;
                a = b;
                b = c;
            }

        }


        //Пользователь вводит 1 число (N).
        //Выведите N-ое число ряда фибоначчи.
        //В ряду фибоначчи каждое следующее число является суммой двух предыдущих.
        //Первое и второе считаются равными 1.
        public void SolveTask6_3()
        {
            int n = GetIntNumberFromUser("Введите порядковый номер числа ряда Фибоначи:");

            int result = FindFibonacciNumber(n);

            Console.WriteLine($" число {n} ряда Фибоначи равно {result}");
        }

        public int FindFibonacciNumber(int n)
        {
            int a = 1;
            int b = 1;
            int c = 1;

            if(n==0)
            {
                return 0;
            }
            else if (n > 0)
            {
                for (int i = 1; i < n - 1; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
            }
            else
            {
                for (int i = -1; i < n + 1; i--)
                {
                    if (n % 2 == 0)
                    {
                        c = Math.Abs(a + b);
                        a = b;
                        b = -c;
                    }
                    else
                    {
                        c = Math.Abs(a + b);
                        a = b;
                        b = c;
                    }
                }
            }

            return c;
        }

        //Пользователь вводит 2 числа.
        //Найти их наибольший общий делитель используя алгоритм Евклида.
        public void SolveTask7_3()
        {
            int a = GetIntNumberFromUser("Введите число A:");
            int b = GetIntNumberFromUser("Введите число B:");

            int result = FindGreatestCommonDivisorOfTwoIntegers(a, b);

            Console.WriteLine($"Наибольший общий делитель чисел А = {a} и B = {b} равен {result}");
        }

        public int FindGreatestCommonDivisorOfTwoIntegers(int a, int b)
        {
            int gcd = Math.Abs(a + b);

            int a1 = a;
            int b1 = b;

            if (a1 == 0 || b1 == 0)
            {
                throw new ArgumentException("Число A или/и B равно нулю");
            }
            
            while ((a1 != 0) && (b1 != 0))
            {
                if (Math.Abs(a1) > Math.Abs(b1))
                {
                    a1 = a1 % b1;
                }
                else
                {
                    b1 = b1 % a1;
                }
            }

            gcd = Math.Abs(a1 + b1);

            return gcd;
            
        }

        //Пользователь вводит целое положительное число, которое является кубом целого числа N.
        //Найдите число N методом половинного деления.
        public void SolveTask8_3()
        {
            int a = GetIntNumberFromUser("Введите число A:");

            int result = FindTheRootOfACubeByHalfDivision(a);

            Console.WriteLine($" Число А = {a}, является кубом числа {result}");
        }

        public int FindTheRootOfACubeByHalfDivision(int a)
        {
            int right = a;
            int left = 0;
            int center = a / 2;
            
            if ( a <= 0 )
            {
                throw new ArgumentException("Число A меньше либо равно нулю");
            }
            
            while (center * center * center != a)
            {
                if (left < right)
                {
                    center = (right + left) / 2;
                    
                    if (center * center * center > a)
                    {
                        right = center;
                    }
                    else
                    {
                        left = center;
                    }

                }
                else
                {
                    center = left;
                    center = (right + left) / 2;
                }
            }

            return center;
        }

        //Пользователь вводит 1 число. Найти количество нечетных цифр этого числа.
        public void SolveTask9_3()
        {
            int a = GetIntNumberFromUser("Введите число A:");

            int result = FindTheSomeOddDigitsOfANumber(a);

            Console.WriteLine($" Кол-во нечетных чисел числа A = {a} равно {result}");
        }

        public int FindTheSomeOddDigitsOfANumber(int a)
        {
            int even = 0;
            int odd = 0;

            if (a == 0)
            {
                throw new ArgumentNullException("Число A равно нулю");
            }
            
            while (Math.Abs(a) > 0)
            {
                if (a % 2 != 0)
                {
                    odd++;
                    a = a / 10;
                }
                else
                {
                    even++;
                    a = a / 10;
                }
            }

            return odd;
            
        }

        //Пользователь вводит 1 число.
        //Найти число,
        //которое является зеркальным отображением последовательности цифр заданного числа,
        //например, задано число 123, вывести 321.
        public void SolveTask10_3()
        {
            int a = GetIntNumberFromUser("Введите число A:");

            int result = SearchBackwardNumber(a);

            Console.WriteLine($" Зеркальным отображением числа A={a} является число {result}");
        }

        public int SearchBackwardNumber(int a)
        {
            int a1 = Math.Abs(a);
            int b = 0;
            int backwardNumber = 0;

            if (a == 0)
            {
                throw new ArgumentNullException("Число A равно нулю");
            }
            
            while (a1 > 0)
            {
                b = a1 % 10;
                backwardNumber = backwardNumber * 10 + b;
                a1 = a1 / 10;

            }

            if (a > 0)
            {
                backwardNumber = Math.Abs(backwardNumber);
            }
            else
            {
                backwardNumber = -backwardNumber;
            }
            
            return backwardNumber;
        }

        //Пользователь вводит целое положительное  число (N).
        //Выведите числа в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечетных.
        public void SolveTask11_3()
        {
            int n = GetIntNumberFromUser("Введите число N:");

            string result = FindNumbersByCondition(n);

            Console.WriteLine
            (
                $"Числа в диапазоне от 1 до {n}, сумма четных цифр которых больше суммы нечетных:{result}"
            );
        }

        public string FindNumbersByCondition(int a)
        {
            int n;
            int even = 0;
            int odd = 0;

            string message = "";

            if (a <= 0 )
            {
                throw new ArgumentOutOfRangeException("Число A меньше, либо равно нулю");
            }

            for (int i = 1; i <= a; i++)
            {

                int tmp = i;

                while (tmp > 0)
                {
                    n = tmp % 10;
                    if (n % 2 == 0)
                    {
                        even = +n;
                    }
                    else
                    {
                        odd = +n;
                    }
                    tmp = tmp / 10;
                    n = 0;
                }

                if (even > odd)
                {
                    message += $" {i} ;";

                    odd = 0;
                    even = 0;
                }
                else
                {
                    odd = 0;
                    even = 0;
                }
            }

            return message;
        }

        //Пользователь вводит 2 числа.
        //Сообщите, есть ли в написании двух чисел одинаковые цифры.
        //Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ”.
        public void SolveTask12_3()
        {
            int a = GetIntNumberFromUser("Введите число A:");
            int b = GetIntNumberFromUser("Введите число B:");

            string result = CheckForDuplicateNumbers(a, b);

            Console.WriteLine($"{result}");
        }

        public string CheckForDuplicateNumbers(int a, int b)
        {
            int a1 = Math.Abs(a);
            int b1 = Math.Abs(b);

            int comparison = 0;
            int i = 0;
            int j = 0;
            string result = "";

            do
            {
                i = a1 % 10;
                do
                {
                    j = b1 % 10;
                    if (i == j)
                    {
                        comparison++;
                    }

                    b1 /= 10;
                }
                while (b1 > 0);

                b1 = b;
                a1 /= 10;
            }
            while (a1 > 0);

            if (comparison != 0)
            {
                result = "YES";
            }
            else
            {
                result = "NO";
            }


            return result;
        }

        //
        public int GetIntNumberFromUser(string message)
        {
            Console.WriteLine(message);

            int number = Convert.ToInt32(Console.ReadLine());

            return number;
        }

        public double GetDoubleNumberFromUser(string message)
        {
            Console.WriteLine(message);

            double number = Convert.ToDouble(Console.ReadLine());

            return number;
        }
    }
}
