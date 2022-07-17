IEnumerable<int> misNumeros = GetNumbersYield();

Console.WriteLine(misNumeros.Count());

foreach (var el in GetNumbersNormal())
{
    Console.WriteLine($"Upload file to FTP: {el}");
}

static IEnumerable<int> GetNumbersNormal()
{
    List<int> lst = new List<int>();
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"{i}: Get large file from DB:");
        lst.Add(i);
    }

    return lst;
}

static IEnumerable<int> GetNumbersYield()
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"{i}: Get large file from DB");
        yield return i;
        //if (i == 5)
        //    yield break;
        Console.WriteLine($"{i}: Free memory");
    }
}