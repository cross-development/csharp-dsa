namespace Algorithms;

public static class Sorting
{
    public static void BubbleSort(int[] array)
    {
        for (int partIndex = array.Length - 1; partIndex > 0; partIndex--)
        {
            for (int i = 0; i < partIndex; i++)
            {
                // Unstable - two duplicates will be replaced with each other
                // if (array[i] > array[i + 1]) 
                // if (array[i] > array[i + 1])
                // {
                //    Swap(array, i, i + 1);
                // }

                // Stable - two duplicates won't be replaced with each other
                if (array[i] > array[i + 1])
                {
                    Swap(array, i, i + 1);
                }
            }
        }
    }

    private static void Swap(int[] array, int i, int j)
    {
        if (i == j)
        {
            return;
        }

        (array[i], array[j]) = (array[j], array[i]);
    }
}