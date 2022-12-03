// Напишите программу, которая 
// 1. принимает на вход пятизначное число и 
// 2. проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите пятизначное число: ");
        string number = Console.ReadLine();

        void CheckingNumber(string number)
        {
            if (number[0] == number[4] || number[1] == number[3])
            {
                Console.WriteLine($"Число: {number} - является палиндромом.");
            }
            else Console.WriteLine($"Число: {number} - НЕ является палиндромом.");
        }

        if (number!.Length == 5)
        {
            CheckingNumber(number);
        }
        else Console.WriteLine($"Ошибка ввода данных");
    }
}