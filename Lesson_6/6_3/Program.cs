// 3. Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.

using System;

class Program
{
    private static int CountVowels(string input) // Метод для подсчета количества гласных букв в строке
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' }; // Создаем массив с гласными буквами

        int count = 0;
        for (int i = 0; i < input.Length; i++) // Проходим по каждому символу во введенной строке
        {
            if (Array.IndexOf(vowels, input[i]) != -1) // Если символ является гласной, увеличиваем счетчик
            {
                count++;
            }
        }
        return count;
    }

    static void Main()
    {
        Console.WriteLine("Введите строку из латинских букв в нижнем регистре:"); // Просим пользователя ввести строку
        string input = Console.ReadLine()!;

        int vowelCount = CountVowels(input);
 
        Console.WriteLine($"Количество гласных букв в строке: {vowelCount}"); // Выводим результат
    }
}