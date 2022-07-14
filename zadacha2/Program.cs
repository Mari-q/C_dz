// Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
Console.WriteLine("Введите A = ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите B = ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите C = ");
int C = Convert.ToInt32(Console.ReadLine());
int max;
 max = A;
 if (B > max)max=B;
if (C > max)max=C;
 Console.WriteLine($"max = {max}");