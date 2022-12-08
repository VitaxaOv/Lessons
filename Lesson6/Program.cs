﻿using System;
using static Common.Helper; //- нужно прописать чтобы увидел класс Helper

// Задача 39: Напишите программу, которая перевернёт 
//одномерный массив (последний элемент будет на первом месте, 
//а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

/*Задача 40: Напишите программу, которая принимает на
вход три числа и проверяет, может ли существовать
треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное. 45 -> 101101
3 -> 11
  2 -> 10
  
Задача 44: Не используя рекурсию, выведите первые
N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и
1.
Если N = 5 -> 0 1 1 2 3 Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью
 поэлементного копирования.*/

Console.WriteLine(int.MaxValue);
int number;
try
{
  number = InputNumber();
}
catch(ArgumentException ex)
{
  Console.WriteLine(ex.Message);
  return;
}
int fdsfs = number + 1;
/*int[] array = CreateRandomArray();
PrintArray(array);
Console.WriteLine();
int[] reversed = ReverseArray(array);
*/

//PrintArray(reversed);

int[] ReverseArray(int[] array)
{
    int[] reversedArray = new int[array.Length];

    for (var i = 0; i < array.Length; i++)
    {
        reversedArray[i] = array[array.Length - 1 - i];
    }

    return reversedArray;
}



