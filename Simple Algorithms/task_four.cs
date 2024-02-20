using System;
class Program{
	static void Main()
		{
			Console.Write("Введите натуральное число N: ");
			int N = Convert.ToInt32(Console.ReadLine());
			if (N < 10)
				{
					Console.WriteLine(N);
					} else{
						while (N > 0){
							int current = N % 10; N /= 10;
							if (N > 0){
								Console.Write(current + ",");
								}
							else{ 
								Console.WriteLine(current);
								}
							}
						}
			}
	}
