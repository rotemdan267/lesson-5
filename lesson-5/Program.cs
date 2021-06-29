using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Random

            //Random rnd = new Random();
            //int[] arr = new int[100];
            //for (int i = 0; i < 100; i++)
            //{
            //    arr[i] = rnd.Next(10);
            //}
            //int num = rnd.Next(0, 10); // מספר רנדומלי בין 0-9
            //Console.WriteLine(num);

            //num = rnd.Next(10); // מספר רנדומלי בין 0-9 
            //Console.WriteLine(num);

            #endregion

            //PrintDate();

            #region Ex.1

            //for (int i = 0; i < 10; i++)
            //{
            //    string str = Console.ReadLine();
            //    Print(str);
            //}

            #endregion

            #region Ex.2

            //int[] arr = new int[3] { 1, 2, 3 };
            //LoopArr(arr);

            #endregion

            #region Ex.3

            //Console.WriteLine("Enter first number:");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second number:");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("What action would you like to do? '+' '-' '*' '/'");
            //string operation = Console.ReadLine();
            //Console.WriteLine("How many times would you like to repeat the action?");
            //int numOfActions = int.Parse(Console.ReadLine());

            //double result = Calculate(num1, num2, operation, numOfActions);

            //Console.WriteLine(result);

            #endregion


        }
        public static void PrintDate()
        {
            Console.WriteLine(DateTime.Now); // מדפיסה את התאריך והשעה נכון לרגע ההפעלה
            Console.WriteLine(DateTime.Now);
        }

        public static void Print(string str)
        {
            Console.WriteLine(str);
        }

        public static void LoopArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                PrintInt(arr[i] * 2);
            }
        }

        public static void PrintInt(int num)
        {
            Console.WriteLine(num);
        }

        public static double Calculate(double num1, double num2, string operation, int numOfActions)
        {
            double result = 0, finalResult = 0;
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("You can't divide by 0");
                    }
                    break;
            }
            finalResult = result;

            for (int i = 0; i < numOfActions -1; i++)
            {
                switch (operation)
                {
                    case "+":
                        finalResult += result;
                        break;

                    case "-":
                        finalResult -= result;
                        break;

                    case "*":
                        finalResult *= result;
                        break;

                    case "/":
                        if (result != 0)
                        {
                            finalResult /= result;

                        }
                        else
                        {
                            Console.WriteLine("You can't divide by 0");
                        }
                        break;
                }

            }
            return finalResult;
        }
    }
}
