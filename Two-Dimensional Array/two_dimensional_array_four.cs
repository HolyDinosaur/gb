using System;
class Program{
        static void Main(){
int[,] numbers = new int[,] {
    {1, 2, 3},
    {1, 1, 0},
    {7, 8, 2},
    {9, 10, 11}
};

 void SumLines(int[,] numbers)
        {
            int[] SumLines = new int[numbers.GetLength(0)];
            Console.Write("\nСуммы элементов в каждой строке: ");
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    SumLines[i] += numbers[i, j];
                }
                Console.Write($"{SumLines[i]} ");
            }
            int min = 0;
            for (int i = 0; i < SumLines.Length; i++)
            {
                if (SumLines[min] > SumLines[i]) min = i;
            }
            Console.Write($"\nНаименьшая сумма элементов: {min}");
}
SumLines(numbers);
}}
