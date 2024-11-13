namespace pocitaniNPromennejch;

public class Generator
{ 
    Random _random = new Random();

    public void PrintRandom()
    {
        Console.WriteLine(_random.Next());
    }
}

