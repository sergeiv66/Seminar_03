//Напишите программу, которая принимает на вход пятизначное число и
// проверяет, является ли оно палиндромом.

//14212 -> нет
//12821 -> да
//23432 -> да

//Console.WriteLine("Введите пятизначное число");
//string number = Convert.ToString(Console.ReadLine());

//if ((number[0] == number[4]) && (number[1]==number[3])) Console.WriteLine("yes");
//else Console.WriteLine("no");


//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и
//находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

//Console.WriteLine("Введите координату первой точки");
//int x1 = Convert.ToInt32(Console.ReadLine());
//int y1 = Convert.ToInt32(Console.ReadLine());
//int z1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Введите координату второй точки");
//int x2 = Convert.ToInt32(Console.ReadLine());
//int y2 = Convert.ToInt32(Console.ReadLine());
//int z2 = Convert.ToInt32(Console.ReadLine());

//double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

//Console.WriteLine(Math.Round(d, 2)); //Console.WriteLine($"d={d:f2}");


//Задача 23
//Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N; i++) 
{
    Console.WriteLine($"Куб числа {i} = {Math.Pow(i, 3)}");
}