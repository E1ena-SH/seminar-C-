// ЗАДАЧА 10. 
// Напишите программу, которая на вход принимает трехзначное число и на выходе показывает вторую цифру этого числа

// Console.WriteLine("Введите трехзначное число");
// int number = Convert.ToInt32(Console.ReadLine());

// int num1 = number / 10;
// int num2 = num1 % 10;

// Console.WriteLine(num2);


// ЗАДАЧА 13. 
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number / 100 > 0)
// {
//     Console.WriteLine(number%10);
// }

// else
// {
//     Console.WriteLine("Третьего числа нет");
// }

// ЗАДАЧА 15. 
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int weekend1 = 6;
int weekend2 = 7;
int[] week ={1,2,3,4,5};

if (number < 6 && number > 0)
{
    Console.WriteLine("Этот день НЕ является выходным");
}

else if (number == weekend1 || number == weekend2)
{
    Console.WriteLine("Этот день является выходным");
}

else
{
    Console.WriteLine("ОШИБКА");
}