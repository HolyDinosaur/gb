using System;
class Program{
        static void Main()
{
int SumOfDigits(int num){
if(num == 0){
	return 0;
}
int sum = num%10 + SumOfDigits(num/10);
return sum;
}

Console.Clear();
int num = 123;
int result = SumOfDigits(num);
Console.WriteLine(result);
}}
