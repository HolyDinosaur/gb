using System;
class Program{
        static void Main()
{
void ShowLetters (string s){
	if(s.Length == 0){
		return;
	}
	string vovels = "aeoyiu";
	if (char.IsLetter(s[0]) && !vovels.Contains(char.ToLower(s[0]))){
		Console.Write($"{s[0]} ");
	}
	ShowLetters(s.Substring(1));

}
ShowLetters("Hello World!");
}}
