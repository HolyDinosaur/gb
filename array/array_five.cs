using System;
class Program{
        static void Main()
{
int[] array = new int [] {1, 5, 10, 20, 30, 40, 99, 4, 90, 3, 2, 6};
int minRange = 10;
int maxRange = 90;
int count = 0;
foreach (int number in array)
        if (number >= minRange && number <= maxRange)
            count++;

    Console.WriteLine(count);

}}
