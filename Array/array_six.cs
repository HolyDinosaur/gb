using System;
class Program{
        static void Main()
{
int [] array = {1, 2, 3, 5, 6, 7, 8, 9, 6, 3};

for(int i = 0; i < array.Length; i++){
	if(array[i] % 2 == 0){
		Console.Write(array[i] + " ");	
	}
}
}}	
