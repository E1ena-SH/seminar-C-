// ==== Задача 54: 
// Задайте двумерный массив. Напишите программу, которая упорядочит по 
// убыванию элементы каждой строки двумерного массива.
// Например, задан массив:  1 4 7 2
//                          5 9 2 3
//                          8 4 2 4
// В итоге получается вот такой массив: 7 4 2 1
//                                      9 5 3 2
//                                      8 4 4 2

// int rows = new Random().Next(3,7);
// int columns = new Random().Next(3,7);
// int[,] matrix = new int[rows, columns];
// CreateArray (matrix);
// WriteArray (matrix);

// void OrderArrayLines(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(1) - 1; k++)
//             {
//                 if  (matrix[i, k] > matrix[i, k + 1])
//                 {
//                     int temp = matrix[i, k + 1];
//                     matrix[i, k + 1] = matrix[i, k];
//                     matrix[i, k] = temp;
//                 }
//             }
//         }
//     }
// }

// void CreateArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(10);
//         }
//     }
// }

// void WriteArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i,j] + " ");
//         }
//     Console.WriteLine();
//     }
// }
// Console.WriteLine("Упорядоченный массив: ");
// OrderArrayLines(matrix);
// WriteArray(matrix);


// ==== Задача 56: 
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив: 1 4 7 2
//                         5 9 2 3
//                         8 4 2 4
//                         5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка

// int [,] GetMatrix (int rows, int columns, int min, int max)
// {
//     int [,] array = new int [rows,columns];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(min,max);
//             Console.Write(array[i,j]+"\t");
//         }
//         Console.WriteLine();
//     }
//     return array;
// }

// int [,] newArray = GetMatrix(3,6,0,9);

// int minRow = int.MaxValue;
// int minIndex = 0;
// for (int i = 0; i < newArray.GetLength(0); i++)
// {
//     int sumRow = 0;
//     for (int j = 0; j < newArray.GetLength(1); j++)
//     {
//         sumRow = sumRow + newArray[i,j];
//     }
//     Console.WriteLine($"Сумма строки {i+1} равна {sumRow}");
//     if(sumRow < minRow) 
//     {
//         minRow = sumRow;
//         minIndex = i;
//     } 
// }
// Console.WriteLine($"Минимальная сумма в строке {minIndex+1}");

// ==== Задача 58: 
// Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.
    // Например, даны 2 матрицы:    2 4 | 3 4
    //                              3 2 | 3 3
// Результирующая матрица будет:    18 20
//                                  15 18

// int[,] GetMatrix(int rows, int columns, int min, int max)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(min, max);
//             Console.Write(array[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
//     return array;
// }

// Console.WriteLine("Матрица A:");
// int[,] matrixA = GetMatrix(4, 3, 1, 5);
// Console.WriteLine("Матрица B:");
// int[,] matrixB = GetMatrix(3, 4, 1, 5);
// Console.WriteLine("Матрица C:");

// if (matrixA.GetLength(1) == matrixB.GetLength(0))
// {
//     int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
//     for (int i = 0; i < matrixC.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrixC.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrixB.GetLength(0); k++)
//             {
//                 matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
//             }
//             Console.Write(matrixC[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }
// else Console.WriteLine("Произведение матриц невозможно,т.к. количество столбцов Матрицы А не равно количеству строк Матрицы B.");

// ==== Задача 60. 
// ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[] array2D = new int[90];
// for (int i = 0; i < array2D.Length; i++)
// {
//     array2D[i] = 10 + i;
// }
// for (int i = 0; i < array2D.Length; i++)
// {
//     int j = new Random().Next(array2D.Length);
//     int temp = array2D[j];
//     array2D[j] = array2D[i];
//     array2D[i] = temp;
// }

// int [,,] GetMatrix (int tables, int rows, int columns, int min, int max)
// {
//     int m = 0;
//     int [,,] array = new int [tables,rows,columns];
//     for (int k = 0; k < array.GetLength(0); k++)
//     {
//         for (int i = 0; i < array.GetLength(1); i++)
//         {
//             for (int j = 0; j < array.GetLength(2); j++)
//             {
//                 array[k,i,j] = array2D[m];
//                 Console.Write($"{array[k,i,j]} ({k},{i},{j})  ");
//                 m++;
//             }
//             Console.WriteLine();
//         }
//     }
//     return array;
// }

// int [,,] array3D = GetMatrix(2,2,2,10,100);

// ==== Задача 62. 
// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:    01 02 03 04
//                                                     12 13 14 05
//                                                     11 16 15 06
//                                                     10 09 08 07

int[,] sqareMatrix = new int[4, 4];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
    sqareMatrix[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
        j--;
    else
        i--;
}
WriteArray(sqareMatrix);

void WriteArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] / 10 <= 0) Console.Write("0" + $"{array[i,j]} ");
            else Console.Write($"{array[i,j]} ");
        }
    Console.WriteLine();
    }
}