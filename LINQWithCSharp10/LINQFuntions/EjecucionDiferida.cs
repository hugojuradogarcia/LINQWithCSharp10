namespace LINQWithCSharp10;

public static class EjecucionDiferida
{
    public static void Ejecutar()
    {
        int[] numeros = Enumerable.Range(1, 5).ToArray();

        var numerosPares = numeros.Where(numero =>
        {
            Console.WriteLine($"Evaluando si {numero} es par");
            return numero % 2 == 0;
        }).ToList();

        foreach (var numero in numerosPares)
        {
            Console.WriteLine($"Si, el {numero} es par");
        }
    }
}