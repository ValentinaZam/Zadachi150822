// Задача 27: Напишите программу, 
// которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

 Console.WriteLine("Введите целое число: ");
 int num = Convert.ToInt32(Console.ReadLine());
 

    int i = num;
    int x = 0;
   
     while (i != 0)
    {
        x = x + (i % 10);
        i =  i / 10;
    }
    Console.WriteLine($"{x}");
 
