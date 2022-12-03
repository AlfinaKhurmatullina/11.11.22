// Напишите программу, которая 
// 1. выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// 2. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введи число: ");

int number = Convert.ToInt32(Console.ReadLine());

string numberText = Convert.ToString(number);

if (numberText.Length > 2)
{
  Console.WriteLine("третья цифра: " + numberText[2]);
}
else
{
  Console.WriteLine("Нет третьей цифры");
}