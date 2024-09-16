namespace ConsoleApp1;

public class Program
{
    static void Main(string[] args)
    {
        bool a = true;
        bool b = true;
        bool c = true;
        ICompuertas Anegado = new Not("A negado");
        Anegado.AgregarEntrada("a", a);
        bool aneg = Anegado.Calcular();
        ICompuertas Bnegado = new Not("B negado");
        Anegado.AgregarEntrada("b", b);
        bool bneg = Anegado.Calcular();
        
        
        ICompuertas AB_And = new And("ab");
        AB_And.AgregarEntrada("a",a);
        AB_And.AgregarEntrada("b",b);
        bool ab_and = AB_And.Calcular();
        
        ICompuertas AB_And_neg = new And("-ab");
        AB_And_neg.AgregarEntrada("Aneg",aneg);
        AB_And_neg.AgregarEntrada("Bneg",bneg);
        bool ab_and_neg = AB_And_neg.Calcular();

        ICompuertas Or = new Or("ab or abneg");
        Or.AgregarEntrada("ab_and",ab_and);
        Or.AgregarEntrada("ab_and_neg",ab_and_neg);
        bool ab_or_abneg = Or.Calcular();

        ICompuertas And = new And("final");
        And.AgregarEntrada("ab_or_abneg",ab_or_abneg);
        And.AgregarEntrada("c",c);
        bool resultado = And.Calcular();
        Console.WriteLine("ACA");
        Console.WriteLine(resultado);

    }
}