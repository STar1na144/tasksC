﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= n; i++)
{
if (i % 2 == 0) Console.Write(i + ", ");
}