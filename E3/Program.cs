// See https://aka.ms/new-console-template for more information
string opcion = "g";
if (opcion != null)
{


    while (opcion != "d")
    {
        Console.WriteLine(" ------------------------------------------");
        Console.WriteLine(" Bienvenido, selecciona una opción del menu ");
        Console.WriteLine(" a. Suma dos numeros");
        Console.WriteLine(" b. Calcular el área de un circulo ");
        Console.WriteLine(" c. Ver si un número es par o impar ");
        Console.WriteLine(" d. Salir ");
        opcion = Console.ReadLine() ?? throw new ArgumentException();
        Console.WriteLine(" ----------------------------------------- ");
        switch (opcion)
        {
            case "a":
                suma();
                break;
            case "b":
                area();
                break;
            case "c":
                verificar();
                break;
        }

    }
}

static void suma()
{
    double n1 = 0;
    double n2 = 0;
    Console.WriteLine(" ingresa un número ");
    n1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(" ingresa un número ");
    n2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(" La suma de ambos números es: "+ (n1+n2));
}

static void area()
{
    double radio = 0;
    double area = 0;
    Console.WriteLine(" Ingresa el radio del círculo");
    radio = Convert.ToDouble(Console.ReadLine());
    area = 3.16 * radio * radio;
    Console.WriteLine(" El área es: "+area);

}
static void verificar()
{
    double n = 0;
    Console.WriteLine("Ingresa un número");
    n = Convert.ToDouble(Console.ReadLine());
    if ((n % 2) == 0)
    {
        Console.WriteLine(" El número es par");

    }
    else
    {
        Console.WriteLine(" El número es impar");
    }
}