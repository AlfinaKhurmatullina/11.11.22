// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArray(int length)
{
    double[] numbers = new double[length];
    for (int n = 0; n < numbers.Length; n++)
    {
        numbers[n] = Math.Round((new Random().NextDouble()*100), 2);
        Console.Write(numbers[n] + " ");
    }
    Console.WriteLine();
    return numbers;
}

Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
double[] array = CreateArray(length);

double FindMax(double[] array02)
{
    double max = array[0];
    for (int i = 0; i < array02.Length; i++)
    {
        if (array02[i] > max) max = array02[i];
    }
    Console.WriteLine(max);
    return max;
}

double FindMin(double[] array01)
{
    double min = array01[0];
    for (int i = 0; i < array01.Length; i++)
    {
        if (array01[i] < min) min = array01[i];
    }
    Console.WriteLine(min);
    return min;
}

double dif = FindMax(array) - FindMin(array);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {dif}");