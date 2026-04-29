Estudiante e1 = new Estudiante();
e1.nombre = "pedro";
e1.correo = "prmendez@gmail.com";
Console.WriteLine(e1.nombre); Console.WriteLine(e1.correo);
e1.Iniciarsesion();
e1.estudiar();
Console.WriteLine();
Profesor p1 = new Profesor();
p1.nombre = "juan";
p1.correo = "juan@gmail.com";
Console.WriteLine(p1.nombre); Console.WriteLine(p1.correo);
p1.Iniciarsesion();
p1.ensenar();
Console.WriteLine();
Cordinador c1= new Cordinador();
c1.nombre = "ricardo";
c1.correo = "ricardo@gmail.com";
Console.WriteLine(c1.nombre); Console.WriteLine(c1.correo);
c1.Iniciarsesion();
c1.supervisar();
class Persona
{
    public string nombre;
    public string correo;

    public void Iniciarsesion()
    {
        Console.WriteLine("inicio de sesion exitoso");
    }
}

class Estudiante : Persona
{
    public void estudiar()
    {
        Console.WriteLine(nombre+" esta estudiando");
    }
}

class Profesor: Persona
{
    public void ensenar()
    {
        Console.WriteLine(nombre+" esta ensenando");
    }
}

class Cordinador : Persona
{
    public void supervisar()
    {
        Console.WriteLine(nombre + " esta supervisando");
    }
}
