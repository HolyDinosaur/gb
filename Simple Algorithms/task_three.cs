using System;
class Program{
	static void Main()
{
	Console.Write("Введите число от 10 по 99: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int first = num / 10;
        int second = num % 10;
        int max = first > second ? first : second; 
	Console.WriteLine(max); 
			}}
