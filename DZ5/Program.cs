// ==== Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] array = new int[10];
// int size = array.Length;
// int count = 0;

// for(int i = 0; i<size; i++)
// {
//     array[i]=new Random().Next(100,1000);
    
//     if (array[i]%2 == 0) count++;
// }

// Console.WriteLine(String.Join(", ", array));
// Console.WriteLine("Количество четных чисел = " + count);

// Задача 36
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] array = new int[10];
// int size = array.Length;
// int sum = 0;

// for(int i = 0; i<size; i++)
// {
//     array[i]=new Random().Next(-10,10);

//     if (i % 2 == 1) sum =sum + array[i];
// }

// Console.WriteLine(String.Join(", ", array));
// Console.WriteLine("Сумма нечетных элементов = " + sum);

// Задача 38
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// int[] array = new int[10];
// int size = array.Length;
// int max = array[0];
// int min = array[0];

// for(int i = 0; i<size; i++)
// {
//     array[i]=new Random().Next(-10,10);
//     if(array[i]>max) max = array[i];
//     if(array[i]<min) min = array[i];
// }

// Console.WriteLine(String.Join(", ", array));
// Console.WriteLine($"max {max} - min {min} = {max - min}");