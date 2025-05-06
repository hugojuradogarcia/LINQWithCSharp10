using LINQWithCSharp10.ObjectsToHandle;

namespace LINQWithCSharp10.LINQFuntions;

public class LastOrDefault
{
    public static void Ejecutar()
    {
        // Sintaxis de metodos
        var personas = Persona.AgregarPersonas();

        Console.WriteLine("\nLast persona de la coleccion: " + personas.Last().Nombre);
        
        Console.WriteLine("\nLastOrDefault persona de la coleccion: " + personas.LastOrDefault()?.Nombre);
        
        Console.WriteLine("\nLastOrDefault persona soltera: " + personas.LastOrDefault(p => p.Soltero)?.Nombre);
        
        // Sintaxis de query
        var primeraPersonaSoltera = (from p in personas
            where p.Soltero
            select p).LastOrDefault();
        Console.WriteLine("\nLastOrDefault persona soltera: " + primeraPersonaSoltera?.Nombre);
    }
}