// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)internal class Program
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

        int[] MassNums(int size)
        {
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
                arr[i] = i + 1;
            return arr;
        }

        int[] ReverseMass(int[] arr)
        {
            int temp = 0;
            for(int i = 0; i < arr.Length / 2; i++)
            {
                temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
            return arr;
        }

        Console.WriteLine("Задайте желаемое количество чисел в массиве");
        int num = int.Parse(Console.ReadLine()!);

        int[] mass = MassNums(num);
        Print(mass);
        Print(ReverseMass(mass));
    }
}