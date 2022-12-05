// Демонстрация решения
// Задача 31: Задайте массив из 12 элементов,
// заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

string str = "Lalal {0}, gdfsdsf{1}, fsdfdsfds{2}";
int[] array = GenerateArray(-9, 9, 12);
PrintArray(array);
int sumPositiveNumbers = GetSumPositiveNumbersInArray(array);
int sumNegativeNumbers = GetSumNegativeNumbersInArray(array);

int[] a = new int[4]{1,2,34,5};
a.Contains(12);

void PrintArray(int[] array)
{
   /* for (var i = 0; i < array.Length; i++)
    {
        Console.Write("{array[i]}");
    }*/
    
    //string message = string.Join(" ,", array);
    Console.WriteLine($"[{string.Join(" ,", array)}]");
    //Console.WriteLine("[{0}]",string.Join(" ,", array));

    Console.WriteLine(str , 1, 23423, "");
}

Console.WriteLine($"Сумма положительных чисел равна {sumPositiveNumbers}, сумма отрицательных равна {sumNegativeNumbers}.");

int GetSumPositiveNumbersInArray(int[] array)
{
    int sumPositiveNumbers = 0;
    for (var i = 0; i < array.Length; i++)
    {
        if (array[i] >= 0)
        {
            sumPositiveNumbers += array[i];
        }
    }

    return sumPositiveNumbers;
}

int GetSumNegativeNumbersInArray(int[] array)
{
    int sumNegativeNumbers = 0;
    for (var i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sumNegativeNumbers += array[i];
        }
    }

    return sumNegativeNumbers;
}



int[] GenerateArray(int min, int max, int length)
{
    Random random = new Random();
    int[] array = new int[length];

    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }

    return array;
}
