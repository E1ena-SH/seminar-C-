// ==== Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// if (num > 9999 && num < 100000)
// {
//     int M = num % 10*10000+num/10%10*1000+num/100%10*100+num/1000%10*10+num/10000%10;
//     if (num == M)    Console.WriteLine($"{M} Палиандром");
//     else Console.WriteLine($"{M} Не является палиандромом");
// }
// else 
// {
//     Console.WriteLine("ОШИБКА");
// }



// ==== Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите х1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите х2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double AB = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2)+Math.Pow(z2-z1, 2));
// Console.WriteLine(AB);


// ==== Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
for(int i = 1; i <= num; i++)
{
    Console.WriteLine(Math.Pow(i,3));
}