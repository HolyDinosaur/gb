using System;
class Program
{
static void Main(){
	int[] even = new int[10];
        int count = 0;
	for (int i = 0; i < even.Length; i++){
		even[i] = new Random().Next(10, 1000); 
                Console.Write(even[i] + " ");
		if (even[i] % 2 == 0){
			count++;
		}
	}
Console.WriteLine($"\n{count}");
}
}
