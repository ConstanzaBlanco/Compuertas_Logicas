namespace ConsoleApp1;

public class Or : ICompuertas
{
    public string name { get;}
    public Dictionary<string,bool> nombreentradas = new Dictionary<string, bool>();

    public void AgregarEntrada(string nombre, bool valor)
    {
        nombreentradas[nombre] = valor;
    }

    public bool Calcular()
    {
        foreach (var par in nombreentradas)
        {
            if (par.Value == true)
            {
                return true;
            }
        }
        return false;
    }

    public Or(string name)
    {
        this.name = name;
    }
}