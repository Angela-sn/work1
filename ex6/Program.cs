// Напишите программу, которая на вход принимает число и выдает, является ли число чётным (делится ли оно на 2 без остатка)
// Задача №6
// Запрос 1 число
Console.WriteLine("Проверяем является ли число чётным");
Console.Write("введите число: ");
int number = int.Parse(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine($" {number} -> да");
}
else
{
    Console.WriteLine($" {number} -> нет");
}