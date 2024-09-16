namespace ConsoleApp1;

public interface ICompuertas
{
    public string name { get; }
    
    public List<bool> entradas { get; }
    
    public void AgregarEntrada(string nombre, bool valor);
    public bool Calcular();
    
}