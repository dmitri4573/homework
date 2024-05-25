//  Напишите программу вычисления функции Аккермана с помощью рекурсии.
//   Даны два неотрицательных числа m и n.

int AckermanFun(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return AckermanFun(m - 1, 1);
    }
    else
    {
        return AckermanFun(m - 1, AckermanFun(m, n - 1));
    }
}

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = AckermanFun(m, n);
Console.WriteLine($"Значение Аккермана ({m}, {n}) : {result}");
AckermanFun(m,n);

