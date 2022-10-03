// ==== Задайте двумерный массив размером m x n, заполненный случйаными числами
// Console.WriteLine("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()); //  int.Parse = Convert.ToInt32
// Console.WriteLine("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine());

// int[,] matrix = new int [rows,columns]; // создание массива двумерного

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = new Random().Next(0,13); // присвоение случайных чисел массиву
//         Console.Write(matrix[i,j]+ "\t"); // "\t" - литерал (команда) выравнивает массив
//     }
//     Console.WriteLine(); // 
// }


// ==== Задайте в двумерный массив размера m x n, каждый элемент в массиве находится по формуле:  Amn = m+n. 
// Выведите полученный массив на экран

// Console.WriteLine("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()); //  int.Parse = Convert.ToInt32
// Console.WriteLine("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine());

// int[,] matrix = new int [rows,columns]; // создание массива двумерного

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = i+j; 
//         Console.Write(matrix[i,j]+ "\t"); // "\t" - литерал (команда) выравнивает массив
//     }
//     Console.WriteLine(); // 
// }

// ==== Задача 49
// Задайте двумерный массив. Найдите элементы, у которых оба индекса четные,
//  и замените эти элементы на их квадраты

// double [,] matrix = new double [4,6]; // создание массива двумерного

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = new Random().Next(0,10); 
//         Console.Write(matrix[i,j]+ "\t"); // "\t" - литерал (команда) выравнивает массив
//     }
//     Console.WriteLine(); // 
// }
// Console.WriteLine();

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         if (i % 2 == 0 && j % 2 == 0) matrix[i,j] = Math.Pow(matrix[i,j], 2);
//         Console.Write(matrix[i,j]+ "\t"); // "\t" - литерал (команда) выравнивает массив
//     }
//     Console.WriteLine(); // 
// }

// ==== Задача 51 
// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали ( с индексами (0,0), (1,1) и т.д.)

Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()); //  int.Parse = Convert.ToInt32
Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());

int[,] matrix = new int [rows,columns]; // создание массива двумерного
int sum = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(0,10);
        Console.Write(matrix[i,j]+ "\t"); // "\t" - литерал (команда) выравнивает массив
        if (i == j) sum += matrix[i,j];
    }
    Console.WriteLine(); // 
}
Console.WriteLine();
Console.WriteLine(sum);
