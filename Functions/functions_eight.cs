using System;
class Program{
        static void Main()
{
while(true){
	Console.Write("Ввод: ");
	string text = Console.ReadLine();
	if (text == "q"){
		Console.WriteLine("STOP");
		break;
	} else {
		int number = int.Parse(text);
	        if (number % 2 == 0){
		Console.WriteLine("STOP");
                break;
	}
		else{
		Console.WriteLine("YES, Введите q или целое число: ");
		}
	}
}
}
}
