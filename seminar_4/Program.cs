// // ==== Задача 24
// Напишите программу, которая принимает на вход 
// число (А) и выдает сумму чисел от 1 до А. 
// 7 => 28 4 =>10

// Console.WriteLine("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Сумма = " + GetSum(num));

// int GetSum(int number)
// {
//     int sum = 0;
//     int count = 0;
    
//     while (number > count)
//     {
//         count++;
//         sum+=count;
//     }
//     return sum;
// }


// // ==== Задача 25
// Напишите программу, которая принимает на вход 
// число и выдает количество цифер в числе. 
// 7 => 1 4345 => 4

// // СПОСОБ 1
// Console.WriteLine("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// string result = Convert.ToString(num); // конвертация числа в строку (для подсчета длины числа)
// Console.WriteLine("количесвто цифер в числе = " + SizeNum(num));

// int SizeNum (int num)
// {
//     int size = result.Length;
//     return size;
// }

// // СПОСОБ 2
// Console.WriteLine("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("количесвто цифер в числе = "+ GetCount(num));

// int GetCount(int number)
// {
//     int count = 0;
//     while (number>0)
//     {
//         count++;
//         number/=10; // a/=b это деление с присваиванием, является сокращенной записью a = a/b.
//     }
//     return count; // return  выводит сколько раз сработал наш цикл
// }


// // ==== Задача 26
// Напишите программу, которая принимает на вход 
// число N и выдает произведение чисел от 1 до N. 
// 4 => 24 5 => 120

//  ******* СПОСОБ 1
// Console.WriteLine("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("произведение чисел = "+ GetCount(num)); //здесь мы передаем заданное число (введеное пользователем) в функцию)

// int GetCount(int number)
// {
//     int count = 0;
//     int result = 1;
//     while (number > count)
//     {
//         count++;
//         result*=count;
//     }
//     return result; 
// }

//  ******* СПОСОБ 2
// Console.WriteLine("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());

// int GetCount(int number)
// {
//     int result = 1;
//     for (int i = 1; i<=number; i++)
//     {
//         result*=i;
//     }
//     return result; 
// }

// Console.WriteLine("произведение чисел = "+ GetCount(num)); //здесь мы передаем заданное число (введеное пользователем) в функцию)