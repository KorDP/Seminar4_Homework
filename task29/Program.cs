int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = random.Next(min, max);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1]);
    Console.Write("]");
}

int[] createArray = CreateArray(8, 0, 100);
PrintArray(createArray);