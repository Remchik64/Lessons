// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("какое из трех чисел имеет максимальное значение.");
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = int.Parse(Console.ReadLine());
int maxnum = 0;
if (num1 > maxnum) maxnum = num1;
if (num2 > maxnum) maxnum = num2;
if (num3 > maxnum) maxnum = num3;
Console.Write("Максимальное значение имеет число " + maxnum);