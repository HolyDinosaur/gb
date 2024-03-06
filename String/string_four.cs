using System;
class Program{
        static void Main()
{
char [,] array = new char [,]{{'H','e','L'},{'L','o','$'},{'2','2','4'}};
string srt = "";
for(int i = 0; i < array.GetLength(0); i++){
	for(int j = 0; j < array.GetLength(1); j++){
	        srt += array[i,j];
		}
}
Console.WriteLine("Задача №1 " + srt);
Console.WriteLine("Задача №2 " + srt.ToLower());
}}
