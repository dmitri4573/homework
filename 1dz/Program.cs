// Задайте значения M и N.
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.




void PrintNaturalNum(int m, int n)
{
    if (m <= n)
    {
        Console.Write(m + " ");
        PrintNaturalNum(m + 1, n);
    }
    
}

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

PrintNaturalNum(m, n);