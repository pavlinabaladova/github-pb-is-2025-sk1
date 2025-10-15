string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("*** Ciferný součet  a součin ***");
    Console.WriteLine("****************************");
    Console.WriteLine("******* Pavlína Baladová *****");
    Console.WriteLine("****************************");
    Console.WriteLine();


    //Vstup hodnoty do programu - řešený správně
    Console.Write("Zadejte celé číslo: ");
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte celé číslo znovu: ");
    }

    int suma = 0;
    int numberBackup = number;
    int digit;
    if (number < 0){
        number = -number;
    }

    while () {
        digit = number % 10; // zybtek po dělění 10 nám bude určovat jednotlivé cifry
        number = (number - digit) / 10;
        Console.Writeline("Digit = {0}", digit);
        suma = suma + digit;
    }
    Console.WriteLine("Zbytek = {0}", number);

    //nesmíme zapomenout přičíst poslední číslici do sumy
    suma = suma + number;

    Console.WriteLine();
    Console.WriteLine("Součet cifer čísla {0} je {1}", numberBackup, suma);


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();


}