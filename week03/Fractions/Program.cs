using System;
using Fractions;
class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        fraction.SetTop(1);
        fraction.SetBottom(2);
        double top = fraction.GetTop();
        double bottom = fraction.GetBottom();
        Console.WriteLine($"{top}/{bottom}");
        string Fraction = fraction.GetFractionstring();
        double DecimalValue = fraction.GetDecimalValue();
        Console.WriteLine($"{Fraction}");
        Console.WriteLine($"{DecimalValue}");

    }
}
