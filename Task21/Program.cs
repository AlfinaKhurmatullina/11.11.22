// Напишите программу, которая 
// 1. принимает на вход координаты двух точек и 
// 2. находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите координаты точки А через пробел");
        string xyz = Console.ReadLine()!;
        string[] partsA = xyz.Split(' ');
        int xA = int.Parse(partsA[0]);
        int yA = int.Parse(partsA[1]);
        int zA = int.Parse(partsA[2]);

        Console.WriteLine("Введите координаты точки B через пробел");
        xyz = Console.ReadLine()!;
        string[] partsB = xyz.Split(' ');
        int xB = int.Parse(partsB[0]);
        int yB = int.Parse(partsB[1]);
        int zB = int.Parse(partsB[2]);

        double distsnce = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));

        Console.WriteLine($"Расстояние между точкой А и точкой B = {distsnce:F2}");
    }
}