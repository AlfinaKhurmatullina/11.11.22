// Напишите программу, которая 
// 1. задаёт массив из 8 элементов и 
// 2. выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.WriteLine("Введите массив чисел: ");
int[] array = new int[8];
int len = array.Length;
int index = 0;
while (index < len)
{
    array[index] = int.Parse(Console.ReadLine());
    index++;
}
for (int i = 0; i < len; i++)
{
    Console.Write(array[i]);
}
Console.Write(Convert.ToInt32('1'));

