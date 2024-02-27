using System;
class Program{
        static void Main(){
Random rnd = new Random();
int [,] CreateMatrix(int rowCount, int columesCount){
        int [,] matrix = new int [rowCount, columesCount];
        for(int i = 0; i < matrix.GetLength(0); i++){
                for(int j = 0; j < matrix.GetLength(1); j++){
                        matrix[i,j] = rnd.Next(1, 1000);
        }
        }
        return matrix;
}
void PrintMatrix(int [,] matrix){
        for(int i = 0; i < matrix.GetLength(0); i++){
                for(int j = 0; j < matrix.GetLength(1); j++){
                        Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
}
}
int [,] matrix = CreateMatrix(3, 4);
PrintMatrix(matrix);

foreach(int c in matrix){
	if(intstrasten(c) == true){
		Console.WriteLine(c);
	}
}
bool intstrasten(int value){
	int sumOfDigits = GetsumOfDigits(value);
	if(sumOfDigits % 2 == 0){
		return true;
	}
	return false;
}
int GetsumOfDigits(int value){
	int sum = 0;
	while(value > 0){
		sum = sum + value % 10;
		value = value / 10;
	}
	return sum;
}
}}
