namespace CSharpBasics;

public class PersonTest
{
    public static void Main(string[] args)
    {
        foreach (var a in args)
        {
            Console.WriteLine(a);
        }
        
        Console.WriteLine("----------------");
        
        Person p1 = new Person("Peter", "Parker");
        Console.WriteLine(p1);
        Console.WriteLine(p1.GetId());
        Person p2 = new Person("Carol", "Danvers");
        Console.WriteLine(p2);
        Console.WriteLine(p2.GetVorname());
        Person p3 = new Person("Tony", "Stark");
        p3.SetNachname("Banner");
        Console.WriteLine(p3);
        Console.WriteLine(p3.GetNachname());
        p3.Info = "Das ist eine Info";
        Console.WriteLine(p3.Info);
        Person p4 = new Person("Hansen");
        Console.WriteLine(p4);
        
        // Ändern der Reihenfolge bei Vorgabe der Labels
        Person p5 = new Person(nachname: "Hansen", vorname: "Hans");
        Console.WriteLine(p5);
        
        Console.WriteLine("--------------");
        
        PersonUtility.ShowPerson(p2); // Aufruf einer statischen Methode (Klassenmethode)
        // PersonUtility pu = new PersonUtility();
        // pu.ShowPerson(p2); // Error
        
        Console.WriteLine("--------------");

        List<Person> personen = new List<Person>();
        personen.Add(p1);
        personen.Add(p2);
        personen.Add(p3);
        PersonUtility.ShowPerson(personen);
        
        Console.WriteLine("--------------");
        
        //Spiderman spiderman = new Spiderman(); // Error:; Konstruktor ist privat
        Spiderman spiderman = Spiderman.GetInstance(); // Verwendung eines Singleton
        spiderman.UseWeb();
        spiderman.UseWeb();
        spiderman.UseWeb();
        spiderman.UseWeb();
        spiderman.UseWeb();
        spiderman.UseWeb();
        spiderman.UseWeb();
        
        //Spiderman spiderman2 = new Spiderman();
        //spiderman2.UseWeb();
        
        Spiderman spiderman2 = Spiderman.GetInstance();
        spiderman2.UseWeb();
        spiderman2.UseWeb();
        
        Console.Write("Gleiches Objekt? ");
        Console.WriteLine(spiderman == spiderman2);

        int i = 3;
        int j = 22;
        Console.WriteLine(i.ToString("0000"));
        var iAsStr = $"{i:D2}:{j:D2}";
        Console.WriteLine(iAsStr);
    }
}