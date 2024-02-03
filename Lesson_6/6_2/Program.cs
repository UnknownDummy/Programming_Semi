// 2. На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.

// Метод строки ToCharArray() не использовать.

char[] strToCharArray(string str)
{
    int strLength = str.Length;
    char[] arr = new char [strLength];

    for (int i = 0; i < strLength; i++)
    {
        arr[i] = str[i];
    }
    return arr;
}

string str1 = Console.ReadLine()!;
char[] arr1 = strToCharArray(str1);
Console.WriteLine(arr1);
foreach (var item in arr1)
{
    Console.Write(item + " ");
}