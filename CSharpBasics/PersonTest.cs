namespace CSharpBasics;

public class PersonTest
{
    public static void Main(string[] args)
    {
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
    }
}