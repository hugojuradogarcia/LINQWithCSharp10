using LINQWithCSharp10.ObjectsToHandle;

namespace LINQWithCSharp10.LINQFuntions;

public static class WhereWithobjects
{
    public static void Ejecutar()
    {
        // Sintaxis de metodos
        var personas = Persona.AgregarPersonas();

        Console.WriteLine("\nPersonas menores o  iguales a 25");
        var personasDe25OMenos = personas.Where(p => p.Edad <= 25).ToList();
        foreach (var persona in personasDe25OMenos)
        {
            Console.WriteLine($"{persona.Nombre} tiene {persona.Edad} años.");
        }
        
        Console.WriteLine("\nPersonas solteras");
        var solteros = personas.Where(p => p.Soltero).ToList();
        foreach (var persona in solteros)
        {
            Console.WriteLine($"{persona.Nombre} es soltero.");
        }
        
        Console.WriteLine("\nPersonas con menos de tres meses en la empresa");
        var personasMasNuevas = personas.Where(p => p.FechaIngresoALaEmpresa >= DateTime.Now.AddMonths(-3)).ToList();
        foreach (var persona in personasMasNuevas)
        {
            Console.WriteLine($"{persona.Nombre} tiene menos de 3 meses en la empresa, fecha de ingreso {persona.FechaIngresoALaEmpresa}.");
        }
        
        // Sintaxis de query
        Console.WriteLine("\n(Sintaxis de query) Personas con menos de tres meses en la empresa");
        var personasMasNuevas_2 = from p in personas
            where p.FechaIngresoALaEmpresa >= DateTime.Now.AddMonths(-3)
                select p;
        foreach (var persona in personasMasNuevas_2)
        {
            Console.WriteLine($"{persona.Nombre} tiene menos de 3 meses en la empresa, fecha de ingreso {persona.FechaIngresoALaEmpresa}.");
        }
                
    }
}