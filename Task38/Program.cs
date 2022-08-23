// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

// double[] CreateArrayRndDbl(int size, double min, double max) 
// {    
//     double[] array = new double[size];
//     Random rnd = new Random();

//     for (int i = 0; i < size; i++) 
//     {
//         array[i] = rnd.NextDouble();
//     }
//     return array;
// } 

// void PrintArray(double[] array) 
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++) 
//     {
//         if (i < array.Length - 1) Console.Write($"{array[i]}, ");
//         else Console.Write(array[i]);
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }

// double[] arr = CreateArrayRndDbl(10, 1, 10);
// PrintArray(arr);

var rnd = new Random();
double[] arr = new double[5];

var i = 0;
for(i = 0; i < 5; i++)
{
    
    arr[i] = rnd.Next(100) + rnd.NextDouble();
    
    Console.Write(Math.Round (arr[i], 2) + " ");
}
