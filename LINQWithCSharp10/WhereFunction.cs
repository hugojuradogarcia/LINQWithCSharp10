namespace LINQWithCSharp10;

public static class WhereFunction
{
    public static void Ejecutar()
    {
        int[] numeros = Enumerable.Range(1, 20).ToArray();

        var numerosImpares = numeros.Where(n => n % 2 == 0).ToList();
        
        Console.WriteLine("Los numeros impares menores de 20 son: ");
        foreach (var numero in numerosImpares)
        {
            Console.WriteLine(numero);
        }
        
        // Sintavis de metodos
        Console.WriteLine("(Sintaxis de metodos) Los numeros impares mayores de 20 son: ");
        var numerosImparesMayores10 = numeros.Where(n => n % 2 == 1 && n > 10).ToList();
        foreach (var numero in numerosImparesMayores10)
        {
            Console.WriteLine(numero);
        }
        
        // Sintaxis de query
        var numerosImaparesMayores10_2 = from n in numeros
            where n % 2 == 1 && n > 10
            select n;
        Console.WriteLine("(Sintaxis de query) Los numeros impares mayores de 20 son: ");
        foreach (var numero in numerosImaparesMayores10_2)
        {
            Console.WriteLine(numero);
        }
    }
}