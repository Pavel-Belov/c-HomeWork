// Задача 8. Показать вторую цифру трёхзначного числа

Console.Write("Введите число: ");
string number = Console.ReadLine();
int intNum = Convert.ToInt32(number);

if (intNum < 100 || intNum > 999)
{
    Console.WriteLine("Число должно быть трёхзначным!");
}
else
{
    Console.Write("Вторая цифра данного числа: ");
    Console.WriteLine(number[1]);
}