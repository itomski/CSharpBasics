namespace CSharpBasics;

public class Spiderman
{
    private int _webCount = 5;

    // readonly == final in Java
    private readonly static Spiderman _instance = new Spiderman();
    
    private Spiderman()
    {   
    }
    
    public static Spiderman GetInstance()
    {
        return _instance;
    }

    public void UseWeb()
    {
        if (_webCount < 1)
        {
            Console.WriteLine("Spiderman: Netz ist verbraucht!");
            return;
        }

        _webCount--;
        Console.WriteLine("Spiderman: Spinnt Netz");
    }

    public override string ToString()
    {
        return "Spiderman: " + _webCount;
    }
}