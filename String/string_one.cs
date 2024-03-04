using System;
class Program{
        static void Main()
{
string srt = "hello";
char [] array = new char[srt.Length];
for(int i = 0; i < srt.Length; i++){
	array[i] = srt[i];
}
foreach(char e in array){
	Console.Write(e);
}
}}
