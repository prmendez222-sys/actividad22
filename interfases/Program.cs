SistemaSeguridad s1 = new SistemaSeguridad();
s1.login("pedro", "123ricardo");
Console.WriteLine();
s1.salir();

class SistemaSeguridad:IAutenticacion,IAuditoria
{
    public void login(string username, string password)
    {
        Console.WriteLine("usuario: "+username+" a iniciado sesion");
        RegistrarAccion("login de "+username);
    }

    public void salir()
    {
        Console.WriteLine("ha cerrado sesion");
        RegistrarAccion("salida");
    }

    public void RegistrarAccion(string accion)
    {
        Console.WriteLine("auditoria: "+accion);
    }
}
interface IAutenticacion
{
    void login (String username, String password);
    void salir ();
}

interface IAuditoria
{
    void RegistrarAccion(string accion);
}