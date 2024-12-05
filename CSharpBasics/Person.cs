namespace CSharpBasics;

public class Person
{
    // Instanzvariablen: Jedes Objekt hat seine eigenen
    private int id;
    private string vorname;
    private string nachname;
    private string info;

    // Klassenvariable: Alle Objekte teilen sich gemeinsam eine Variable
    private static int count = 0;

    // Eigener Konstruktor führt dazu, dass c# keinen Default-Konstruktor bereitstellt
    public Person(string vorname, string nachname)
    {
        id = ++count;
        this.vorname = vorname;
        this.nachname = nachname;
    }

    public override string ToString()
    {
        return id + ": " + vorname + " " + nachname;
    }
    
    public int GetId()
    {
        return id;
    }

    public string GetVorname()
    {
        return vorname;
    }
    
    public string GetNachname()
    {
        return nachname;
    }

    public void SetVorname(string value)
    {
        this.vorname = value;
    }
    
    public void SetNachname(string value) => this.nachname = value;
    
    // Property
    public string Info
    {
        get => "#" + info + "#"; // Getter
        set => info = value.ToUpper();
    }
}