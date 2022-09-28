// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29

Console.WriteLine("Задача №68");
Console.WriteLine("----------------------------------------");

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int FunctionAkkermana(int m, int n)
{
    if (m < 0 || n < 0)
        return 0;
    if (m == 0)
        // Базовый случай
        return n + 1;
    // Рекурсивный случай
    else if ((m > 0) && (n == 0))
        return FunctionAkkermana(m - 1, 1);
    else
        return FunctionAkkermana(m - 1, FunctionAkkermana(m, n - 1));
}

Console.WriteLine($"Функция Аккермана для чисел {m} и {n} равна {FunctionAkkermana(m, n)}");