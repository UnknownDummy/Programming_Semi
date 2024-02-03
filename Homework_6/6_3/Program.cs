// Задайте произвольную строку. Выясните,
// является ли она палиндромом.

using System;

class Program
{
    static void PalindromeChk(string strInput)
    {
        for (int i = 0; i < strInput.Length/2; i++)
        {
            if (strInput[i] != strInput[strInput.Length - 1 - i])
            {
                Console.Write($"Строка {strInput} не является палиндромом.");
                return;
            }
        
        }
        Console.Write($"Строка {strInput} является палиндромом.");
        return;
    }

    static void Main()
    {
        Console.Write("Введите произвольную строку: ");
        string strUsrInput = Console.ReadLine()!;
        Console.WriteLine("Проверка на палиндромность...");
        PalindromeChk(strUsrInput);
    }
}