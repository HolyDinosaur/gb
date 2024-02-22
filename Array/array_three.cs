using System;
class Program{
        static void Main()
{
int [] array = new int [] {1, 3, 2, 4, 2, 3};
int [] array_two = new int[array.Length / 2];
for(int i = 0; i < array.Length / 2; i++){
	array_two[i] = array[i] * array[array.Length - (1 + i)];
	Console.Write(array_two[i] + " ");

}

}}
