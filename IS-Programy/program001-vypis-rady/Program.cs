﻿// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*************************************************");
    Console.WriteLine("*************výpis*řady*čísel********************");
    Console.WriteLine("*************************************************");
    Console.WriteLine();

    /*
    // Vstup hodnoty do programu - špatně řešený
   Console.Write("Zadejte první číslo řady: ");
    int first = int.Parse(Console.ReadLine());
    */


    //Vstup hodnoty do programu - správný řešení
    Console.Write("Zadejte první číslo řady (celé číslo): ");
    int first;
    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu:");
        Console.WriteLine();
    }

    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}