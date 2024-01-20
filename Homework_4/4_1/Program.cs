// Напишите программу, которая бесконечно запрашивает целые числа с консоли.
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.



internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Введите целое число или Q, чтобы завершить программу: ");
            string UserInput = Console.ReadLine()!;
            int number;

            if (UserInput == "q")
            {
                break;
            }
            if (int.TryParse(UserInput, out number))
            {
                int sum = 0;
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                if (sum % 2 == 0)
                {
                    Console.WriteLine("[STOP]");
                    break;
                }
            }
        }
    }
}