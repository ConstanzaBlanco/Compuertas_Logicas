using System.Collections;

namespace ConsoleApp1;

public class And: ICompuertas
{
    public string name { get; }
    public Dictionary<string,bool> nombreentradas = new Dictionary<string, bool>();

    public void AgregarEntrada(string nombre, bool valor)
    {
        nombreentradas[nombre] = valor;
    }

    public bool Calcular()
    {
        foreach (var par in nombreentradas)
        {
            if (par.Value == false)
            {
                return false;
            }
        }
        return true;
    }

    public And(string nombre)
    {
        this.name = nombre;
    }
}