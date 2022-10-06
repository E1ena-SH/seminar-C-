// ==== Задача 64: 
// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

// string NuturalNumbers (int start, int end)
// {
//     if (start<=end) return $"{start} " + NuturalNumbers(start+1,end);
//     else return string.Empty;
// }
// Console.WriteLine(NuturalNumbers(1,8));

// ==== Задача 66: 
// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int GetSum (int start, int end)
// {
//     if (start > end) return 0;
//     else return start + GetSum(start+1,end); 
// }
// Console.WriteLine(GetSum(2,8));

// ==== Задача 68: 
// Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ackermann (int m, int n)
{
    if (m==0) return n+1;
    if (n==0) return Ackermann(m-1,1);
    else return Ackermann(m-1, Ackermann(m,n-1));
}
Console.WriteLine(Ackermann(2,3));