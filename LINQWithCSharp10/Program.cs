using LINQWithCSharp10;
using LINQWithCSharp10.LINQFuntions;


Console.WriteLine("Selecciona una opcion para poder probar los diferentes features de LINQ con C# 10\n");
Console.WriteLine("1- Ejecutar la clase EjecucionDiferida");
Console.WriteLine("2- Ejecutar la clase WhereFunction");
Console.WriteLine("3- Ejecutar la clase WhereWithObjects");
Console.WriteLine("4- Ejecutar la clase FirstOrDefault");
Console.WriteLine("5- Ejecutar la clase LastOrDefault");
Console.WriteLine("6- Ejecutar la clase ElementAtOrDefault");
Console.WriteLine("7- Ejecutar la clase SingleAtOrDefault");
Console.WriteLine("8- Ejecutar la clase OfType");

var option = Console.ReadLine();

switch (option)
{
    case "1":
        EjecucionDiferida.Ejecutar();
        break;
    case "2":
        WhereFunction.Ejecutar();
        break;
    case "3":
        WhereWithobjects.Ejecutar();
        break;
    case "4":
        FirstOrDefault.Ejecutar();
        break;
    case "5":
        LastOrDefault.Ejecutar();
        break;
    case "6":
        ElementAtOrDefault.Ejecutar();
        break;
    case "7":
        SingleOrDefault.Ejecutar();
        break;
    case "8":
        OfType.Ejecutar();
        break;
    
    default:
        Console.WriteLine("Opción inválida");
        break;
}