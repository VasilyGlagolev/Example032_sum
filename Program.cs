// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число M: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите число N: ");
        int n = int.Parse(Console.ReadLine());

        int sum = GetSum(m, n);
        Console.WriteLine($"Сумма чисел от {m} до {n} равна {sum}");
    }

    static int GetSum(int m, int n)
    {
        if (m > n)
            return 0;

        return m + GetSum(m + 1, n);
    }
}
