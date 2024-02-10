// 2. Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N при помощи рекурсии.

void Recursion(int a)
{
    if (a != 0)
    {
        Recursion(a - 1);
        Console.Write($"{a} ");
    }
}

Console.Write("Введите число для рекурсии:");
int output = int.Parse(Console.ReadLine()!);
Recursion(output);
