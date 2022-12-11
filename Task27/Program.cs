﻿//  Напишите программу, которая 
//  1. принимает на вход число и 
//  2. выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите число ");

        int number = Convert.ToInt32(Console.ReadLine()!);

        int sum(int number)

        {
            int count = Convert.ToString(number).Length;
            int a = 0;
            int result = 0;

            for (int i = 0; i < count; i++)
            {
                a = number - number % 10;
                result = result + (number - a);
                number = number / 10;
            }
            return result;
        }

        int sumNumber = sum(number);
        Console.WriteLine("Сумма цифр в числе: " + sumNumber);
    }
}