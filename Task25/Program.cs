// Задача 25: Напишите цикл, который 
// 1. принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243
// 2, 4 -> 16

Console.Write("Введите A: ");
int a = int.Parse(Console.ReadLine()!); // 12345

Console.Write("Введите B: ");
int b = int.Parse(Console.ReadLine()!);
int multy = a;
for (int i = 1; i < b; i++)
    multy = multy * a;
Console.WriteLine($"Число {a} в степени {b} равно {multy}");