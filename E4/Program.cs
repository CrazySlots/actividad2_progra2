// See https://aka.ms/new-console-template for more information


Estudiante[] estudiantes = new Estudiante[3];
for (int i = 0; i < 3; i++)
{
    Estudiante estudianteTemp = new Estudiante();
    Console.WriteLine("--------------------------");
    Console.WriteLine(" Ingresa los datos del estudiante");
    Console.WriteLine(" Ingresa el nombre: ");
    estudianteTemp.nombre = Console.ReadLine() ?? throw new ArgumentException();
    Console.WriteLine(" Ingresa el carnet: ");
    estudianteTemp.carne = Console.ReadLine() ?? throw new ArgumentException();
    Console.WriteLine(" Ingresa la edad");
    estudianteTemp.edad = Convert.ToInt32(Console.ReadLine());
    estudiantes[i] = estudianteTemp;
}
Console.WriteLine("--------------------------");
Console.WriteLine("--------------------------");
Console.WriteLine("--------------------------");
Console.WriteLine(" Estos son los datos ingresados");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(" Nombre: " + estudiantes[i].nombre);
    Console.WriteLine(" Carnet: " + estudiantes[i].carne);
    Console.WriteLine(" Edad: " +estudiantes[i].edad);
}

public class Estudiante
{
    public string nombre { get; set; } = "";

    public string carne { get; set; } = "";
    public int edad { get; set; } = 0;
 
}
