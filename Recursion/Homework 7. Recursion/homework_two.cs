using System;
class Program{
        static void Main()
{
int Akkerman(int n, int m)
{
  if (n == 0){
	  return m + 1;
  }
  else if (m == 0){
	  return Akkerman(n - 1, 1);
  }
  else {
	  return Akkerman(n - 1, Akkerman(n, m - 1));


  }
}

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

//Проверка на неотрицательныe числа
if (n < 0 || m < 0){
	if(n < 0){
		Console.Write("Введите нетрицательное число N: " + "\n");
	}
	else {
		Console.Write("Введите нетрицательное число M: " + "\n");
	}
} else {
	Console.Write(Akkerman(n, m) + "\n");
}
}}
