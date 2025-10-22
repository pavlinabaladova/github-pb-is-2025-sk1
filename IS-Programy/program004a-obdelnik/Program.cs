
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("***** Vykreslení obdelníhu *****");
    Console.WriteLine("****************************");
    Console.WriteLine("******* Pavlína Baladová ********");
    Console.WriteLine("****************************");
    Console.WriteLine();

    // Vstup hodnoty do programu - špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    //Vstup hodnoty do programu - řešený správně
    Console.Write("Zadejte výšku ");
    int height;
    while (!int.TryParse(Console.ReadLine(), out height))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte výšku znovu: ");
    }

    Console.Write("Zadejte šířku: ");
    int width;
    while (!int.TryParse(Console.ReadLine(), out width))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte šířku znovu: ");
    }

    for (int i = 1; i <= height ;i++)
    {
    for (int j = 1; j <= width; j++)
    {
        Console.Write("* ");
    }
        Console.WriteLine();
    }
    Console.WriteLine();
   



