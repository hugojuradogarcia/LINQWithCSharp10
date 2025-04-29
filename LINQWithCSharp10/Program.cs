using LINQWithCSharp10;
using LINQWithCSharp10.LINQFuntions;


Console.WriteLine("Selecciona una opcion para poder probar los diferentes features de LINQ con C# 10\n");
Console.WriteLine("1- Ejecutar la clase EjecucionDiferida");
Console.WriteLine("2- Ejecutar la clase WhereFunction");
Console.WriteLine("3- Ejecutar la clase WhereWithobjects");
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
    
    default:
        Console.WriteLine("Opción inválida");
        break;
}