// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void StrRevrs(string strInput)
    {
        string[] TempArray = strInput.Split(' '); // создаём рабочий массив и вводим разделитель
        Array.Reverse(TempArray); // разворачиваем массив с помощью метода Reverse
        string reverse = string.Join(" ", TempArray); // выводим в результат в строку
        Console.Write($"{reverse}"); // выводим итог на экран
    }

    static void Main()
    {
        Console.Write("Введите строку, разделённую пробелами: ");
        string strUsrInput = Console.ReadLine()!;
        StrRevrs(strUsrInput);
    }
}