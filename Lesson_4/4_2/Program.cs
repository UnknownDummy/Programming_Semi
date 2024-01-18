﻿// / 2. Задайте массив из N случайных целых
// чисел (N вводится с клавиатуры).
// Найдите количество чисел, которые
// оканчиваются на 1 и делятся нацело на 7.

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to + 1);
    return arr;
}

static int CountEvenItems(int[] arr)
{
    int count = 0;
    foreach (int number in arr)
    {
        if (number % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Задайте желаемое количество чисел в массиве");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте минимальное число");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте максимальное число");
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);
Console.WriteLine(CountEvenItems(mass));

