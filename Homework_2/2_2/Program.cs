// Задача 2: Напишите программу, которая принимает на вход 
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер координатной четверти плоскости, в которой находится эта точка.

Console.WriteLine("Enter coordinates for X");
int X = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter coordinates for Y");
int Y = int.Parse(Console.ReadLine()!);

if (X > 0)
{
    if (Y > 0)
    {
        Console.WriteLine("1 quarter");
    }
    
    else
    {
        Console.WriteLine("4 quarter");
    }
}

else
{
    if (Y > 0)   
    {
        Console.WriteLine("2 quarter");
    }
    
    else
    {
        Console.WriteLine("3 quarter");
    }
}