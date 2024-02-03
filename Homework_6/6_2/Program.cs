// Задайте строку, содержащую латинские буквы
// в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные.

using System;

class Program
{
    static string lowerString(string strInput)
    {
        string strOutput = strInput.ToLower();
        return strOutput;    
    }

    static void Main()
    {
        Console.Write("Введите строку, содержащую латинские буквы в обоих регистрах: ");
        string strUsrInput = Console.ReadLine()!;
        Console.Write(lowerString(strUsrInput));
    }
}