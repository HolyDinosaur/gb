using System;
class Program{
        static void Main()
{
Console.Write("Введите значение: ");
string str = Console.ReadLine();
string str2 = "";
for(int i = str.Length-1;i>=0;i--){
	str2+=str[i];
	}
        if (str==str2){
		Console.WriteLine("Введенная строка является палиндромом.");
		}
	else {
		Console.WriteLine("Введенная строка не является палиндромом.");
		
	}
}}
