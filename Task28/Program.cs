// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите целое, положительное число");
int number = Convert.ToInt32(Console.ReadLine());

int MultiplNumber(int number)
{
    int multipl = 1;
    for (int i = 1; i <= number; i++)
    {
        multipl *= i;
    }
    return multipl;
}

int result = MultiplNumber(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {result}");