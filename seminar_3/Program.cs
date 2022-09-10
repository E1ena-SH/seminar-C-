// int testNumber = 5643;
// // переводим в переменную "bool", т.е. ответ будет "правда" или "ложь"
// // можно применять равенства [>=], [<=], [==]
// Console.WriteLine(testNumber == 45); 

// == ЗАДАЧА 17 ==
// Напишите программу, которая принимает 
// на вход координаты точки (X и Y), причем X не= 0 и Y не= 0
// и выдает номер четверти плоскости, в которой находится эта точка

// Console.WriteLine("Введите х: ");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// if(x>0 && y>0) Console.WriteLine("1");
// if(x>0 && y<0) Console.WriteLine("4");
// if(x<0 && y<0) Console.WriteLine("3");
// if(x>0 && y>0) Console.WriteLine("2");
// if(x==0 || y==0) Console.WriteLine("Определить нельзя");

// == ЗАДАЧА 18 ==
// Напишите программу, которая по заданному номеру 
// четверти, показывает диапазон возможных
// координат точек в этой четверти (x и y)

// Console.WriteLine("Введите номер четверти ");
// int result = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine();
// if(result == 1) Console.WriteLine("x (0;∞) y (0;∞)");
// if(result == 2) Console.WriteLine("x (0;∞) y (∞;0)");
// if(result == 3) Console.WriteLine("x (∞;0) y (∞;0)");
// if(result == 4) Console.WriteLine("x (∞;0) y (0;∞)");
// if(result>4 || result<1) Console.WriteLine("ОШИБКА");


// == ЗАДАЧА 19 ==
// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между ними в 2D 
// пространстве А(3,6) B(2,1) => 5,09

// Console.WriteLine("Введите х1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите х2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// // ***** Можно каждое действие расчитывать по отдельности:
// double ab1 = Math.Pow(x2-x1, 2);
// double ab2 = Math.Pow(y2-y1, 2);
// double AB = Math.Sqrt(ab1+ab2);

// // ***** Можно расчитывать полное выражение:
// double AB = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2));
// Console.WriteLine(AB);


// == ЗАДАЧА 22 ==
// Напишите программу, которая принимает на вход
// число N и выдает таблицу квадратов
// чисел от 1 до N. 5  => 1, 4, 9, 16, 25

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
for(int i = 1; i <= N; i++)
{
    Console.WriteLine(Math.Pow(i,2));
}
