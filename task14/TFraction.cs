namespace lw4.task14;

public class TFraction
{
    protected int numerator, denominator;

    public TFraction()
    {
        numerator = 0;
        denominator = 0;
    }

    public TFraction(int numerator, int denominator)
    {
        this.numerator = numerator;
        this.denominator = denominator;
    }

    public TFraction(TFraction fraction)
    {
        this.numerator = fraction.numerator;
        this.denominator = fraction.denominator;
    }

    public int Numerator
    {
        get => numerator;
        set => numerator = value;
    }

    public int Denominator
    {
        get => denominator;
        set => denominator = value;
    }

    public virtual TFraction Reduce()
    {
        int d = gcd(numerator, denominator);
        this.denominator /= d;
        this.numerator /= d;
        return this;
    }

    public static TFraction operator +(TFraction a, TFraction b)
    {
        TFraction res = new TFraction(
            a.numerator * b.denominator + a.denominator * b.numerator,
            a.denominator * b.denominator);
        return res.Reduce();
    }
    
    public static TFraction operator -(TFraction a, TFraction b)
    {
        TFraction res = new TFraction(
            a.numerator * b.denominator - a.denominator * b.numerator,
            a.denominator * b.denominator);
        return res.Reduce();
    }
    
    public static TFraction operator *(TFraction a, TFraction b)
    {
        TFraction res = new TFraction(
            a.numerator * b.numerator,
            a.denominator * b.denominator);
        return res.Reduce();
    }
    
    public static TFraction operator /(TFraction a, TFraction b)
    {
        TFraction res = new TFraction(
            a.numerator * b.denominator,
            a.denominator * b.numerator);
        return res.Reduce();
    }

    protected int gcd(int a, int b)
    {
        while (a != 0 && b != 0)
        {
            if (a > b) a %= b;
            else b %= a;
        }

        return a + b;
    }
}