// Задача 9. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int number = new Random().Next(10, 100);

Console.Write("Случайное число из отрезка [10, 100]: ");
Console.WriteLine(number);

int firstNum = number / 10;
int secondNum = number % 10;

Console.Write("Наибольшая цифра числа: ");
if (firstNum > secondNum)
{
    Console.WriteLine(firstNum);
}
else
{
    Console.WriteLine(secondNum);
}