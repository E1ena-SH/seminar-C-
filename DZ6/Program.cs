// ==== Задача 41: 
// Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.Write("Введите числа через пробел ");
// int count = 0;
// int[] a = Array.ConvertAll < string, int >
// (
// Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries),
// x=> int.Parse(x)
// );
// // Console.ReadLine() считает строку
// // Split( ...) разобъет введенную строку на массив строк разбивая по пробелам и удаляя пустые
// // Array.Convert преобразует массив строк в массив целых

// for (int i=0; i<a.Length; i++)
// {
//    if (a[i] > 0) count++;
// }

// Console.WriteLine(count);

// ==== Задача 43:
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите число k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

if(k1==k2 && b1!=b2) Console.WriteLine("Прямые параллельны");
else if (k1==k2 && b1==b2) Console.WriteLine("Прямые совпадают");
else 
{
    double x = (b2-b1)/(k1-k2);
    double y = k1*x+b1;
    Console.WriteLine($"Точка пересечения: x={Math.Round(x,2)}; y={Math.Round(y,2)}."); // Math.Round - округление, в данном случае до 2х знаков;
}