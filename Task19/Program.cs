﻿// Задача 19

// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите положительное пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n <= 99999)
{
  if (n > 0)
{
    if (n % 10 == n / 10000 && n % 100 / 10 == n / 1000 %10)
        Console.WriteLine("Число является палиндромом");
    else Console.WriteLine("Число НЕ палиндром");
}
  else Console.WriteLine("Число должно быть положительным!");
}
else Console.WriteLine("Число не пятизначное!");