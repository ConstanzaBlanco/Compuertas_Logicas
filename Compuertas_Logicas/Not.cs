namespace ConsoleApp1;

public class Not:ICompuertas
{
    public string name { get; }
    public bool entrada;
    

    public Not(string nombre)
    {
        this.name = nombre;
    }

    public void AgregarEntrada(string nombre, bool valor)
    {
        this.entrada = valor;
    }

    public bool Calcular()
    {
        if (entrada == false)
        {
            return true;
        }
        return false;
    }
}