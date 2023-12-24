// 4. Напишите программу, которая выводит третью с конца
// цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Enter number");
int a = int.Parse(Console.ReadLine()!);

if (a < 100)
{
    Console.WriteLine("There's no third number");
} 
else
{
    Console.WriteLine(a / 100 % 10);    
}