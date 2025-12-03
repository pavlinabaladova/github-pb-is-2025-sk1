using System.Diagnostics;

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
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound);
        Console.WriteLine("{0}; ",myRandNumbs[i]);
    }
    Stopwatch myStopwatch = new Stopwatch();
    int compare = 0;
    int change = 0;
    //algoritmus bubblesort
    myStopwatch.Start();
    for (int i = 0; i < n - 1 ; i++)
    {
        for( int j = 0; j < n - 1; j++)
        {
            compare++;

            if(myRandNumbs[j] > myRandNumbs[j+1])
            {
                int tmp = myRandNumbs[j + 1];
                myRandNumbs[j + 1] = myRandNumbs[j];
                myRandNumbs[j] = tmp;

                change++;
            }
        } 
    }
    myStopwatch.Stop();


    //Výpis seřazených čísel
    for(int i=0; i < n ; i++)
    {
        Console.WriteLine();
        Console.Write("========================================================");
        Console.WriteLine();
        Console.Write("=============seřazená čísla: =====================");
        Console.WriteLine("{0}; ",myRandNumbs[i]);
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine($"Počet porovnání: {compare}");
    Console.WriteLine($"Počet výměn: {change}");
    Console.WriteLine("Čas potřebný na seřazení čísel: {0}",myStopwatch.Elapsed);

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();


}