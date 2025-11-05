using System.Data.Common;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("***** Generátor pseudonáhodných čísel *****");
    Console.WriteLine("****************************");
    Console.WriteLine("******* Pavlína Baladová********");
    Console.WriteLine("****************************");
    Console.WriteLine();

    // Vstup hodnoty do programu - špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    //Vstup hodnoty do programu - řešený správně
    Console.Write("Zadejte počet generovaných čísel: ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu počet generovaných čísel: ");
    }
    Console.Write("Zadejte dolní mez: ");
    int lowerBound;
    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez: ");
    }

    Console.Write("Zadejte horní mez: ");
    int upperBound;
    while (!int.TryParse(Console.ReadLine(), out upperBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu horní  mez: ");
    }

    Console.WriteLine();
    Console.WriteLine("========================================================");
    Console.WriteLine($"Počet generovaných čísel: {n}");
    Console.WriteLine($"Horní mez: {lowerBound}");
    Console.WriteLine($"Horní mez: {upperBound}");
    Console.WriteLine("Počet čísel: {0}; Dolní mez: {1}; Horní mez: {2}", n, lowerBound, upperBound);
    Console.WriteLine("========================================================");

    //deklarace pole
    int[] myRandNumbs = new int[n];

    //Random myRandNumb = new Random(50)// generování stejných čísel při stejném vstup
    Random myRandNumb = new Random();

    Console.WriteLine();
    Console.Write("========================================================");
    Console.WriteLine("Pseudonáhodná čísla");
    for(int i=0; i < n ; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound+1);
        Console.WriteLine("{0}; ",myRandNumbs[i]);
    }

    int sumPositive = 0; //kladná čísla
    int sumNegative = 0; //záporná čísla
    int zeros = 0; // nuly

    for (int i = 0; i < n; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound + 1); // +1 aby se horní mez mohla vygenerovat
        Console.WriteLine("{0}; ", myRandNumbs[i]);

        if (myRandNumbs[i] > 0)
            sumPositive += myRandNumbs[i];
        else if (myRandNumbs[i] < 0)
            sumNegative += myRandNumbs[i];
        else 
            zeros += myRandNumbs[i];
    }

    Console.WriteLine("========================================================");
    Console.WriteLine($"Součet všech kladných čísel: {sumPositive}");
    Console.WriteLine($"Součet všech záporných čísel: {sumNegative}");
    Console.WriteLine("========================================================");



    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();


}

