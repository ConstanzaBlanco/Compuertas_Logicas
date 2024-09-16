namespace ConsoleApp1;

public interface ICompuertas
{
    public string name { get; set; }
    
    public List<bool> entradas { get; set; }
    
    public bool AgregarEntrada(string nombre, bool valor);
    public bool Calcular();
    
}