using System;
class Program{
        static void Main()
{
Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int raz = 1;
int variable = number;

while (variable != 0){
	variable = variable / 10;
	raz *= 1;
}

while (raz > 1){
	variable =  number / 10;
	if (raz > 1) {
		Console.Write(variable + ", ");
                number = number % raz;
    } else {
	    Console.Write(variable);
    }
}
}
}
