namespace CSharpBasics;

public class Delegates
{
    // Vergleichbar m it Functional Interfaces in Java
    // Schablone für eine Methode
    public delegate int MathOperation(int a, int b);
    
    public static void DelegateTest()
    {
        // Referenz auf eine anonyme Methode
        MathOperation add = (a, b) => a + b;
        
        // (a, b) => a % b; // ist ein Lambda = anonyme Methode
        MathOperation mod = (a, b) => a % b; // Realisieren eines Delegate
        Console.WriteLine(add.Invoke(100, 22)); // Delegate wird ausgeführt
        Console.WriteLine(mod.Invoke(100, 22)); // Delegate wird ausgeführt
        run(200, 35, add);
    }

    // Delegates bieten die Möglichkeit, Methoden als Parameter zu übergeben
    public static void run(int a, int b, MathOperation op)
    {
        Console.WriteLine(op.Invoke(a, b));
    }
}