using LINQWithCSharp10.ObjectsToHandle;

namespace LINQWithCSharp10.LINQFuntions;

public class SingleOrDefault
{
    public static void Ejecutar()
    {
        // Sintaxis de metodos
        var personas = Persona.AgregarPersonas();

        Console.WriteLine("\nSingle persona de la coleccion: " + personas.Single(p => p.Edad > 36).Nombre);
        Console.WriteLine("\nSingleOrDefault persona de la coleccion: " + personas.Single(p => p.Edad > 36).Nombre);
        
        // Sintaxis de query
        var personaMayor36 = (from p in personas
            where p.Edad > 36
            select p).Single();
        Console.WriteLine("\nSingle persona soltera: " + personaMayor36.Nombre);
    }
}