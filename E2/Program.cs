// See https://aka.ms/new-console-template for more information
using System.Runtime.ExceptionServices;

Console.WriteLine(" Promedio de cursos ");

double[] notas = new double[4];
double promedio =0;

for (int i = 0; i < 4; i++)
{
    Console.WriteLine(" Ingresa la nota " + (1 + i));
    notas[i] = Convert.ToDouble(Console.ReadLine());
}

for (int i = 0; i < 4; i++)
{
    promedio = promedio + notas[i];
}

promedio = promedio / 4;

if (promedio >= 61)
{
    Console.WriteLine(" Aprobado, el promedio es :" +promedio );
}
else
{
    Console.Write(" Reprobado, el promedio es :" +promedio );
}
