

ulong a = ziskatCislo("Zadejte přirozené číslo a: ");
ulong b = ziskatCislo("Zadejte přirozené číslo b: ");
    
ulong NSD = vypocitatNSD(a, b);   
  
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