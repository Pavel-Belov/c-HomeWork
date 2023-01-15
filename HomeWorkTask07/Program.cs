// Показать последнюю цифру трёхзначного числа

Console.Write("Введите число: ");
string number = Console.ReadLine();
int intNum = Convert.ToInt32(number);

if (intNum < 100 || intNum > 999)
{
    Console.WriteLine("Число должно быть трёхзначным!");
}
else
{
    Console.Write("Последняя цифра данного числа: ");
    Console.WriteLine(number[number.Length - 1]);
}