// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ackerman(int num01, int num02)
{
    if (num01 == 0) return num02 + 1;
    else if (num02 == 0) return Ackerman(num01 - 1, 1);
    else return Ackerman(num01 - 1, Ackerman(num01, num02 - 1));
}
int num = Ackerman(2, 3);
Console.WriteLine(num);