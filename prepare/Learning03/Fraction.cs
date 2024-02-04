using System.Security.Principal;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    public string GetFractionString()
    {
        string fraction = $"{_numerator}/{_denominator}";
        return fraction;
    }

    public double GetDecimalValue()
    {
        double decimalValue = (double)_numerator / (double)_denominator;
        return decimalValue;
    }

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;


    }

    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }
}