﻿// Задача 2. По двум заданным числам проверять является ли первое квадратом второго

Console.WriteLine("По двум заданным числам проверяем, является ли первое квадратом второго");
Console.Write("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 * number1 == number2)
{
    Console.Write("Число 1 является квадратом числа 2.");
}
else
{
    Console.Write("Число 1 не является квадратом числа 2.");
}