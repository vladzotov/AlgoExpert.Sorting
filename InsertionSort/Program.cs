using InsertionSort;

int[] array = new int[] { 8, 5, 2, 9, 5, 6, 3 };
new InsertionSortIssue().InsertionSort(array);

foreach (var item in array)
{
    Console.WriteLine(item);
}

namespace InsertionSort
{
    public class InsertionSortIssue
    {
        public int[] InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int currentIndex = i;
                while (currentIndex > 0 && array[currentIndex] < array[currentIndex - 1])
                {
                    int temp = array[currentIndex];
                    array[currentIndex] = array[currentIndex - 1];
                    array[currentIndex - 1] = temp;

                    currentIndex--;
                }
            }

            return array;
        }

        public int[] InsertionSort2(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int unsortedNumIndex = i;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (array[unsortedNumIndex] < array[j])
                    {
                        int temp = array[unsortedNumIndex];
                        array[unsortedNumIndex] = array[j];
                        array[j] = temp;

                        unsortedNumIndex--;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return array;
        }
    }
}