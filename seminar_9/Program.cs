// ==== Задайте значение N. Программа выводит все натуральные числа в промежутке от 1 до N: N = 5 -> "1, 2, 3, 4, 5".

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());  
// int start = 1;
// if (num<start) Console.WriteLine("Введено неверное число");

// string NumRange (int numStart,int numEnd)
// {
//     if(numStart<=numEnd) 
//     return $"{numStart} "+ NumRange(numStart+1,numEnd);
//     else return string.Empty;
// }
// Console.WriteLine(NumRange(start,num));


// ==== Задайте значения M и N. Программа выводит все натуральные числа в промежутке от M до N: M = 1; N = 5 -> "1, 2, 3, 4, 5".

// Console.WriteLine("Введите число M: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число N: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// // Первый вариант (только для М<=N):

// string NumRange (int number1,int number2)
// {
//     if(number1<=number2) return $"{number1} "+ NumRange(number1+1,number2);
//     else return string.Empty;
// }
// Console.WriteLine(NumRange(num1,num2));


// Второй вариант (для любых чисел):
// string NumRange(int a, int b)
// {
//     if (a == b) return Convert.ToString(a);
//     if (a > b) return a + " " + NumRange(a - 1, b);
//     else return a + " " + NumRange(a + 1, b);
// }
// Console.Write(NumRange(num1,num2));


// ==== Программа принимает на вход число и возвращать сумму его цифр. 453 -> 12.

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int SumNumber(int n)
// {
//     if(n == 0) return 0;
//     return (n % 10 + SumNumber(n/10));
// }
// Console.WriteLine(SumNumber(number));



// ==== Программа принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии: A = 3; B = 5 -> 243 (3⁵).

int PowerNumber (int a, int b)
{
    if (b==0) return 1;
    return a * PowerNumber (a,b-1);
}
Console.WriteLine(PowerNumber(2,3));