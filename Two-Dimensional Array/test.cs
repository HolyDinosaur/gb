using System;
class Program{
        static void Main(){

int[,] numbers = new int[,] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
};
for (int i=0; i<numbers.GetLength(0); i++) {
    int temp = numbers[0][i];
    numbers[0][i] = numbers[3][i];
    numbers[3][i] = temp;
}
for(int i = 0; i <  numbers.GetLength(0); i++)
            {
                for(int j = 0; j <  numbers.GetLength(1); j++)
                {
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey(true);
}}
