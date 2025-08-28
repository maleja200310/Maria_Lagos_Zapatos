// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Zapatos zapato = new Zapatos();
Clientes cliente = new Clientes();

cliente.Id = 1;
cliente.Nombre = "Pepito";
zapato.Talla = 6.5m;
cliente.Telefono = 123;



Console.WriteLine(cliente.Id);
Console.WriteLine(cliente.Nombre);

public class Clientes
{
    public int Id;
    public string? Nombre;
    public DateTime FechaNacimiento;
    public int Telefono;
    public List<Zapatos>? Zapatos;

}

public class Materiales
{
    public int Id;
    public string? Nombre;
    public List<Zapatos>? Zapatos;
    
}

public class Zapatos
{
    public decimal Talla;
    public bool Disponible;
    public Estados? Estado;

}

public class Estados
{
    public int Id;
    public bool Disponible;
    public List<Zapatos>? Zapatos;

}

public class Marcas
{
    public int Id;
    public string? Nombre;
    public List<Zapatos>? Zapatos;
}
