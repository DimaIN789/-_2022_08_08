// Задача 16: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет


Console.WriteLine("Введите первое целое число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Является ли одно число квадратом другого?");

int num3 = num1 / num2;
int num4 = num2 / num1;

if (num3 == num2 || num4 == num1)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}

