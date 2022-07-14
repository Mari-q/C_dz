// Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите number1 = ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите number2 = ");
int number2 = Convert.ToInt32(Console.ReadLine());
string result;
if(number1 > number2)
{
    result = $"{number1}";
    Console.WriteLine($"min = {number2}");
}
else
{
    result = $"{number2}";
    Console.WriteLine($"min = {number1}");
}

Console.WriteLine($"max = {result}");
