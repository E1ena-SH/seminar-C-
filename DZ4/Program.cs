// ==== Задача 25
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите число ");
// double num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите степень числа ");
// double num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// Console.WriteLine($"{num1} в степени {num2} =  {Pow(num1, num2)}");

// double Pow(double num1, double num2)
// {
//     double result = Math.Pow(num1, num2);
//     return result;
// }

// ==== Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// **** способ 1
// Console.WriteLine("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// Console.WriteLine($"Сумма цифр в числе {num} = {SumNumbers(num)}");

// int SumNumbers(int num)
// {
//     int sum = 0;

//     while (num > 0)
//     {
//         sum += num % 10;
//         num /= 10;
//     }
//     return (sum);
// }

// **** способ 2
// Console.WriteLine("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// string resalt = Convert.ToString(num);
// int size = resalt.Length;
// int sum =0;

// Console.WriteLine();

// Console.WriteLine($"Сумма цифр в числе {num} = {SumNumbers(num)}");
// int SumNumbers(int num)
// {
// for (int i = 0; i < size; i++)
// { 
//     sum += (int)char.GetNumericValue(resalt[i]);   // ДОП конвертация для корректного рассчета
// }

// return (sum);
// }


// ==== Задача 29
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



void MakeArray(int[] array) //создание массива
{
        int length = array.Length;

    for(int i =0; i < length; i++)
    {
        array[i] = new Random().Next(1,1000);
    }
}


void PrintArray(int[] print) // вывод массива на печать
{
    int length = print.Length;
    for(int i = 0; i < length; i++)
    {
         Console.Write($"{print[i]} ");
    }
    Console.WriteLine();
}

int[] NewArray = new int[8]; // массив, который применяется в методах
MakeArray(NewArray); // вывод метода 
PrintArray(NewArray);// вывод метода 
