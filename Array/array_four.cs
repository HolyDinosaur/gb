using System;
class Program{
        static void Main()
{
int[] array = new int [] {1, 5, 10, 20, 30, 40, 99, 4, 90, 3, 2, 6};
int[] numbers = new int[array.Length];
int minRange = 10;
int maxRange = 90;
int count = 0;
for(int i = 0; i < array.Length; i++){
	numbers[i] = array[array.Length - (1 + i)];
        if(minRange <= numbers[i] && numbers[i] <= maxRange){
		count++;
	
	} 	
	} 	
Console.WriteLine(count);
}}
