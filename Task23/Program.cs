﻿// Напишите программу, которая 
// 1. принимает на вход число (N) и 
// 2. выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите число: ");

        int number = Convert.ToInt32(Console.ReadLine());


        for (int i = 1; i <= number; i++)

            Console.Write($"{Math.Pow(i, 3)}. ");
    }
}