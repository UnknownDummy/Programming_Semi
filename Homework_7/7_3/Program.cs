// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

void printReverseMass(int[] numbers, int i)
{
    if (i < 0) return;
    Console.Write(numbers[i] + " ");
    printReverseMass(numbers, i - 1);
}

int[] massNums = { 1, 2, 5, 0, 10, 34 };
int NumsLength = massNums.Length - 1;
printReverseMass(massNums, NumsLength);