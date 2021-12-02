using System;

namespace SecondHomeWork
{
    public class SecondHW
    {
        //Если A>B, подсчитать A+B, если A=B, подсчитать A*B, если A<B, подсчитать A-B.
        public void SolveTask1_2()
        {
            double a = GetDoubleNumberFromUser("Введите число а:");
            double b = GetDoubleNumberFromUser("Введите число b:");
            
            string result = FindASolutionByCondition(a, b);
            
            Console.WriteLine($"{result}");
        }

        public string FindASolutionByCondition(double a, double b)
        {
            double rezult = 0;

            string message = "";

            if (a == b)
            {
                rezult = a * b;

                message = $"при A = B , A * B = {rezult}";
            }
            else if (a > b)
            {
                rezult = a + b;

                message = $"при A > B , A + B = {rezult}";
            }
            else
            {
                rezult = a - b;

                message = $"при A < B , A - B = {rezult}";
            }

            return message;
        }

        //Пользователь вводит 2 числа(X и Y).
        //Определить какой четверти принадлежит точка с координатами(X, Y)
        public void SolveTask2_2()
        {
            double x = GetDoubleNumberFromUser("Введите координату X");
            double y = GetDoubleNumberFromUser("Введите координату Y:");

            int result = SearchQuarterX(x, y);

            string resultMessage = ReturnTheMessageWithTheResult(result);

            Console.WriteLine($"Точка с координатами ( {x} ; {y} ) лежит на {resultMessage}");
        }

        public int SearchQuarterX(double x, double y)
        {
            int result = 0;

            if ( x == 0 )
            {
                result = SearchQuarterY(y, x, 0);
            }
            else if ( x > 0 )
            {
                result = SearchQuarterY(y, x, 1);
            }
            else
            {
                result = SearchQuarterY(y, x, 2);
            }

            return result;
        }

        public int SearchQuarterY(double y, double x, int answer)
        {
            int  result = 0;
            
            if (y == 0)
            {
                result = answer switch
                {
                    0 => 0,
                    1 => 7,
                    2 => 5,
                };

            }
            else if (y > 0)
            {
                result = answer switch
                {
                    0 => 8,
                    1 => 1,
                    2 => 2,
                };
            }
            else
            {
                result = answer switch
                {
                    0 => 6,
                    1 => 4,
                    2 => 3,
                };
            }

            return result;
        }

        public string ReturnTheMessageWithTheResult(int quarter)
        {
            string message = "";

            message = quarter switch
            {
                0 => " начальной точке Оси координат.",
                1 => " I четверти Оси координат.",
                2 => " II четверти Оси координат.",
                3 => " III четверти Оси координат.",
                4 => " IV четверти Оси координат.",
                5 => " левой части Оси X.",
                6 => " нижней части Оси Y.",
                7 => " правой части Оси X.",
                8 => " верхней части Оси Y.",
            };

            return message;
        }

        //Пользователь вводит 3 числа(A, B и С).
        //Выведите их в консоль в порядке возрастания.
        public void SolveTask3_2()
        {
            double a = GetDoubleNumberFromUser("Введите переменную A:");
            double b = GetDoubleNumberFromUser("Введите переменную B:");
            double c = GetDoubleNumberFromUser("Введите переменную C:");

            string result = SortVariablesAscending(a, b, c);

            Console.WriteLine($"Результат третьей задачи: {result}");
        }

        public string SortVariablesAscending(double a, double b, double c)
        {
            string message = "";

            if ((a > b) && (a > c))
            {
                if (b > c)
                {
                    message = $"{c} {b} {a}";
                }
                else
                {
                    message = $"{b} {c} {a}";
                }
            }
            else
            {
                if (b > c)
                {
                    if (c > a)
                    {
                        message = $"{a} {c} {b}";
                    }
                    else
                    {
                        message = $"{c} {a} {b}";
                    }
                }
                else
                {
                    if (b > a)
                    {
                        message = $"{a} {b} {c}";
                    }
                    else
                    {
                        message = $"{b} {a} {c}";
                    }
                }
            }

            return message;
        }

        //Пользователь вводит 3 числа (A, B и С).
        //Выведите в консоль решение(значения X) квадратного уравнения стандартного вида, где AXX+BX+C=0.
        public void SolveTask4_2()
        {
            double a = GetDoubleNumberFromUser("Введите переменную A:");
            double b = GetDoubleNumberFromUser("Введите переменную B:");
            double c = GetDoubleNumberFromUser("Введите переменную C:");

            double[] result = SolveSquareEquation(a, b, c);

            Console.WriteLine($"Решение квадратного уравнения стандартного вида, где A * X * X + B * X + C = 0. : {result}");
        }

        public double[] SolveSquareEquation(double a, double b, double c)
        {
            double x1 = 0;
            double x2 = 0;
            double d = 0;

            d = b * b - 4 * a * c;

            if (d < 0)
            {
                throw new ArithmeticException($" Нет решения для уравнения, дескриминант = {d} меньше 0 ");
            }
            
            if (d == 0)
            {
                x1 = -b / (2 * a);
                
                return new double[] {x1};
            }
            else
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                
                return new double[] { x1, x2 };
            }
        }

        //Пользователь вводит двузначное число.
        //Выведите в консоль прописную запись этого числа.
        //Например при вводе “25” в консоль будет выведено “двадцать пять”.
        public void SolveTask5_2()
        {
            int a = GetIntNumberFromUser("Введите двухзначное число:");

            Console.WriteLine($"Результат пятой задачи: {ReturnTheAlphabeticDesignationOfANumber(a)}");
        }

        public string ReturnTheAlphabeticDesignationOfANumber(int a)
        {
            int des = 0, ed = 0;

            des = a / 10;
            ed = a % 10;

            if (a > 99 || a < 10)
            {
                throw new ArgumentOutOfRangeException ("Необходимо двухзначное число большее 10 и меньшее 99");
            }

            string message;
            if (a > 9 || a < 20)
            {
                message = a switch
                {
                    10 => "Десять",
                    11 => "Одинадцать",
                    12 => "Двенадцать",
                    13 => "Тринадцать",
                    14 => "Четырнадцать",
                    15 => "Пятнадцать",
                    16 => "Шестнадцать",
                    17 => "Семнадцать",
                    18 => "Восемндацать",
                    19 => "Девятнадцать",
                };
            }
            else
            {
                message = des switch
                {
                    2 => "Двадцать",
                    3 => "Тридцать",
                    4 => "Сорок",
                    5 => "Пятьдесят",
                    6 => "Шестьдесят",
                    7 => "Семь",
                    8 => "Восемьдесят",
                    9 => "Девяносто",
                };

                message += ed switch
                {
                    0 => "",
                    1 => " Один",
                    2 => " Два",
                    3 => " Три",
                    4 => " Четыре",
                    5 => " Пять",
                    6 => " Шесть",
                    7 => " Семь",
                    8 => " Восемь",
                    9 => " Девять",
                };
            }

            return message;
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
    }
}
