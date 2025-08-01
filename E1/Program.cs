//Ejercicio 1 multiplicacion por tabla 10
Console.WriteLine("Ingresa un número entero");
int entero = Convert.ToInt32(Console.ReadLine());
if (entero>0)
{
    for (int i = 1; i < 11; i++)
    {
        int resultado = entero * i;
        Console.WriteLine(entero +" * " +i +" = " +resultado );
    }
}

