namespace pocitaniNPromennejch;

public class Generator
{
    Random _random = new Random();
    int[] _nezname;
    int[,] _koeficienty;
    int[] _vysledek;

    public Generator(int pocetPromennych)
    {
        _nezname = new int[pocetPromennych];
        _koeficienty = new int[pocetPromennych, pocetPromennych];
        _vysledek = new int[pocetPromennych];

        for (int i = 0; i < pocetPromennych; i++)
        {
            _nezname[i] = ReturnRandomNumber(330);
            for (int j = 0; j < pocetPromennych; j++)
            {
                _koeficienty[i, j] = ReturnRandomNumber(330);
            }

            for (int j = 0; j < pocetPromennych; j++)
            {
                _vysledek[i] += _nezname[i] * _koeficienty[i, j];
            }
        }
    }

    int ReturnRandomNumber(int maxNumber)
    {
        return _random.Next(maxNumber);
    }

    public void Uloz()
    {
        Console.WriteLine("Nezname on");
        for (int i = 0; i < _nezname.Length; i++)
        {
            Console.Write($"{_nezname[i]} ");
        }

        Console.WriteLine("Koeficienty on");
        for (int i = 0; i < _koeficienty.Length; i++)
        {
            for (int j = 0; j < _koeficienty.Length; j++)
            {
                Console.Write($"{_koeficienty[i, j]} ");
            }
        }

        Console.WriteLine("Koeficienty on");
        for (int i = 0; i < _vysledek.Length; i++)
        {
            Console.Write($"{_vysledek[i]} ");
        }
    }
}