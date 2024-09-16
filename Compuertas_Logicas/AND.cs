using System.Collections;

namespace ConsoleApp1;

public class And: ICompuertas
{
    public string name { get; }
    public List<bool> entradas = new List<bool>();
    
    private bool result;

    public void AgregarEntrada(string nombre, bool valor)
    {
        entradas.Add(valor);
    }

    public bool Calcular()
    {
        foreach (bool entrada in entradas)
        {
            if (entrada == false)
            {
                result = false;
                return result;
            }
            
        }

        result = true;
        return result;
    }

    public And(string nombre)
    {
        this.name = nombre;
    }
}