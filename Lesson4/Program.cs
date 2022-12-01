//Задача 24: Напишите программу, которая принимает на вход число
// (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28 4 -> 10 8 -> 36
/*bool isParsed = int.TryParse(Console.ReadLine(), out int number);

if (!isParsed || number < 1)
{
    Console.WriteLine("Incorrect number");
    return;
}

int sum = GetSumOfNumbersInInterval(number);
Console.WriteLine(sum);*/

int[] numbers = new int[] { 1, 2, 3, 4 };

int[] sums = new int[] { 1, 3, 6, 10 };

for (var i = 0; i < numbers.Length; i++)
{
    int sum = GetSumOfNumbersInInterval(numbers[i]);

    if (sum != sums[i])
    {
        Console.WriteLine($"Ожидали получить {sums[i]} а получили {sum}");
    }
    else
    {
        Console.WriteLine("okay");
    }
}

int GetSumOfNumbersInInterval(int number)
{
    int sum = 0;
    for (var i = -1; i <= number; i++)
    {
        sum += i;
    }

    return sum;
}





