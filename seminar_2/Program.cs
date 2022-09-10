// Задача 9
// Напишите программму, которая выводит случайное число из отрезка [10, 99]и показывает наибольшую цифру числа (786 -> 8)

// int num = new Random().Next(10, 100); // берет рандомные числа от начального до "конечного -1", т.е. [10, 99)
// int num1 = num/10;
// int num2 = num%10;
// int max = num1;

// if (max < num2)
// {
//     max =num2;
// }
// Console.WriteLine(num);
// Console.WriteLine(max);


// Задача 10
// Напишите программму, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа (798 -> 78)

// int num = new Random().Next(100, 1000); // берет рандомные числа от начального до "конечного -1", т.е. [10, 99)
// int num1 = num/100;
// int num3 = num%10;

// Console.WriteLine(num);
// Console.Write(num1);
// Console.WriteLine(num3);
// //Console.WriteLine(num1*10+num3); либо так в качестве цельного числа

// Задача 11
// Напишите программму, которая принимает 2 числа и выводит кратное ли второе число первому, если нет, то показывает остаток

// int num1 = new Random().Next(1, 1000);
// int num2 = new Random().Next(1, 1000);
// int result = num1 % num2;
// Console.WriteLine(num1);
// Console.WriteLine(num2);

// if(result == 0)
// {
//     Console.WriteLine("Число кратно");
// }
// else
// {
//     Console.WriteLine("Число НЕ кратно, остаток от деления: "+ result);
// }

// Задача 11
// Напишите программму, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int result1 = num % 7;
// int result2 = num % 23;

// if(result1 == 0 && result2 ==0)
// {
//     Console.WriteLine("Yes");
// }
// else{
//     Console.WriteLine("No");
// }

// Задача 12
// Напишите программу,которая принимает на вход два числа и проверяет, является ли одно число квадратом другого

// Console.WriteLine("Введите число1");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число2");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1*num1 == num2 || num2*num2 == num1)
// {
//     Console.WriteLine("Является");
// }
// else
// {
//     Console.WriteLine("НЕ является");
// }

string a ="bla";
string b = "la-la"; 

// Канкатинация
// Console.WriteLine(a +" "+ b); // Для облегчения записи кода

Console.WriteLine($"Число {a} является квадратом {b}"); // Интерполяция
