// Задача 18. Напишите программу, которая по заданному 
// номеру четверти показывает диапозон возможных координат 
// точек в этой четверти ( X и Y)

Console.WriteLine("Введите номер четверти: ");

int quarter = Convert.ToInt32(Console.ReadLine());

string GetQuarter (int a)
{
if (a == 1) return "X > 0, Y > 0";
if (a == 2) return "X < 0, Y > 0";
if (a == 3) return "X < 0, Y < 0";
if (a == 4) return "X > 0, Y < 0";
return "Данные введены не корректно";
}
string result = GetQuarter(quarter);
Console.WriteLine(result);