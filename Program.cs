﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number >= 100 && number <= 999);
int S = (number%100)/10;
Console.WriteLine("Вторая цифра данного числа: " + S);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

if (number1 >= 100 && number1 <= 999)
{
    int A = number1%10;
    Console.WriteLine("Третья цифра данного числа: " + A);
}

if (number1 < 100)
{
    Console.WriteLine("третьей цифры нет");
}