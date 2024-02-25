using System;
class Program{
        static void Main()
{
Random rnd = new Random();
int n = rnd.Next(1, 10);
int size = 1000;
int[] arr = new int [size];
int = 0;
while(i < size){
	arr[i] = n;
	i++;
}

i = 0;
while(i < size){
	Console.Write($"{arr[i]} ");
	i++;
}
}
}
