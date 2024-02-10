// 3. Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.
//
// Использовать рекурсию. Не использовать цикл

string str1 = "aeyiou";

void printCons(string str, int i = 0)
{
    if (i == str.Length) return;
    if (str1.Contains(char.ToLower(str[i])) == false)
    Console.Write(str[i] + " ");
    printCons(str, i + 1);
}

Console.Write("Введите строку для рекурсии:");
string str2 = Console.ReadLine()!;
printCons(str2);
