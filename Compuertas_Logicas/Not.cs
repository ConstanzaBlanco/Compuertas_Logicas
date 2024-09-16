namespace ConsoleApp1;

public class Not:ICompuertas
{
    public string name { get; }
    public List<bool> entradas = new List<bool>();
    public bool result;
    

    public Not(string nombre)
    {
        this.name = nombre;
    }

    public void AgregarEntrada(string nombre, bool valor)
    {
        entradas.Clear();
        entradas.Add(valor);
    }

    public bool Calcular()
    {
        foreach (bool entrada in entradas)
        {
            if (entrada == false)
            {
                return true;
            }
        }
        return false;
    }
}