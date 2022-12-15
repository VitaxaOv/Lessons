using static System.Console;
Clear();

Write("Введите нужное количество строк треугольника Паскаля: ");
int rows = int.Parse(ReadLine());
PrintTriangle(rows);


void PrintTriangle(int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int c = 0; c <= (n - i); c++) // создаём после каждой строки n-i отступов от левой стороны консоли, чем ниже строка, тем меньше отступ
        {
            Write("  ");
        }
        for (int c = 0; c <= i; c++)
        {
            Write("   "); // создаём пробелы между элементами треугольника
            Write(factorial(i) / (factorial(c) * factorial(i - c))); //формула вычисления элементов треугольника
        }
        WriteLine(); // после каждой строки с числами отступаем две пустые строчки
    }
}
double factorial(int n)
{
    double x = 1;
    for (int i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}