// Задача 10. Удалить вторую цифру трёхзначного числа

int number = new Random().Next(100, 1000);

Console.Write("Случайное трёхзначное число: ");
Console.WriteLine(number);

int num1 = number / 100;
int num2 = (number % 100 - number % 10) / 10;
int num3 = number - num1 * 100 - num2 * 10;

Console.Write("Удаляем вторую цифру числа и получаем: ");
Console.Write(num1);
Console.Write(num3);