// Задача 4. Найти максимальное из трех чисел

int number1 = new Random().Next(1,100);
int number2 = new Random().Next(1,100);
int number3 = new Random().Next(1,100);

Console.Write("число 1: ");
Console.WriteLine(number1);
Console.Write("число 2: ");
Console.WriteLine(number2);
Console.Write("число 3: ");
Console.WriteLine(number3);

int max = number1;

if (number2 > max) max = number2;
if (number3 > max) max = number3;

Console.Write("Макисмальное число: ");
Console.WriteLine(max);