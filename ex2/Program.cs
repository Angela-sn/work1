// Задача№2
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число больше, а какое меньше

// Запрос 1 и 2 числа
Console.WriteLine("Проверяем какое число больше, а какое меньше");

Console.Write("введите первое число: ");
int A = int.Parse(Console.ReadLine());

Console.Write("введите второе число: ");
int B = int.Parse(Console.ReadLine());

// Проверка на условие
 
 if (A < B)
 {
    Console.WriteLine($" a = {A}, b = {B} -> max= {B}");
    Console.WriteLine($" a = {A}, b = {B} -> min= {A}");
    // a = 5, b = 7 -> max=7
 }
 else
 {
    Console.WriteLine($"a = {A}, b = {B} -> max= {A}");
    Console.WriteLine($"a = {A}, b = {B} -> min= {B}");
 }
