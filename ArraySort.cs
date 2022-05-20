namespace SolutionBook
{
    class ArraySort
    {
        static void Sorting(params int[] integers)
        {
            int temp;
            for (int i = 0; i < integers.Length - 1; i++)
            {
                for (int j = i + 1; j < integers.Length; j++)
                {
                    if (integers[i] > integers[j])
                    {
                        temp = integers[i];
                        integers[i] = integers[j];
                        integers[j] = temp;
                    }
                }
            }
            Console.WriteLine("Вывод отсортированного массива");
            for (int i = 0; i < integers.Length; i++)
            {
                Console.WriteLine(integers[i]);
            }
            Console.ReadLine();
        }
    }
}