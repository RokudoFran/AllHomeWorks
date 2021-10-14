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
            
            string result = FindingASolutionByCondition(a, b);
            
            Console.WriteLine($"{result}");
        }

        public string FindingASolutionByCondition(double a, double b)
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

            string result = SearchQuarterX(x, y);

            Console.WriteLine($"{result}");
        }

        public string SearchQuarterX(double x, double y)
        {
            string message = "";

            if ( x == 0 )
            {
                message = SearchQuarterY(y, x, 0);
            }
            else if ( x > 0 )
            {
                message = SearchQuarterY(y, x, 1);
            }
            else
            {
                message = SearchQuarterY(y, x, 2);
            }

            return message;
        }

        public string SearchQuarterY(double y, double x, int answer)
        {
            string message = "";
            if (y == 0)
            {
                message = answer switch
                {
                    0 => $"Точка с координатами( { x } : { y} ), лежит на начальной точке оси координат",
                    1 => $"Точка с координатами ( {x} : {y} ), лежит на правой части оси X",
                    2 => $"Точка с координатами ( {x} : {y} ), лежит на левой части оси X",
                };

            }
            else if (y > 0)
            {
                message = answer switch
                {
                    0 => $"Точка с координатами ( {x} : {y} ), лежит на верхней части оси Y",
                    1 => $"Точка с координатами ( {x} : {y} ), лежит на I четверти оси координат",
                    2 => $"Точка с координатами ( {x} : {y} ), лежит на II четверти оси координат",
                };
            }
            else
            {
                message = answer switch
                {
                    0 => $"Точка с координатами ( {x} : {y} ), лежит на нижней части оси Y",
                    1 => $"Точка с координатами ( {x} : {y} ), лежит на IV четверти оси координат",
                    2 => $"Точка с координатами ( {x} : {y} ), лежит на III четверти оси координат",
                };
            }

            return message;
        }

        //Пользователь вводит 3 числа(A, B и С).
        //Выведите их в консоль в порядке возрастания.
        public void SolveTask3_2()
        {
            double a = GetDoubleNumberFromUser("Введите переменную A:");
            double b = GetDoubleNumberFromUser("Введите переменную B:");
            double c = GetDoubleNumberFromUser("Введите переменную C:");

            string result =SortedAscending(a, b, c);

            Console.WriteLine($"Результат третьей задачи: {result}");
        }

        public string SortedAscending(double a, double b, double c)
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

            double[] result = SolvingEquations(a, b, c);

            Console.WriteLine($"Решение квадратного уравнения стандартного вида, где A * X * X + B * X + C = 0. : {result}");
        }

        public double[] SolvingEquations(double a, double b, double c)
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
                x1 = -b / 2 * a;
                
                return new double[] {x1};
            }
            else
            {
                x1 = (-b + Math.Sqrt(d)) / 2 * a;
                x2 = (-b - Math.Sqrt(d)) / 2 * a;
                
                return new double[] { x1, x2 };
            }
        }

        //Пользователь вводит двузначное число.
        //Выведите в консоль прописную запись этого числа.
        //Например при вводе “25” в консоль будет выведено “двадцать пять”.
        public void SolveTask5_2()
        {
            int a = GetIntNumberFromUser("Введите двухзначное число:");

            string result = TransformationIntByString(a);

            Console.WriteLine($"Результат пятой задачи: {result}");
        }

        public string TransformationIntByString(int a)
        {
            string message = "";

            int des = 0, ed = 0;

            des = a / 10;
            ed = a % 10;

            if (a > 99 || a < 10)
            {
                throw new ArgumentOutOfRangeException ("Необходимо двухзначное число большее 10 и меньшее 99");
            }

                if ( a > 9 || a < 20)
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
                        20 => "Двадцать",
                        30 => "Тридцать",
                        40 => "Сорок",
                        50 => "Пятьдесят",
                        60 => "Шестьдесят",
                        70 => "Семь",
                        80 => "Восемьдесят",
                        90 => "Девяносто",
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
