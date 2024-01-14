// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет

int[] arr = { 1, 3, 4, 19, 3, -4, -8, 15 };
int a = int.Parse(Console.ReadLine()!);
bool b = false;

for (int i = 0; i < arr.Length; i++)
{
    if (a == arr[i])
    {
        b = true;
        break;
    }
}
if (b)
{
    Console.Write("Yes");
}
else
{
    Console.Write("No");
}
