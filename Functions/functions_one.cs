using System;
class Program{
        static void Main()
{
double calcul(int a, int b, int c, int d){
	double numenator = a * b;
	int denomenator = c + d;
	double result = numenator / denomenator;
        return result;
}
double result = calcul(1, 2, 3, 4);
Console.WriteLine(result);
}}
