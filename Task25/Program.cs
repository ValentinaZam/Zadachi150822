// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Нужно ввести два числа");
Console.WriteLine("Введите первое число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральную степень B, в которую вы хотите возвести число A: ");
int b = Convert.ToInt32(Console.ReadLine());
if (b > 0)
{
    int degree = 2;
    int i = a;
        while (degree <= b)
        {
            i = i*a;
            degree++;
        }
        Console.WriteLine($"{b}-я cтепень числа {a} -> {i}");
}
else Console.WriteLine("Введено НЕ натуральное число. Введите число от 1 или более!");
