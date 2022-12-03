//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1


Console.Clear();
Console.WriteLine("введите трехзначное число: ");
int number = int.Parse(Console.ReadLine ());
int xnumber = (number % 100); xnumber /=10 ;
Console.WriteLine(xnumber);

if((number < 99) || (number > 999))
{
    Console.WriteLine($"введенное вами число не является трёхзначным!");
}