namespace Common;

// dotnet new classlib --name Common
// dotnet add reference /Users/a2/Lessons/Common/Common.csproj

public static class Helper
{
    public static void PrintArray(int[] array)
    {
        for (var i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            Console.Write(" ");
        }
    }

    public static int[] CreateRandomArray()
    {
        Random random = new Random();

        int[] array = new int[10];

        for (var i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-10, 11);
        }

        return array;
    }
}
