using System;
class Program{
        static void Main()
{
	double[] array = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01};
	double min = array[0];
        double max = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];

            }
        }
	for (int j = 0; j < array.Length; j++)
	{
	    if (array[j] < min)
            {
                min = array[j];

            }
	
	}
        Console.WriteLine("Число с наибольшей дробной частью: " + max);
        Console.WriteLine("Число с наименьшей дробной частью: " + min);
	Console.WriteLine("Разница: " + (max-min));
        Console.ReadKey();
}}	
