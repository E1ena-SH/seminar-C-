// ==== Задача 47. 
// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// double [,] array = new double [rows, columns];

// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j ++)
//     {
//         array[i,j] = array[i,j] = new Random().Next(-100,101)/10.0;
//         Console.Write (Math.Round(array [i,j],1) +"\t");
//     }
//     Console.WriteLine();
// }

// ==== Задача 50. 
// Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:     1 4 7 2
//                             5 9 2 3
//                             8 4 2 4
// 17 -> такого числа в массиве нет

// int [,] array = new int [10,10];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = new Random().Next(-100,101);
//         Console.Write(array[i,j] +"\t");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Введите номер строки: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите номер столбца: ");
// int column = Convert.ToInt32(Console.ReadLine());

// if(row<=array.GetLength(0) && column<=array.GetLength(1))
//     Console.WriteLine($"Искомый элемент: {array[row-1,column-1]}.");
// else
//     Console.WriteLine("Такого элемента не существует.");

// ==== Задача 52. 
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив: 1 4 7 2
//                         5 9 2 3
//                         8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] array = new int [10,10];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(1,11);
        Console.Write(array[i,j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("Среднее арифметическое: ");

for (int j = 0; j < array.GetLength(1); j++)
{
    double average = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        average = average + array[i,j];
    }
    Console.Write(Math.Round(average/array.GetLength(0),2) + "\t");
}