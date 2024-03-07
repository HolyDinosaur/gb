using System;
class Program{
        static void Main()
{
void GetSum(int N){
	if(N == 0){
		return;
	}
	GetSum(N - 1);
	Console.Write(N + " ");

}
GetSum(5);
}}
