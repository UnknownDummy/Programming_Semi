// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n.

int Ackermann(int n, int m)
{
    if (n < 0 || m < 0) return 0;
    if (n == 0) return m + 1;
    if (m == 0) return Ackermann(n - 1, 1);
    return Ackermann(n - 1, Ackermann(n, m - 1));
}

Console.WriteLine("Вычисления функции Аккермана (m, n)");
Console.Write("Введите первое число для вычисления: ");
int firstNum = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число для вычисления: ");
int secondNum = int.Parse(Console.ReadLine()!);
Console.WriteLine(Ackermann(secondNum, firstNum));
 