// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.

void Recursion(int MinNumber, int MaxNumber)
{
    if (MaxNumber >= MinNumber)
    {
        Recursion(MinNumber, MaxNumber - 1);
        Console.Write($"{MaxNumber} ");
    }
}

Console.Write("Введите начальное число для рекурсии: ");
int inputMin = int.Parse(Console.ReadLine()!);
Console.Write("Введите конечное число для рекурсии: ");
int inputMax = int.Parse(Console.ReadLine()!);
Recursion(inputMin, inputMax);