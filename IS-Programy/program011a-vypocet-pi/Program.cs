string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("***** Základní program *****");
    Console.WriteLine("****************************");
    Console.WriteLine("******* Tomáš Žižka ********");
    Console.WriteLine("****************************");
    Console.WriteLine();

    int main()
    {
        int n;
        double pi = 0.0;
        double carka= 1.0;
        double cast;

        println("Zadejte počet členů řady pro výpočet čísla PI:");
        scanf("%d", &n);

        for (int i = 0, k < n; k++)
        {
            cast = carka / (2 * k + 1);
            pi = pi + cast;
            carka = -carka;
        }
        pi = 4.0 * pi;

        printf("Odhad hodnoty pi: %.15f\n", pi);

    return 0;
    }




    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();


}

