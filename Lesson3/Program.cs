// See https://aka.ms/new-console-template for more information
bool isParsedX = int.TryParse(Console.ReadLine(), out int x);

bool isParsedY = int.TryParse(Console.ReadLine(), out int y);

if(!isParsedX || !isParsedY)
{
    Console.WriteLine("Координаты ввели не корректно");
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