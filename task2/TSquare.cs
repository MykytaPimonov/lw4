namespace lw4.task2;

public class TSquare : IEquatable<TSquare>
{
    protected double size;

    public TSquare()
    {
        this.size = 0;
    }

    public TSquare(double size)
    {
        this.size = size;
    }

    public TSquare(TSquare square)
    {
        this.size = square.size;
    }

    public double Size
    {
        get => size;
        set => size = value;
    }
    
    public virtual double CulcPerimeter()
    {
        return 4 * size;
    }
    
    public virtual double CulcArea()
    {
        return size * size;
    }

    public bool Equals(TSquare? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return size.Equals(other.size);
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((TSquare)obj);
    }

    public override int GetHashCode()
    {
        return size.GetHashCode();
    }

    public static TSquare operator +(TSquare s1, TSquare s2)
    {
        return new TSquare(s1.size + s2.size);
    }
    
    public static TSquare operator -(TSquare s1, TSquare s2)
    {
        return new TSquare(s1.size - s2.size);
    }
    
    public static TSquare operator *(TSquare s1, double k)
    {
        return new TSquare(s1.size * k);
    }
}