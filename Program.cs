using System;

namespace Homework2_0
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Задача 2");

            System.Console.Write("a = ");
            int a = int.Parse (Console.ReadLine ());
            System.Console.Write("b = ");
            int b = int.Parse (Console.ReadLine());

            if (a != b) 
            {
                a++ ; b++;
                System.Console.WriteLine($"a = {a}; b = {b}");
            }
            else if (a == b) 
            {
                a = 0; b = 0;
                System.Console.WriteLine($"a = {a}; b = {b}");
            }
            else 
            {
                System.Console.WriteLine("That is all");
            }




            // System.Console.WriteLine("Задача 3");
           
            // Console.Write("operand1 = ");
            // double operand1 = double.Parse (Console.ReadLine());
            // Console.Write("operand2 = ");
            // double operand2 = double.Parse (Console.ReadLine());
            // Console.Write("Введите арифметическую операцию :");
            // string sign = Console.ReadLine();
           
            // switch (sign)
            // {
            //     case "+":
            //         Console.WriteLine($"result = {operand1 + operand2}");
            //         break;
            //     case "-":
            //         Console.WriteLine($"result = {operand1 - operand2}");
            //         break;
            //     case "*":
            //         Console.WriteLine($"result = {operand1 * operand2}");
            //         break;
            //     case "/":
            //         if (operand2 == 0)
            //         {
            //             System.Console.WriteLine("Error division. Бесконечность не предел)))");
            //         }
            //         else 
            //         {
            //             Console.WriteLine($"result = {operand1 / operand2}");
            //         }
            //         break;
            //     default:
            //         Console.WriteLine("Введите другое значение");
            //         break;
            // }
            // Проверка деления на ноль.



            // Console.WriteLine ("Задача 4");
            // Console.Write ("a = ");
            // int a = int.Parse (Console.ReadLine());
            // if (a >= 0 && a <= 14) 
            // {
            //     Console.WriteLine ($"число в промежутке 0 - 14");
            // }
            // else if (a >= 15 && a <= 35) 
            // {
            //     Console.WriteLine ($"число в промежутке 15 - 35");
            // }
            // else if (a >= 36 && a <= 50) 
            // {
            //     Console.WriteLine ($"число в промежутке 36 - 50");
            // }
            // else if (a >= 50 && a <= 100) 
            // {
            //     Console.WriteLine ($"число в промежутке 50 - 100");
            // }
            // else 
            // {
            //     Console.WriteLine("Введено неверное значение!");
            // }
        }
    }
}
