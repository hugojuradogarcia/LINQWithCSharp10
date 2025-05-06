using LINQWithCSharp10.ObjectsToHandle;

namespace LINQWithCSharp10.LINQFuntions;

public class OfType
{
    public static void Ejecutar()
    {
        // Sintaxis de metodos
        var listado = new List<object> { "Karen", 1, 2, "Mila", "Leonardo", 21, true };
        var strings = listado.OfType<string>().ToList();
        var numeros = listado.OfType<int>().ToList();

        Console.WriteLine("\nOfType string de la coleccion: ");
        strings.ForEach(Console.WriteLine);
        
        Console.WriteLine("\nOfType int de la coleccion: " + numeros);
        numeros.ForEach(Console.WriteLine);;
        
        // Sintaxis de query
        var strings2 = (from s in listado.OfType<string>()
            select s).ToList();
        Console.WriteLine("\nOfType string de la coleccion: ");
        strings2.ForEach(Console.WriteLine);
        
        // Ejemplo 2 utilizando herencia
        var listadoAnimales = new List<Animal>()
        {
            new Perro { Nombre = "Firulais" },
            new Gato { Nombre = "Felix" }
        };
        
        var perros = listadoAnimales.OfType<Perro>().ToList();  
        Console.WriteLine("\nOfType Perro de la coleccion: ");
        perros.ForEach(p => Console.WriteLine(p.Nombre));
        
        var gatos = listadoAnimales.OfType<Gato>().ToList();  
        Console.WriteLine("\nOfType Gato de la coleccion: ");
        gatos.ForEach(g => Console.WriteLine(g.Nombre));    
    }
}