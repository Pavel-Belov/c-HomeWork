// Задача 5. Выяснить является ли число чётным

int number = new Random().Next(1, 100);

Console.Write("Число ");
Console.Write(number);

if (number % 2 == 0)
{
    Console.WriteLine(" является чётным.");
}
else
{
    Console.WriteLine(" не является чётным.");
}