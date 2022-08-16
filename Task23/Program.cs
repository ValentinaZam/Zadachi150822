// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите целое, положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int MultiplNumber(int number)
{
    int multipl = 1;
    for (int i = 1; i <= number; i++)
    {
        multipl = i*i*i;
    }
    return multipl;
}

int result = MultiplNumber(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {result}");