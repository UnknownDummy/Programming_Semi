// Задайте двумерный массив символов (тип char [,]).
// Создать строку из символов этого массива. 

using System;

class Program
{
    static string ArrToStr(char[,] arr)
    {
        int row_size = arr.GetLength(0);
        int column_size = arr.GetLength(1);
        string strOutput = "";

        for (int i = 0; i < row_size; i++)
        {
            for (int j = 0; j < column_size; j++)
                strOutput += arr[i, j];
        }
        return strOutput;
    }

    static void Main()
    {
        char[,] charArr = {
            {'a', 'b', 'c'},
            {'d', 'e', 'f'}
        };
        Console.Write(ArrToStr(charArr));
    }
}