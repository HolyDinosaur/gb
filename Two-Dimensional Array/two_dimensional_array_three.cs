using System;
class Program{
        static void Main(){
string GetCreatLettersFromString(string s){
	string letters = "";
	foreach(char e in s){
		if(char.IsAsciiLetter(e) == true){
			letters = letters + e;
		}
	}
	return letters;
}
string str = Console.ReadLine();
string result = GetCreatLettersFromString(str);
Console.WriteLine(result);
}}
