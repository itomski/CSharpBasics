namespace CSharpBasics;

public class PersonUtility
{
    // Es können keine Objekte dieser Klasse erzeugt werden
    private PersonUtility() { }
    
    public static void ShowPerson(Person person)
    {
        Console.WriteLine(person);
    }
    
    public static void ShowPerson(List<Person> personen)
    {
        foreach (var p in personen)
        {
            Console.WriteLine(p);
        }
    }
}