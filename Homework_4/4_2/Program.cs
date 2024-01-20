// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

internal class Program
{
    private static void Main(string[] args)
    {
        void Print(int[] arr)
        {
            int size = arr.Length;

            for (int i = 0; i < size; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }

        int[] MassNums(int size, int from, int to)
        {
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
                arr[i] = new Random().Next(from, to + 1);
            return arr;
        }

        static int CountEvenItems(int[] arr)
        {
            int count = 0;
            foreach (int number in arr)
            {
                if (number % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }

        Console.WriteLine("Задайте желаемое количество чисел в массиве");
        int num = int.Parse(Console.ReadLine()!);
        int start = 100;
        int stop = 999;

        int[] mass = MassNums(num, start, stop);
        Print(mass);
        Console.WriteLine($"Количество чётный чисел в массиве: " + CountEvenItems(mass));
    }
}