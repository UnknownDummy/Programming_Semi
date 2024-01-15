﻿// Задайте массив из вещественных чисел с ненулевой дробной частью.
// Найдите разницу между максимальным и минимальным элементов массива.

using System;
using System.Linq;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{ 
    // Разница между максимальным и минимальным элементами массива
    
    // Нахождение минимума массива
    public static double FindMin(double[] numbers)
    {
        double MinNumber = numbers[0];
        foreach (double number in numbers)
        {
            if (number < MinNumber)
            {
                MinNumber = number;
            }
        }
        return MinNumber;
        //Напишите свое решение здесь
    }
    
    // Нахождение максимума массива
    public static double FindMax(double[] numbers)
    {
        double MaxNumber = numbers[0];
        foreach (double number in numbers)
        {
            if (number > MaxNumber)
            {
                MaxNumber = number;
            }
        }
        return MaxNumber;
        //Напишите свое решение здесь
    }
    
    
    
    public static void PrintResult(double[] array)
    {
        Console.WriteLine(UserInputToCompileForTest.FindMax(array) - UserInputToCompileForTest.FindMin(array));
        //Напишите свое решение здесь
    }
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        double[] array;
        

        if (args.Length >= 1) {
            // Объединяем все аргументы командной строки в одну строку
            string joinedArgs = string.Join(" ", args);

            // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
            array = joinedArgs.Split(", ")
                                  .Select(double.Parse)
                                  .ToArray();
            
            // Теперь arr содержит преобразованные в целые числа из командной строки
        
        } else {
           // Если аргументов на входе нет
            array = new double[] {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01}; // Создание массива
        }
        UserInputToCompileForTest.PrintResult(array);
    }
}