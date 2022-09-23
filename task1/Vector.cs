namespace task1;

public struct Vector
{
    private double X;
    private double Y;
    private double Z;

    public Vector(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }
    
    public static Vector operator+ (Vector v1, Vector v2)
    {
        Vector v;
        v.X = v1.X + v2.X;
        v.Y = v1.Y + v2.Y;
        v.Z = v1.Z + v2.Z;

        return v;
    }
    
    public static Vector operator* (Vector v1, Vector v2)
    {
        Vector v;
        v.X = v1.X * v2.X;
        v.Y = v1.Y * v2.Y;
        v.Z = v1.Z * v2.Z;

        return v;
    }
    
    public static Vector operator* (Vector v1, double n)
    {
        Vector v;
        v.X = v1.X * n;
        v.Y = v1.Y * n;
        v.Z = v1.Z * n;

        return v;
    }
    
    public static bool operator== (Vector v1, Vector v2)
    {
        double length1 = Math.Sqrt(Math.Pow(v1.X, 2) + Math.Pow(v1.Y, 2) + Math.Pow(v1.Z, 2));
        double length2 = Math.Sqrt(Math.Pow(v2.X, 2) + Math.Pow(v2.Y, 2) + Math.Pow(v2.Z, 2));

        return (length1 == length2);
    }
    
    public static bool operator!= (Vector v1, Vector v2)
    {
        double length1 = Math.Sqrt(Math.Pow(v1.X, 2) + Math.Pow(v1.Y, 2) + Math.Pow(v1.Z, 2));
        double length2 = Math.Sqrt(Math.Pow(v2.X, 2) + Math.Pow(v2.Y, 2) + Math.Pow(v2.Z, 2));

        return (length1 != length2);
    }
    
    public static bool operator>= (Vector v1, Vector v2)
    {
        double length1 = Math.Sqrt(Math.Pow(v1.X, 2) + Math.Pow(v1.Y, 2) + Math.Pow(v1.Z, 2));
        double length2 = Math.Sqrt(Math.Pow(v2.X, 2) + Math.Pow(v2.Y, 2) + Math.Pow(v2.Z, 2));

        return (length1 >= length2);
    }
    
    public static bool operator<= (Vector v1, Vector v2)
    {
        double length1 = Math.Sqrt(Math.Pow(v1.X, 2) + Math.Pow(v1.Y, 2) + Math.Pow(v1.Z, 2));
        double length2 = Math.Sqrt(Math.Pow(v2.X, 2) + Math.Pow(v2.Y, 2) + Math.Pow(v2.Z, 2));

        return (length1 <= length2);
    }
    
    public static bool operator> (Vector v1, Vector v2)
    {
        double length1 = Math.Sqrt(Math.Pow(v1.X, 2) + Math.Pow(v1.Y, 2) + Math.Pow(v1.Z, 2));
        double length2 = Math.Sqrt(Math.Pow(v2.X, 2) + Math.Pow(v2.Y, 2) + Math.Pow(v2.Z, 2));

        return (length1 > length2);
    }
    
    public static bool operator< (Vector v1, Vector v2)
    {
        double length1 = Math.Sqrt(Math.Pow(v1.X, 2) + Math.Pow(v1.Y, 2) + Math.Pow(v1.Z, 2));
        double length2 = Math.Sqrt(Math.Pow(v2.X, 2) + Math.Pow(v2.Y, 2) + Math.Pow(v2.Z, 2));

        return (length1 < length2);
    }

    public void Print()
    {
        Console.WriteLine($"({X};{Y};{Z})");
    }
}