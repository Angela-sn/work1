// Задача№4
// Напишите программу, которая на вход принимает три числа и выдаёт максимальное из этих чисел

// Запрос 1, 2, 3 числа
Console.WriteLine("Проверяем какое максимальное число");
Console.Write("введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("введите второе число: ");
int num3 = int.Parse(Console.ReadLine());
 int max; 
 if (num1 >= num2)
 {
    if (num3 >= num1)
    {
       max = num3;
       Console.WriteLine($" {num1}, {num2}, {num3} -> max= {num3}");
    }
    else
    {
       max = num1;
       Console.WriteLine($" {num1}, {num2}, {num3} -> max= {num1}");
    }
 }
 else
 {
    if (num3 >= num2)
    {
       max = num3;
       Console.WriteLine($" {num1}, {num2}, {num3} -> max= {num3}");
    }
    else
    {
       max = num2;
       Console.WriteLine($" {num1}, {num2}, {num3} -> max= {num2}");
    }
 }   


    

 

