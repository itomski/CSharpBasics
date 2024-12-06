namespace CSharpBasics;

public class Vererbung
{
    public static void KlassenVererbung()
    {
        Mensch m1 = new Mensch("Bruce", 35);
        m1.ShowInfo();
        
        Student s1 = new Student();
        s1.SetName("Peter");
        s1.SetAge(25);
        s1.SetMatrikelNr("12P25001");
        s1.ShowInfo();
        
        // Referenztyp = Mensch
        // Obejttyp = Student
        Mensch m2 = s1; // Student IS-A Mensch
        m2.ShowInfo(); // wird auf Student-Objekt ausgeführt, da virtuale Methode überschrieben wurde
        
        Console.WriteLine("");
        
        Student s2 = new Student("Bob", 42, "345B42005");
        s2.ShowInfo();
        
        Console.WriteLine("");
        
        Student s3 = new Student(33, "345B33009");
        s3.ShowInfo();
        
    }
}

class Mensch
{
    private string name;
    private int age;

    public Mensch()
    {
        Console.WriteLine("CONST Mensch: Leer");
    }
    
    public Mensch(string name, int age)
    {
        Console.WriteLine("CONST Mensch: 2 Parameter");
        this.name = name;
        this.age = age;
    }

    public string GetName()
    {
        return name;
    }
    
    public int GetAge()
    {
        return age;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public void SetAge(int age)
    {
        this.age = age;
    }

    /*
    public void ShowInfo() // In den Kindklassen nicht überschreibbar!
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
    */
    
    public virtual void ShowInfo() // virtual = Kann in den Kindklassen überschrieben werden!
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}

class Student : Mensch
{
    private string matrikelNr;

    public Student()
    {   
        Console.WriteLine("CONST Student: Leer");
    }
    
    // base(name, age) = Verwendet den 2 Parameter Konstruktor der Elternklasse
    public Student(string name, int age, string matrikelNr) : base(name, age)
    {   
        Console.WriteLine("CONST Student: 3 Parameter");
        this.matrikelNr = matrikelNr;
    }
    
    // this(name, age, matrikelNr) = Verwendet den eigenen 3 Parameter Konstruktor
    public Student(int age, string matrikelNr) : this("Unbekannt", age, matrikelNr)
    {   
        Console.WriteLine("CONST Student: 2 Parameter");
    }

    public string GetMatrikelNr()
    {
        return matrikelNr;
    }

    public void SetMatrikelNr(string matrikelNr)
    {
        this.matrikelNr = matrikelNr;
    }
    
    /*
    public void ShowInfo() // Überlagern, kein echtes Überschreiben
    {
        Console.WriteLine($"Name: {GetName()}, Age: {GetAge()}, Matrikel Nr: {matrikelNr}");
    }
    */
    
    public override void ShowInfo() // Überschreiben
    {
        Console.WriteLine($"Name: {GetName()}, Age: {GetAge()}, Matrikel Nr: {matrikelNr}");
    }
}