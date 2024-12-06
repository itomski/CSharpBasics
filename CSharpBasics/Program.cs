// PascalCase: Namespaces, Klassen, Methoden, Konstanten, public Eigenschaften, Enums
// camelCase: Methoden-Argumente, lokale Variablen
// _camelCase: private Variablen
using CSharpBasics;

class Program
{
    public static void Main(string[] args)
    {
        // Programm-Argumente verarbeiten
        foreach (var a in args)
        {
            Console.WriteLine(a);
        }
        
        // InputOutput();
        // Datentypen();
        // Kontrollstrukturen();
        // Arrays();
        // StringFormat();
        // PersonTest.Instanzierung();
        // PersonTest.SingletonBeispiel();
        // Konvertierung();
        // Vererbung.KlassenVererbung();
        // Interfaces.InterfaceVererbung();
        Delegates.DelegateTest();
    }

    public static void Konvertierung()
    {
        string? eingabe = Console.ReadLine(); // ReadLine liefert einen string
        int i;
        // int i = int.Parse(eingabe); // Kann eine Exception werfen, wenn nichts eingegeben wird
        int.TryParse(eingabe, out i); // Wirft keine Exception

        i = Convert.ToInt32(eingabe);
        Console.WriteLine(i + 100);
    }
    
    public static void InputOutput()
    {
        Console.WriteLine("Eingabe: ");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        string? eingabe = Console.ReadLine(); // ? = kann auch null sein
        Console.ResetColor();
        Console.WriteLine("Deine Eingabe: " + eingabe);
    }
    
    public static void Datentypen()
    {
        // lokale Variablen
        // Value Types - Werden auf dem Stack abgelegt
        // In C# gibt es keine Wrapper-Klassen
        // Haben auch Methoden
        byte b1 = 255; // Ohne Vorzeichen
        Byte b2 = 255;
        
        short s1 = 123; // 16 bit
        Int16 s2 = 123;
        
        int i1 = 123; // 32 bit
        Int32 i2 = 123;
        
        uint ui1 = 123; // Ohne Vorzeichen
        UInt32 ui2 = 123;
        
        long l1 = 123; // 64 bit
        Int64 l2 = 123;
        
        float f1 = 123.3f; // 32 bit
        Single f2 = 123.3f;
        
        double d1 = 123.3d; // 64 bit
        Double d2 = 123.3d;
        
        decimal dc1 = 123.3m; // 128bit
        Decimal dc2 = 123.3m;
        
        char ch1 = 'a';
        Char ch2 = 'A';
        
        bool bo1 = true;
        Boolean bo2 = true;

        string? str1 = "Mein Text"; // ? = null ist erlaubt
        String str2 = "Mein Text";
        str1 = null;
    }
    
    public static void Kontrollstrukturen()
    {
        string? str1 = "Mein Text"; // ? = null ist erlaubt
        String str2 = "Mein Text";

        str1 = null;

        Console.WriteLine("--------");
        
        if (str1 != null)
        {
            Console.WriteLine(str1.ToUpper());
        }
        else if (str2.Length == 0)
        {
            Console.WriteLine("Leer");
        }
        else
        {
            Console.WriteLine("NULL");
        }
        
        Console.WriteLine("--------");
        
        // IList ist ein Interface
        // List ist eine Klasse
        IList<int> zahlen = new List<int>(); 
        zahlen.Add(5);
        zahlen.Add(7);
        zahlen.Add(22);
        zahlen.Add(1);

        for (int i = 0; i < zahlen.Count; i++)
        {
            Console.WriteLine(zahlen[i]);
        }
        
        Console.WriteLine("--------");

        foreach (var i in zahlen)
        {
            Console.WriteLine(i);
        }

        var j = 100;
        
        Console.WriteLine("--------");
        
        var input = Console.ReadLine();

        switch (input)
        {
            case "a": Console.WriteLine("Auswahl 1"); break;
            case "b": Console.WriteLine("Auswahl 2"); break;
            case "c": Console.WriteLine("Auswahl 3"); break;
            case "d": Console.WriteLine("Auswahl 4"); break;
            default: 
                Console.WriteLine("Falsche Eingabe");
                break;
        }

        Console.WriteLine("--------");
        
        int k = 0;
        while (true)
        {
            k++;
            Console.Write("x"); // Ohne Zeilenumbruch
            if(k == 10) break;
        }
    }
    
    public static void Arrays()
    {
        // Array
        string[] namen = {"Peter", "Bruce", "Natasha", "Carol"};
        Console.WriteLine(namen[2]);
        namen[2] = "Scott";
        //namen[5] = "Tony"; // Exception
        Console.WriteLine(namen[2]);
        Console.WriteLine(namen.Length);
        //Console.WriteLine(namen);

        //string[] namen2 = new string[10];
        string[] namen2 = new string[2]{"Peter", "Bruce"};

        string[] namen3;
        // namen3 = {"Peter", "Bruce"}; // Nur in Verbindung mit gleichzeitiger Deklaration möglich
        namen3 = new string[]{"Peter", "Bruce"}; // OK
    }

    public static void StringFormat()
    {
        int i = 3;
        int j = 22;
        Console.WriteLine(i.ToString("0000"));
        var iAsStr = $"{i:D2}:{j:D2}";
        Console.WriteLine(iAsStr);
    }
}