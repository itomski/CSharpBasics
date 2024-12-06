namespace CSharpBasics;

public class Interfaces
{
    public static void InterfaceVererbung()
    {
        // IJob job1 = new IJob(); // Keine Instanzen von Interfaces möglich

        IJob j1 = new AutoReparatur();
        j1.DoJob(); // Methode von AutoReparatur wird benutzt

        j1 = new Reinigung();
        j1.DoJob(); // Methode von Reinigung wird benutzt

        // Interface sagt welche Methoden es geben muss
        // Konkrete Klasse entscheidet, wie diese Methoden ausprogrammiert sind
        Printable p1 = new AutoReparatur();
        p1.print();
        
        Console.WriteLine(IJob.INFO);
    }
}

interface IJob
{
    // Alle Methoden im Interface sind public
    // Alle Eigenschaften sind public, static und readonly
    public static readonly string INFO = "Konstante Information";
    public void DoJob();
}

interface Printable
{
    public void print();
}

// class Klassenname : ElternKlasse, ErstesInterface, ZweitesInterface, etc.
class AutoReparatur : IJob, Printable // Das Interface wird realisiert
{
    public void DoJob() // Implementierung einer abstrakten Methode
    {
        Console.WriteLine("Auto reparatur");
    }

    public void print()
    {
        Console.WriteLine("AutoReparatur: print");
    }
}

class Reinigung : IJob // Das Interface wird realisiert
{
    public void DoJob() // Implementierung einer abstrakten Methode
    {
        Console.WriteLine("Reinigung");
    }
}