using LINQWithCSharp10;


Console.WriteLine("Selecciona una opcion para poder probar los diferentes features de LINQ con C# 10\n");
Console.WriteLine("1- Ejecutar la clase EjecucionDiferida");
var option = Console.ReadLine();

switch (option)
{
    case "1":
        EjecucionDiferida.Ejecutar();
        break;
    default:
        Console.WriteLine("Opción inválida");
        break;
}