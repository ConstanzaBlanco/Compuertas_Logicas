namespace ConsoleApp1;

public class Or : ICompuertas
{
    public string name { get;}
    public List<bool> entradas { get;}

    public Or(string name)
    {
        this.name = name;
    }

    public void AgregarEntrada(string nombreentrada, bool valorentrada)
    {
        entradas.Add(valorentrada);
    }

    public bool Calcular()
    {
        foreach (bool valor  in entradas)
        {
            if (valor == true)
            {
                return true;
            }
        }
        return false;
    }
}