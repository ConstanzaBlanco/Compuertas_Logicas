namespace ConsoleApp1;

public interface ICompuertas
{
    public string name { get; }
    
    public void AgregarEntrada(string nombre, bool valor);
    public bool Calcular();
    
}