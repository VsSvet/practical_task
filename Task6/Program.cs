﻿Console.Clear();
Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine());

if(A%2 == 0)
{
    Console.WriteLine($"Число {A} четное");
}
else
{
    Console.WriteLine($"Число {A} нечетное");
}