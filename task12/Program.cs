﻿// // Задача 12: Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


Console.WriteLine("Введите первое целое число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число, после чего мы узнаем кратно ли второе число первому или покажем остаток деления");
int num2 = Convert.ToInt32(Console.ReadLine());

int num3 = num1 % num2;

if (num3 != 0)
{
    Console.WriteLine($"{num3} -  делится с остатком остаток ");
}
Console.WriteLine((double)num1 / (double)num2);
