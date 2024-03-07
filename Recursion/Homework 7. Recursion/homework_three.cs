using System;
class Program{
        static void Main()
{
int [] array = {1, 2, 5, 0, 10, 34};
int size = array.Length;

void Reversal(int [] array, int size){
	if(size == 0){
		return;
	}
	Console.Write($"{array[size - 1]}" + " ");
	Reversal(array, size - 1);
}
Reversal(array, size);
Console.Write("\n");
}}
