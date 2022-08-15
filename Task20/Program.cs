// Задача 20:
// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 2D пространстве
// А(3,6); В(2,1) -> 5,09
// А(7,-5); В(1,-1) -> 7,21

// РАССТОЯНИЕ МЕЖДУ ТОЧКАМИ
// Расстояние между точками А1(х1, y1) и А2(х2, y2) на плоскости с заданными координатами выражается формулой:

Console.WriteLine("Введите координату Х для первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y для первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Х для второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y для второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1));
Console.WriteLine(Math.Round(result,2));