﻿/*
Задача 3: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

Console.Write("Введите число > ");
int numb = Convert.ToInt32(Console.ReadLine());

if (numb % 2 == 0)
{
    Console.WriteLine($"Число {numb} - чётное");
}
else
{
    Console.WriteLine($"Число {numb} - нечётное");
}