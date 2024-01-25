using SelectionSort;

int[] array = new int[] { 8, 5, 2, 9, 5, 6, 3 };
new SelectionSortIssue().SelectionSort2(array);

foreach (var item in array)
{
    Console.WriteLine(item);
}

namespace SelectionSort
{
    public class SelectionSortIssue
    {
        public int[] SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minNumberPointer = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minNumberPointer])
                    {
                        minNumberPointer = j;
                    }
                }

                if (minNumberPointer != i)
                {
                    int temp = array[i];
                    array[i] = array[minNumberPointer];
                    array[minNumberPointer] = temp;
                }
            }

            return array;
        }

        public int[] SelectionSort2(int[] array)
        {
            int currentIndex = 0;
            while (currentIndex < array.Length - 1)
            {
                int smallestIndex = currentIndex;
                for (int i = currentIndex + 1; i < array.Length; i++)
                {
                    if (array[i] < array[smallestIndex])
                    {
                        smallestIndex = i;
                    }
                }
                Swap(currentIndex, smallestIndex, array);
                currentIndex++;

            }

            return array;
        }

        private void Swap(int firstIndex, int secondIndex, int[] array)
        {
            int temp = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = temp;
        }
    }
}