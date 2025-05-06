namespace LINQWithCSharp10.ObjectsToHandle;

public abstract class Animal
{
    public abstract string? Nombre { get; set; }
}

public class Perro : Animal
{
    public override string? Nombre { get; set; }
}

public class Gato : Animal
{
    public override string? Nombre { get; set; }
}