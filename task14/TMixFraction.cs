namespace lw4.task14;

public class TMixFraction : TFraction
{
    private int whole;

    public TMixFraction()
    {
        this.whole = 0;
    }

    public TMixFraction(int numerator, int denominator, int whole) : base(numerator, denominator)
    {
        this.whole = whole;
    }

    public TMixFraction(TMixFraction fraction) : base(fraction)
    {
        this.whole = fraction.whole;
    }

    public int Whole
    {
        get => whole;
        set => whole = value;
    }

    public override TMixFraction Reduce()
    {
        int a = numerator + denominator * whole, b = denominator;
        int d = gcd(a, b);
        a /= d;
        b /= d;
        denominator = b;
        numerator = a % b;
        whole = a / b;
        return this;
    }

    public static TMixFraction operator +(TMixFraction a, TMixFraction b)
    {
        int a_n = a.numerator + a.denominator * a.whole, b_n = b.numerator + b.denominator * b.whole;
        TMixFraction res = new TMixFraction(
            a_n * b.denominator + a.denominator * b_n,
            a.denominator * b.denominator, 
            0);
        return res.Reduce();
    }
    
    public static TMixFraction operator -(TMixFraction a, TMixFraction b)
    {
        int a_n = a.numerator + a.denominator * a.whole, b_n = b.numerator + b.denominator * b.whole;
        TMixFraction res = new TMixFraction(
            a_n * b.denominator - a.denominator * b_n,
            a.denominator * b.denominator,
            0);
        return res.Reduce();
    }
    
    public static TMixFraction operator *(TMixFraction a, TMixFraction b)
    {
        int a_n = a.numerator + a.denominator * a.whole, b_n = b.numerator + b.denominator * b.whole;
        TMixFraction res = new TMixFraction(
            a_n * b_n,
            a.denominator * b.denominator,
            0);
        return res.Reduce();
    }
    
    public static TMixFraction operator /(TMixFraction a, TMixFraction b)
    {
        int a_n = a.numerator + a.denominator * a.whole, b_n = b.numerator + b.denominator * b.whole;
        TMixFraction res = new TMixFraction(
            a_n * b.denominator,
            a.denominator * b_n,
            0);
        return res.Reduce();
    }
}