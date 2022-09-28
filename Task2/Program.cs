// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Задача №66");
Console.WriteLine("----------------------------------------");

Console.Write("Введите начальное число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное число: ");
int N = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int start, int end)
{
    // Базовый случай
    if (start == end)
        return end;

    // Рекурсивный случай
    return (start + SumNumbers(start + 1, end));
}

Console.WriteLine($"Сумма чисел от {M} до {N} равна {SumNumbers(M, N)}");