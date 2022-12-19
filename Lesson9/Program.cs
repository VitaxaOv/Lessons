


for (var i = 0; i < 5; i++)
{
    Console.Write(" ! ");
}

//Method();

void Method(int i = 0)
{
    if (i < 5)
    {
        Console.Write(" ? ");
        Method(i + 1);
    }

    return;
}

void Me(int[] arr = null)
{
    if(arr is null)
    {
        arr = new int[6];
    }
}
