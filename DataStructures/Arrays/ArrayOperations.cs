namespace DataStructures.Arrays;

public static class ArrayOperations
{
    public static void Demonstrate()
    {
        ArrayTimeComplexity(new object[] { 1, 2, 3 });
    }

    private static void ArrayTimeComplexity(object[] array)
    {
        // Access by index O(1)
        Console.WriteLine(array[0]);

        int length = array.Length;
        object elementINeedToFind = new();

        // Searching for an element O(n)
        for (int i = 0; i < length; i++)
        {
            if (array[i] == elementINeedToFind)
            {
                Console.WriteLine("Exists/Fount");
            }
        }

        // Add to a full array
        var bigArray = new int[length * 2];
        // Works faster
        Array.Copy(array, bigArray, length);
        // Add an element to the end (+1 element) of the array
        bigArray[length + 1] = 10;

        // Add to the end when there's some space
        // O(1)
        array[length - 1] = 10;

        // Removing an element O(1)
        array[6] = null;

        RemoveAt(array, 10);
    }

    private static void RemoveAt(object[] array, int index)
    {
        var newArray = new object[array.Length - 1];

        Array.Copy(array, 0, newArray, 0, index);
        Array.Copy(array, index + 1, newArray, index, array.Length - 1 - index);
    }
}