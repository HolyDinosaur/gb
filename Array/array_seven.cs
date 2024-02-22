using System;
class Program{
        static void Main()
{
int[] array = {2, 5, 2, 3, 6, 3, 7, 8, 2, 4, 4, 6, 8, 9};
int[] numbers = new int [array.Length];
int count = 0;
for(int i = 0; i < array.Length; i++){
	numbers[i] = array[array.Length - (1 + i)];
        if(numbers[i] %2 == 0){
		count++;
  }
 }
Console.WriteLine(count);
}}	
