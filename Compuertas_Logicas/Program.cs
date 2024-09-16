namespace ConsoleApp1;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("----------------------------------");
        Console.WriteLine("----------------------------------");
        
        bool a = true;
        bool b = true;
        bool c = true;
        
        Console.WriteLine("Prueba NOT");
        
        //Inicia prueba Compuerta NOT
        ICompuertas A = new Not("A");
        A.AgregarEntrada("a", a);
        bool Aneg = A.Calcular();
        Console.WriteLine(Aneg);
        ICompuertas B = new Not("B");
        B.AgregarEntrada("b", b);
        bool Bneg = B.Calcular();
        Console.WriteLine(Bneg);
        Console.WriteLine("----------------------------------");
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Prueba AND");
        
        //Inicia prueba Compuerta AND
        ICompuertas ab__and= new And("Ab_and");
        ab__and.AgregarEntrada("a",a);
        ab__and.AgregarEntrada("b",b);
        bool aband = ab__and.Calcular();
        Console.WriteLine(aband);
        ICompuertas abc__and = new And("Abc_and");
        abc__and.AgregarEntrada("a",a);
        abc__and.AgregarEntrada("b",b);
        abc__and.AgregarEntrada("c",c);
        bool abcand = abc__and.Calcular();
        Console.WriteLine(abcand);
        Console.WriteLine("----------------------------------");
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Prueba OR");
        
        //Inicia prueba Compuerta OR
        ICompuertas ab__or= new And("Ab_or");
        ab__or.AgregarEntrada("a",a);
        ab__or.AgregarEntrada("b",b);
        bool abor = ab__or.Calcular();
        Console.WriteLine(abor);
        ICompuertas abc__or = new And("Abc_and");
        abc__or.AgregarEntrada("a",a);
        abc__or.AgregarEntrada("b",b);
        abc__or.AgregarEntrada("c",c);
        bool abcor = abc__and.Calcular();
        Console.WriteLine(abcor);
        Console.WriteLine("----------------------------------");
        Console.WriteLine("----------------------------------");

        //Inicia Garage
        ICompuertas Anegado = new Not("A negado");
        Anegado.AgregarEntrada("a", a);
        bool aneg = Anegado.Calcular();
        ICompuertas Bnegado = new Not("B negado");
        Anegado.AgregarEntrada("b", b);
        bool bneg = Bnegado.Calcular();
        
        
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
        
        Console.WriteLine("Resultado GarageGate");
        Console.WriteLine(resultado);
        Console.WriteLine("----------------------------------");
        Console.WriteLine("----------------------------------");
    }
    
}