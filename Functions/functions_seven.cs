using System;
class Program{
        static void Main()
{
int [] CreateRandomArray(int min, int max, int size){
	int [] array = new int [size];
        for(int i = 0; i < size; i++){
		array[i] = new Random().Next(min, max+1);
	}
	return array;
}

void ShowArray(int [] array){
	foreach(int item in array){
		Console.Write(item + " ");
	}
}
Console.Write("Введите минимальное значание: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значание: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Размер: ");
int size = Convert.ToInt32(Console.ReadLine());

int [] array = CreateRandomArray(min, max, size);
ShowArray(array);
}
}
