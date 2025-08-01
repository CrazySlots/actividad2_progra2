// See https://aka.ms/new-console-template for more information
Console.WriteLine("Tablas de mutiplicar");

for (int i=1;i<11;i++) {
    Console.WriteLine("--------------------------");
    Console.WriteLine(" Es la tabla de "+i);
    for (int j = 1; j < 11; j++)
    {
        Console.WriteLine(i + "* " + j +" = "+(j*i));

    }
}
