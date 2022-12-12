namespace Common;

// dotnet new classlib --name Common
// dotnet add reference /Users/a2/Lessons/Common/Common.csproj

public static class Helper
{
    public static void PrintArray(int[,] array)
    {
        for (var i = 0; i < array.GetLength(0); i++)
        {
            for (var j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    public static int[,] CreateRandom2DArray(int countOfRows, int countOfColumns)
    {
        Random random = new Random();
        int[,] array = new int[countOfRows, countOfColumns];

        for (var i = 0; i < array.GetLength(0); i++)
        {
            for (var j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.Next(-10, 11);
            }
        }
        return array;
    }

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

    public static int InputNumber()
    {
        bool isParsed = int.TryParse(Console.ReadLine(), out int number);

        if (isParsed)
        {
            return number;
        }
        else
        {
            throw new ArgumentException("Ввели не правильное число");
        }
    }
}
