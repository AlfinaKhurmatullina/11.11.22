// Напишите программу, которая 
// 1. принимает на вход три числа и 
// 2. выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.WriteLine("Введие три целых числа: ");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());


if (a > b)
{
    if (a > c)
    {
        Console.WriteLine("Максимальное число: " + a);
    }
    else
    {
        Console.WriteLine("Максимальное число: " + c);
    }
}
else if (b > c)
{
    Console.WriteLine("Максимальное число: " + b);
}
else
{
    Console.WriteLine("Максимальное число: " + c);

}