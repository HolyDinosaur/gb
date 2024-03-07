using System;
class Program{
        static void Main()
{
void FomAndTo(int n, int m){
	if (m == 0 || n == 0 || m == n){
		return;
	}
	FomAndTo(n, m - 1);
	Console.Write($"{m}" + " ");
}

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write(n + " ");
FomAndTo(n, m);
}}
