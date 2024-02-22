using System;
class Program{
        static void Main()
{
int num = 8;
int [] array = new int [] {2,4,6,8,9};
bool flag = false;
foreach(int item in array){
	if(item == num){
		flag = true;
	}
}
if(flag){
	Console.Write("Да");
}
else{
	Console.Write("Нет");
}
}}
