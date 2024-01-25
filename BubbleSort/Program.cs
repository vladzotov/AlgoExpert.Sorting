using BubbleSort;

int[] array = new int[] { 8, 5, 2, 9, 5, 6, 3, 2 };
new BubbleSortIssue().BubbleSort(array);

foreach (var item in array)
{
    Console.WriteLine(item);
}

namespace BubbleSort
{
    public class BubbleSortIssue
    {
        public int[] BubbleSort(int[] array)
        {
            bool isSorted = false;
            int iteration = 0;

            while (!isSorted)
            {
                isSorted = true;
                for (int i = 0; i < array.Length - 1 - iteration; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        isSorted = false;
                    }
                }
                iteration++;
            }

            return array;
        }
    }
}