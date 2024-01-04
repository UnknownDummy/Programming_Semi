// Задача 4: Напишите программу, которая на вход принимает 
// натуральное число N, а на выходе показывает его цифры через запятую. 12345

Console.WriteLine("Enter number");
int Number = int.Parse(string)(Console.ReadLine()!);
int i = 0;

while (Number > 0 )
{
    i = Number % 10;
    Number = Number / 10;
    Console.Write(i + " ");
}