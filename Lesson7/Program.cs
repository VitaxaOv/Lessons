//Задача 46: Задайте двумерный массив размером m×n, 
//заполненный случайными целыми числами.
//m = 3, n = 4. 
//1 4 8 19
//5 -2 33 -2 
//77 3 8 1
using static Common.Helper;
// 2D Array
/*int[,] array = CreateRandom2DArray(3, 4);
PrintArray(array);*/

int[] array = new int[3] { 1, 3, 4 };

string str = string.Join(",", array);
Console.WriteLine(str);

string strFormat = string.Format("Это означет {0}  равно {1} аывавыа {2}", GetSomething().Item1, "", false);
string str2 = $"{GetSomething().Item1}";
string str3 = "Это означает " +  GetSomething().Item1 + "  равно "+ "" + "аывавыа " + 2; //- не норм

Console.WriteLine(strFormat);
Console.WriteLine(str2);
Console.WriteLine(str3);
string.Concat("", "","");
string.IsNullOrWhiteSpace();
string.Compare("", "");
str2.EndsWith("123");
str2.StartsWith("123");
str2.Contains("13213");
str.Distinct();
str.Remove(5,5);
str.Trim("   asfsdf   ")









// Tuples

// (int,int) coordinates = GetSomething();
// Console.WriteLine(coordinates.Item1);
// Console.WriteLine(coordinates.Item2);

(int,int) GetSomething()
{
    int a = 5;
    int b = 10;
    return (a,b);
}


