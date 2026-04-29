class Persona
{
    public string nombre;
    public DateOnly fecha_de_nacimiento;

    public void Iniciarsesion()
    {
        Console.WriteLine("inicio de sesion exitoso");
    }
}

class Estudiante : Persona
{

}

