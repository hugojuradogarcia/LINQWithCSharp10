using LINQWithCSharp10.ObjectsToHandle;

namespace LINQWithCSharp10.LINQFuntions;

public class ElementAtOrDefault
{
    public static void Ejecutar()
    {
        // Sintaxis de metodos
        var personas = Persona.AgregarPersonas();
        
        Console.WriteLine("\nElement persona de la coleccion: " + personas.ElementAt(2).Nombre);
        Console.WriteLine("\nElementOrDefault persona de la coleccion: " + personas.ElementAtOrDefault(7)?.Nombre);
        
        // Sintaxis de query
        var sextaPersona = (from p in personas
            select p).ElementAtOrDefault(5);
        Console.WriteLine("\nElementOrDefault persona soltera: " + sextaPersona?.Nombre);
    }
}