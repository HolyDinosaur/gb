using System;
class Program{
        static void Main()
{
int size = 10;
int[] arr = new int[size];
int i = 0;
while(i < size){
	Console.Write("Введите элемент массива(целое число): ");
	string input = Console.ReadLine();
	arr[i] = Convert.ToInt32(input);
	i++;
}
}
}
