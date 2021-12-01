using System;

namespace FirstHomeWork
{
    public class FirstHW
    {
        //Пользователь вводит 2 числа (A и B). Выведите в консоль решение (5*A+B*B)/B-A
        public void SolveTask1_1()
        {
            double a = GetDoubleNumberFromUser("Введите число а:");
            double b = GetDoubleNumberFromUser("Введите число b:");
            
            double result = SolveExampleFirstTask(a, b);
            
            Console.WriteLine($"Решение (5 * A + B * B) / (B - A) = {result}");
        }

        public double SolveExampleFirstTask(double a, double b)
        {
            double result = 0;
            
            if ( (b - a) == 0 )
            {
                throw new DivideByZeroException(" B - A = 0");
            }
            
            result = (5 * a + b * b) / (b - a) ;     
            
            return result;
        }

        //Пользователь вводит 2 строковых значения(A и B).
        //Поменяйте содержимое переменных A и B местами.
        public void SolveTask2_1()
        {
            string a = GetStringFromUser("Введите строку A:");
            string b = GetStringFromUser("Введите строку B:");

            SwapOfValues(ref a, ref b);

            Console.WriteLine($"Результат второй задачи: A={a} ; B={b}");
        }

        public void SwapOfValues(ref string a, ref string b)
        {
            string c;

            c = a;
            a = b;
            b = c;

        }

        //Пользователь вводит 2 числа (A и B).
        //Выведите в консоль результат деления A на B и остаток от деления.
        public void SolveTask3_1()
        {
            int a = GetIntNumberFromUser("Введите переменную A:");
            int b = GetIntNumberFromUser("Введите переменную B:");
            
            int[] result = DivideAByB(a, b);
            
            Console.WriteLine($"Результат деления A на B и остаток от деления: {result}");
        }

        public int[] DivideAByB(int a, int b)
        {
            int del;
            int ost;

            if ((b == 0) || (a < b))
            {
                throw new ArgumentOutOfRangeException ($"Невозможно вывести результат деления A на B");
            }

            del = a / b;
            ost = b % a;
            
            return new int[] { del, ost };
        }

        //Пользователь вводит 3 не равных 0 числа (A, B и С).
        //Выведите в консоль решение(значение X) линейного уравнения стандартного вида, где A*X+B=C.
        public void SolveTask4_1()
        {
            double a = GetDoubleNumberFromUser("Введите переменную A:");
            double b = GetDoubleNumberFromUser("Введите переменную B:");
            double c = GetDoubleNumberFromUser("Введите переменную C:");
            
            double result = SolveExampleSecondTask(a, b, c);
            
            Console.WriteLine($"Решение уравнения {a} * X + {b} = {c} : {result}");
        }

        public double SolveExampleSecondTask(double a, double b, double c)
        {
            double x = 0;
            if (a == 0)
            {
                throw new ArgumentNullException("Нет решения");
            }
            
            x = (c - b) / a;
                
            return x;
        }

        //Пользователь вводит 4 числа(X1, Y1, X2, Y2),
        //описывающие координаты 2-х точек на координатной плоскости.
        //Выведите уравнение прямой в формате Y = AX + B, проходящей через эти точки.
        public void SolveTask5_1()
        {
            double x1 = GetDoubleNumberFromUser("Введите координату X1:");
            double y1 = GetDoubleNumberFromUser("Введите координату Y1:");
            double x2 = GetDoubleNumberFromUser("Введите координату X2:");
            double y2 = GetDoubleNumberFromUser("Введите координату Y2:");
            
            string result = FindAnEquation(x1, y1, x2, y2);
            
            Console.WriteLine($"Уравнение прямой : {result}");
        }

        public string FindAnEquation(double x1, double y1, double x2, double y2)
        {
            double a;
            double b;
            
            string equation;

            if (x2 - x1 == 0)
            {
                throw new ArgumentOutOfRangeException ("Невозможно построить уравнение");
            }
            
            if (y2 - y1 == 0)   
            {
                equation = $" Y = {y1}";
            }
            else
            {
                a = (y2 - y1) / (x2 - x1);

                b = y1 - a * x1;

                if (b > 0)
                {
                    equation = $" Y = {a}X + {b} ";
                }
                else if (b < 0)
                {
                    equation = $" Y = {a}X - {Math.Abs(b)}";
                }
                else
                {
                    equation = $" Y = {a}X";
                }
            }

            return equation;
        }

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

        public string GetStringFromUser(string message)
        {
            Console.WriteLine(message);
            
            string userString = Console.ReadLine();
            
            return userString;
        }
    }
}
