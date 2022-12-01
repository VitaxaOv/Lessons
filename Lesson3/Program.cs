// See https://aka.ms/new-console-template for more information

 /*
 Решение в группах задач:
Задача 18: Напишите программу, которая по заданному номеру 
четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
*/

/*
Задача 21: Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние между ними в 2D пространстве.
 
A (3,6); B (2,1) -> 5,09 A (7,-5); B (1,-1) -> 7,21
*/

/*
Задача 22: Напишите программу, которая принимает на
 вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
 int[] array =  
5 -> 1, 4, 9, 16, 25. 2 -> 1,4
*/

bool isParsedX = int.TryParse(Console.ReadLine(), out int x);

bool isParsedY = int.TryParse(Console.ReadLine(), out int y);

if(!isParsedX || !isParsedY)
{
    WriteLine("Координаты ввели не корректно");
    return;
}

int quarterNumber = GetQuarterNumberByCoordinates(x,y);
if(quarterNumber == - 1)
{
    Console.WriteLine("Координаты равны нулю");
    return;
}
Console.WriteLine(quarterNumber);

// возвращаемый_тип_данных НазваниеМетода()
// {
//    return 1; // оператор return возвращает из метода значение и останавливает его.
//}

int GetQuarterNumberByCoordinates(int x, int y)
{
    if(x > 0 && y > 0)
    {
        return 1;
    }

    if(x < 0 && y > 0)
    {
        return 2;
    }

    if(x < 0 && y < 0)
    {
        return 3;
    }

    if(x > 0 && y < 0)
    {
        return 4;
    }

    return -1;
}

void PrintArray(int[] array)
{
    for(int i= 0; i< array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

double Calculate(int a, int b)
{
    return a * b + b * a;
}