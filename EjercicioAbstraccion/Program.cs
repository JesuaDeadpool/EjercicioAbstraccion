
using System;
using EjercicioAbstraccion;

int opcion = 0;
AreaTriangulo areaTriangulo = new AreaTriangulo();
MillasKilometros millasKilometros = new MillasKilometros();

Console.WriteLine("-------OPERACIONES MATEMATICAS--------");
Console.WriteLine("        1. Area de un Triangulo       ");
Console.WriteLine("        2. Millas a Kilometros        ");
Console.WriteLine("-------ELIJA UNA OPCION DEL 1 AL 3----");
opcion = Convert.ToInt32(Console.ReadLine());

switch (opcion)
{
    case 1:
        Console.WriteLine("------Area de un Triangulo-----");
        Console.WriteLine();
        Console.WriteLine("Ingrese la base del triangulo : ");
        areaTriangulo.Base = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese la altura del triangulo : ");
        areaTriangulo.Altura = Convert.ToInt32(Console.ReadLine());

        areaTriangulo.Imprimir(); 
        
        break;

    case 2:
        Console.WriteLine("------Millas a Kilometros-----");
        Console.WriteLine();
        Console.WriteLine("Ingrese la base del triangulo : ");
        millasKilometros.Millas = Convert.ToInt32(Console.ReadLine());
      
        millasKilometros.Imprimir();
        break;

    case 3:

        break;

    default:
        Console.WriteLine($"La opcion que ingreso {opcion} no es valida, elija una opcion entre el 1 al 3 ");
        break; 
}