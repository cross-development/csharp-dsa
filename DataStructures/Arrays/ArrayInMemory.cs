namespace DataStructures.Arrays;

public static class ArrayInMemory
{
    public static void Demonstrate()
    {
        IterateOver(new[] { 1, 2, 3 });
    }

    private static unsafe void IterateOver(int[] array)
    {
        fixed (int* b = array)
        {
            int* p = b;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(*p);
                p++;
            }
        }
    }
}