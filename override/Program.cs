Empleado e1 = new Empleado();
e1.nombre = "juan";
e1.TipoAcceso();
Console.WriteLine();

Visitante v1=new Visitante();
v1.nombre = "ricardo";
v1.TipoAcceso();
Console.WriteLine();

Seguridad s1 = new Seguridad();
s1.nombre = "eliseo";
s1.TipoAcceso();
class Persona
{
    public string nombre;

    public virtual void TipoAcceso()
    {
        Console.WriteLine(nombre+" tiene acceso basico");
    }
}

class Empleado : Persona
{
    public override void TipoAcceso()
    {
        Console.WriteLine(nombre+" tiene acceso a oficinas");
    }
}

class Visitante : Persona
{
    public override void TipoAcceso()
    {
        Console.WriteLine(nombre+"tiene acceso limitado");
    }
}

class Seguridad : Persona
{
    public override void TipoAcceso()
    {
        Console.WriteLine(nombre+" tiene acceso al edificio");
    }
}