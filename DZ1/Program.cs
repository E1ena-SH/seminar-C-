// // Напишите программу,  которая на вход принимает  два числа и выдаёт, какое число большее, а какое меньшее

// Console.WriteLine("Введите число 1");
// int number1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число 2");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if(number1>number2)

// {
//     Console.Write("max = ");
//     Console.WriteLine(number1);

//     Console.Write("min = ");
//     Console.WriteLine(number2);
// }

// else
// {
//     Console.Write("max = ");
//     Console.WriteLine(number2);
//     Console.Write("min = ");
//     Console.WriteLine(number1);
// }

// ЗАДАЧА 4
// Напишите программу,  которая на вход принимает  три числа и выдаёт максимальное из этих чисел
// Console.WriteLine("Введите число 1");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 2");

// int number2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число 3");

// int number3 = Convert.ToInt32(Console.ReadLine());

// int max = number1;

// if (max < number2)
// {
//     max = number2;
// }

// if (max < number3)
// {
//     max = number3;
// }

// Console.Write("max = ");
// Console.WriteLine(max);


// ЗАДАЧА 6
// Напишите программу,  которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на 2 без остатка)
// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());

// if(number % 2 == 0)
// {
//     Console.WriteLine("Число чётное");
// }
// else
// {
//     Console.WriteLine("Число НЕ является чётным");
// }


// ЗАДАЧА 8
// Напишите программу,  которая на вход принимает число (N), а на входе показывает все четные числа от 1 до N
Console.Clear();
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int i = 2;

while(i <= number)
{
    Console.WriteLine(i); 
    i += 2; 
}