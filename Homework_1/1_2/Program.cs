﻿// Внутри класса Answer напишите метод FindMax, 
// который принимает на вход три числа и выдаёт максимальное из этих чисел.

using System;

public class Answer 
{
  static int FindMax(int a, int b, int c)
    {
      // Введите свое решение ниже
        int result = 0;
        if (a > b )
            if (a > c){
            result = a;}
        if (b > a )
            if (b > c){
            result = b;}
        if (c > a)
            if (c > b){
                result = c;}
        return result;
    }   
    
    

  // Не удаляйте и не меняйте метод Main! 
  static public void Main(string[] args) {
        int a, b, c;

        if (args.Length >= 3) {
           a = int.Parse(args[0]);
           b = int.Parse(args[1]);
           c = int.Parse(args[2]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           a = 5;
           b = 6;
           c = 7;
        }

        // Не удаляйте строки ниже
        int result = FindMax(a, b, c);
        System.Console.WriteLine($"{result}");
    }
}