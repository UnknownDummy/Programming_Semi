// Задача 3: Напишите программу, которая принимает на вход 
// целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

Console.WriteLine("Enter number from 10 to 99");
int Number = int.Parse(Console.ReadLine()!);
int FirstNumber = (Number / 10);
int SecondNumber = (Number % 10);
int MaxNumber = 0;

if (10 <= Number & Number <= 99)
{
    if (FirstNumber > SecondNumber)
    {
        MaxNumber = FirstNumber;
    }

    else
    {
        MaxNumber = SecondNumber;
    }

    Console.WriteLine(MaxNumber);
}

else
{
    Console.WriteLine("Out of numbers range");
}