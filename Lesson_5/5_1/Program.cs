// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты. 

// void Print(int[,] arr)
// {
// int row_size = arr.GetLength(0);
// int column_size = arr.GetLength(1);
// 
// for (int i = 0; i < row_size; i++)
// {
// for (int j = 0; j < column_size; j++)
// Console.Write($" {arr[i, j]} ");
// Console.WriteLine();
// }
// Console.WriteLine();
// }
// 
// int[,] MassNums(int row, int column, int from, int to)
// {
// int[,] arr = new int[row, column];
// 
// for (int i = 0; i < row; i++)
// for (int j = 0; j < column; j++)
// arr[i, j] = new Random().Next(from, to);
// 
// return arr;
// }
// Console.Write("Enter the number of rows: ");
// int row_num = int.Parse(Console.ReadLine()!);
// Console.Write("Enter the number of columns: ");
// int column_num = int.Parse(Console.ReadLine()!);
// 
// Console.Write("Enter the min number of massive ");
// int start = int.Parse(Console.ReadLine()!);
// Console.Write("Enter the max number of massive ");
// int stop = int.Parse(Console.ReadLine()!);
// 
// int[,] mass = MassNums(row_num, column_num, start, stop);
// 
// Print(mass);

int[,] CreateMatrix(int rowCount, int columsCount) // Функция создания матрицы с элементами от 1 до 999
{
    int[,] matrix = new int[rowCount, columsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix) // Функция вывода матрицы на экран
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(3, 4); // Задание размера матрицы и инициализация "интересного" числа.
ShowMatrix(matrix);

void evenIndex(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i += 2)
    {
        for (int j = 0; j < array.GetLength(1); j += 2)
        {
            array[i, j] = array[i, j] * array[i, j];
        }
    }
}
evenIndex(matrix);
ShowMatrix(matrix);