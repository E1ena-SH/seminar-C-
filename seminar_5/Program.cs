// ==== Задача 31 Задайте массив из 12 элементов,
// заполненный случайными числами из промежутка [-9;9]
// Найдите сумму отрицательных и положительных элементов массива.

// int[] array = new int[12];
// int size = array.Length;
// int positiveSum = 0;
// int negativeSum = 0;

// for(int i = 0; i<size; i++)
// {
//     array[i]=new Random().Next(-9,10);
    
//     if (array[i]>0) positiveSum += array[i];
//     else negativeSum += array[i];
// }

// Console.WriteLine("Сумма положительных чисел = "+ positiveSum);
// Console.WriteLine("Сумма отрицательных чисел = "+ negativeSum);

// Console.WriteLine(String.Join("; ", array)); // ВЫВОД ВСЕГО массива (трокой) на консоль с указанием знака разделения

// ==== Задача 37
// Найдите произведение пар чисел в одномерном массиве
// Парой считаем элемент второй и предпоследний и т.д.
// Результат напишите в новом массиве
// [1 2 3 4 5] => 5 8 3
// [6 7 3 6] => 36 21

// int [] inputArray = {1, 2, 3, 4, 5};
// int index = inputArray.Length;

// int [] resultArray = new int[index/2+index%2];

// for(int i = 0; i < resultArray.Length; i++)
// {
//     resultArray[i] = inputArray[i]*inputArray[index - 1 - i];
//     if (i==inputArray.Length-1-i)
//     {
//         resultArray[i] = inputArray[i];
//     }
// }

// Console.WriteLine(String.Join(", ", resultArray));


// ==== Задача 32
// Напишите программу элементов массива:
// положительные элементы замените на соответствующие отрицательные,
// и наоборот
// [-4 -8 8 2] => 4 8 8 2

// int [] array = {1, 2, -3, 4, -5};
// int size = array.Length;

// int [] resultArray = new int[size]; // а можно и без создания второго массива, просто умножить первый на -1 

// for(int i = 0; i < size; i++)
// {
//     resultArray[i] = array[i]*(-1);
// }

// Console.WriteLine("[{0}]", String.Join(", ", resultArray)); //  вывод  в квадратных скобках

// ==== Задача 32
// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
// 4; массив [6 7 19 345 3] - нет


Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int [] array = {6, 7, 19, 345, 3};
string result = "No";

for(int i = 0; i<array.Length; i++)
{
    if(array[i] == num) result = "Yes";
}
Console.WriteLine(result);