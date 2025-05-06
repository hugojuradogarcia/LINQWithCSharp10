using LINQWithCSharp10.ObjectsToHandle;

namespace LINQWithCSharp10.LINQFuntions;

public static class FirstOrDefault
{
    public static void Ejecutar()
    {
        // Sintaxis de metodos
        var personas = Persona.AgregarPersonas();

        Console.WriteLine("\nFirst persona de la coleccion: " + personas.First().Nombre);
        Console.WriteLine("\nFirstOrDefault persona de la coleccion: " + personas.FirstOrDefault()?.Nombre);
        
        var numeros = new List<int>();
        
        Console.WriteLine("\nFirstOrDefault numeros de la coleccion: " + numeros.FirstOrDefault());
        
        Console.WriteLine("\nFirstOrDefault persona no soltera: " + personas.FirstOrDefault(p => !p.Soltero)?.Nombre);
        
        // Sintaxis de query
        var primerPersonaSoltera = (from p in personas
                where !p.Soltero
                    select p).FirstOrDefault();
        Console.WriteLine("\nFirstOrDefault persona no soltera: " + primerPersonaSoltera?.Nombre);
    }
}