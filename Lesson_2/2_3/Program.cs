// 3. Напишите программу, которая будет принимать на вход два
// числа и выводить, является ли второе число кратным первому.
// Если второе число некратно первому, то программа выводит
// остаток от деления.

Console.WriteLine("Enter Numbers");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);

if (a % b == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No " + a % b);
}