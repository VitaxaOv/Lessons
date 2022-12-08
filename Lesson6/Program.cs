using static Common.Helper; //- нужно прописать чтобы увидел класс Helper

// Задача 39: Напишите программу, которая перевернёт 
//одномерный массив (последний элемент будет на первом месте, 
//а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
Console.WriteLine(int.MaxValue);
int[] array = CreateRandomArray();
PrintArray(array);
Console.WriteLine();
int[] reversed = ReverseArray(array);

PrintArray(reversed);

int[] ReverseArray(int[] array)
{
    int[] reversedArray = new int[array.Length];

    for (var i = 0; i < array.Length; i++)
    {
        reversedArray[i] = array[array.Length - 1 - i];
    }

    return reversedArray;
}



