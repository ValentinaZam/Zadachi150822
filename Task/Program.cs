// Напишите программу, которая принимает на вход координаты точки (Х и Y), 
// причем Х и Y не равно нулю, и выдает номер четверти плоскости

Console.WriteLine("Введите координаты точки: ");
Console.Write("Х: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
  Console.WriteLine("Первая четверть");
 else if (x > 0 && y < 0)
   Console.WriteLine("Вторая четверть");
 else if (x < 0 && y < 0)
   Console.WriteLine("Третья четверть");
 else if (x < 0 && y > 0)
   Console.WriteLine("Четвёртая четверть");
else Console.WriteLine("Введены некорректные координаты");


