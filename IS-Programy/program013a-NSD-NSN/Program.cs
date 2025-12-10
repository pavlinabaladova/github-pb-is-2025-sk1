

ulong a = ziskatCislo("Zadejte přirozené číslo a: ");
ulong b = ziskatCislo("Zadejte přirozené číslo b: ");
    
ulong nsd = vypocitatNSD(a, b);  

zobrazitVysledky(a, b, nsd, nsn); 
  
static ulong vypocitatNSD(ulong a, ulong b) {
    while(a != b) {
        if(a > b) {
            a = a - b;
        } else {
            b = b - a;
        }
    }
    return a;
}

static void zobrazitVysledky(ulong a, ulong b, ulong nsd, ulong nsn) {
    Console.WriteLine($"NSD čísel {a} a {b} je {nsd}");
    Console.WriteLine($"NSN čísel {a} a {b} je {nsn}");
}