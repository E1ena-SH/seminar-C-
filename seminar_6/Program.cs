//  ==== зАДАЧА 39 
// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте,
// а первый на последнем и т.д.)
// [1 2 3 4 5] => [5 4 3 2 1]

// int [] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int [size];

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue,maxValue+1); // так как второе число не входит в промежуток добавляем 1
//     }
//     return res;
// }

// void ReversArray(int[] inArray)
// {
//     for(int i=0; i<inArray.Length/2; i++)
//     {
//         int k = inArray[i];
//         inArray[i]= inArray[inArray.Length-1-i];
//         inArray[inArray.Length-1-i] = k;
//     }
// }

// int[]array=GetArray(10,0,10);
// Console.WriteLine(String.Join(",", array));
// ReversArray(array);
// Console.WriteLine(String.Join(",", array));


//==== Задача 40
// Напишите программу, которая принимает на вход три числа и проверяет
// может ли существовать треугольник со сторонами такой длины
// (теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон)

// Console.WriteLine("ВВЕДИТЕ СТОРОНЫ ТРЕУГОЛЬНИКА");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// int num3 = Convert.ToInt32(Console.ReadLine());

// void Get(int a, int b, int c)
// {
//     if (a<b+c && b<a+c && c<a+b) Console.WriteLine("yes");
//     else Console.WriteLine("no");
// }

// Get(num1,num2, num3);


//==== Задача 41
// Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное
// 45 => 101101   3=> 11  2 => 10

// ******** способ 1
// Console.WriteLine("ВВЕДИТЕ ЧИСЛО");
// int num = Convert.ToInt32(Console.ReadLine());

// // int res =0;
// // while (num!=0);
// // {
//     string binary = Convert.ToString(num, 2);
//     // int res = num%2+num;
//     // int num = num/2;
// // }
// Console.WriteLine(binary);


// ******** способ 2
// void Convert1(int num)
// {
//     string resalt = "";
//     while(num>0)
//     {
//         resalt = num%2 + resalt; // т.к. это string то аргументы не складываются, а прописываются рядом
//         num/=2;
//     }
//     Console.WriteLine(resalt);
// }
// int intput = Convert.ToInt32(Console.ReadLine());
// Convert1(intput);

//  Задача

Console.WriteLine("ВВЕДИТЕ ЧИСЛО");
int num = Convert.ToInt32(Console.ReadLine());

int firstN = 1;
int secondN = 1;

for(int i = 3; i <= num; i++)
{
    int newN = firstN+secondN;
    Console.Write(newN+",");
    firstN = secondN;
    secondN = newN;
}