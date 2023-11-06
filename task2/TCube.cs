namespace lw4.task2;

public class TCube : TSquare
{
    public TCube() : base(0)
    { }
    
    public TCube(double size) : base(size)
    { }
    
    public TCube(TCube cube) : base(cube.Size)
    { }

    public override double CulcPerimeter()
    {
        return 12 * size;
    }
    
    public override double CulcArea()
    {
        return 6 * size * size;
    }

    public double CulcVolume()
    {
        return size * size * size;
    }

    public static TCube operator +(TCube s1, TCube s2)
    {
        return new TCube(s1.size + s2.size);
    }
    
    public static TCube operator -(TCube s1, TCube s2)
    {
        return new TCube(s1.size - s2.size);
    }
    
    public static TCube operator *(TCube s1, int k)
    {
        return new TCube(s1.size * k);
    }
}