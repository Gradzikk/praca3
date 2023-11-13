// Klasa bazowa KontoBankowe
class KontoBankowe
{
    protected double saldo;

    public KontoBankowe()
    {
        saldo = 0;
    }

    public double Saldo
    {
        get { return saldo; }
    }

    public virtual void Wplac(double kwota)
    {
        saldo += kwota;
    }

    public virtual void Wyplac(double kwota)
    {
        saldo -= kwota;
    }
}

// Klasa reprezentująca konto oszczędnościowe
class KontoOszczednosciowe : KontoBankowe
{
    public override void Wplac(double kwota)
    {
        base.Wplac(kwota);
        Console.WriteLine($"Wpłata na konto oszczędnościowe: {kwota}");
    }
}

// Klasa reprezentująca konto rozliczeniowe
class KontoRozliczeniowe : KontoBankowe
{
    public override void Wyplac(double kwota)
    {
        base.Wyplac(kwota);
        Console.WriteLine($"Wypłata z konta rozliczeniowego: {kwota}");
    }
}

// Klasa reprezentująca konto inwestycyjne
class KontoInwestycyjne : KontoBankowe
{
    public override void Wplac(double kwota)
    {
        base.Wplac(kwota);
        Console.WriteLine($"Wpłata na konto inwestycyjne: {kwota}");
    }
}

class Program
{
    static void Main()
    {
        KontoBankowe[] konta = new KontoBankowe[]
        {
            new KontoOszczednosciowe(),
            new KontoRozliczeniowe(),
            new KontoInwestycyjne()
        };

        foreach (var konto in konta)
        {
            konto.Wplac(1000);
            konto.Wyplac(500);
            Console.WriteLine($"Saldo: {konto.Saldo}");
        }
    }
}
