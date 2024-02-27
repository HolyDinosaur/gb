using System;
class Program{
        static void Main()
{
Random rnd = new Random();
int [,] CreateMatrix(int rowCount, int columesCount){
	int [,] matrix = new int [rowCount, columesCount];
	for(int i = 0; i < matrix.GetLength(0); i++){
		for(int j = 0; j < matrix.GetLength(1); j++){
			matrix[i,j] = rnd.Next(1, 11);
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
int[,] matrix = CreateMatrix(4, 7);
PrintMatrix(matrix);
}}
