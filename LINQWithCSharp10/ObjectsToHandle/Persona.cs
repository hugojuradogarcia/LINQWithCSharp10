namespace LINQWithCSharp10.ObjectsToHandle;

public class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public bool Soltero { get; set; }
    public DateTime FechaIngresoALaEmpresa { get; set; }
    public List<string> Telefonos { get; set; }
    public int EmpresaId { get; set; }
    
    public Persona()
    {
    }
    
    public static List<Persona> AgregarPersonas()
    {
        return new List<Persona>
        {
            new Persona { Nombre = "Eduardo", Edad = 30, Soltero = true, FechaIngresoALaEmpresa = new DateTime(2021, 1, 4), Telefonos = new List<string>{ "4422123122"}, EmpresaId = 1 },
            new Persona { Nombre = "Juan", Edad = 21, Soltero = false, FechaIngresoALaEmpresa = new DateTime(2022, 11, 2), Telefonos = new List<string>{ "6543234576"}, EmpresaId = 1 },
            new Persona { Nombre = "Javier", Edad = 34, Soltero = false, FechaIngresoALaEmpresa = new DateTime(2015, 6, 21), Telefonos = new List<string>{ "2134123587"}, EmpresaId = 2 },
            new Persona { Nombre = "Eva", Edad = 20, Soltero = true, FechaIngresoALaEmpresa = new DateTime(2023, 3, 25), Telefonos = new List<string>{ "2132453423"}, EmpresaId = 2 },
            new Persona { Nombre = "Karen", Edad = 37, Soltero = true, FechaIngresoALaEmpresa = new DateTime(2025, 1, 29), Telefonos = new List<string>{ "5546345212"}, EmpresaId = 1 },
            new Persona { Nombre = "Mila", Edad = 16, Soltero = true, FechaIngresoALaEmpresa = new DateTime(2025, 4, 25), Telefonos = new List<string>{ "213445245"}, EmpresaId = 1 },
        };
    }
}