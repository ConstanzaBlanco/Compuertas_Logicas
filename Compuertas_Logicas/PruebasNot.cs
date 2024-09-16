using System.Diagnostics;

namespace ConsoleApp1;

public class PruebasNot
{
    private bool a = true;
    private bool b = false;
    private bool c = true;

    public void Pruebasnot()
    {
        ICompuertas A = new Not("A");
        A.AgregarEntrada("a", a);
        bool aneg = A.Calcular();
        Console.WriteLine(aneg);
        ICompuertas B = new Not("B");
        B.AgregarEntrada("b", b);
        bool bneg = B.Calcular();
        Console.WriteLine(bneg);

    }


}