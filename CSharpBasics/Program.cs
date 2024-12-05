// PascalCase: Namespaces, Klassen, Methoden, Konstanten, public Eigenschaften, Enums
// camelCase: Methoden-Argumente, lokale Variablen
// _camelCase: private Variablen

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Eingabe: ");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        string? eingabe = Console.ReadLine(); // ? = kann auch null sein
        Console.ResetColor();
        Console.WriteLine("Deine Eingabe: " + eingabe);

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

        string str1 = "Mein Text";
        String str2 = "Mein Text";
    }
}