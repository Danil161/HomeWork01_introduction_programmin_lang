﻿//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Write("Введите первое число = ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число = ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число = ");
int n3 = Convert.ToInt32(Console.ReadLine());

if (n1 == n2 && n2 == n3)
{
    Console.WriteLine("Все числа равны!");
}
else
    if (n1 < n3 && n2 < n3)
{
    Console.WriteLine($"Третье число больше остальных: {n3}");
}
else
    if (n1 > n2)
{
    Console.WriteLine($"Первое число больше остальных: {n1}");
}
else
{
    Console.WriteLine($"Второе число больше остальных: {n2}");
}