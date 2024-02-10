// 1. Напишите программу, которая будет принимать на вход число
// и возвращать сумму его цифр. Использовать рекурсию.

int Recursion(int a)
{
    if (a == 0)
    {
        return 0;
    }
    return Recursion(a / 10) + a %  10;
}

Console.Write("Введите число для рекурсии:");
int output = int.Parse(Console.ReadLine()!);
Console.Write($"{Recursion(output)}");
