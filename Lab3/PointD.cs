using System.Diagnostics;

namespace Lab3;

public struct PointD
{
    private const double EPS = 1.0E-7;
    private const string ERR_MESSAGE1 = "Ошибка: r<0: !!! Замена r на |r| !!! ";
    static Random rnd;

    private double x, y;
    private double r, fi;

    public PointD(double x, double y)
    {
        this.x = x;
        this.y = y;
        r = Math.Sqrt(x * x + y * y);
        fi = Math.Atan2(y, x);
    }

    public PointD(double r, double fi, string tip)
    {
        try
        {
            if (r < 0) throw new PointDException(ERR_MESSAGE1);
            this.r = r;
            this.fi = fi;
            x = r * Math.Cos(fi);
            y = r * Math.Sin(fi);
        }
        catch (PointDException e)
        {
            Debug.WriteLine(e.Message);
            r = -r;
            this.r = r;
            this.fi = fi;
            x = r * Math.Cos(fi);
            y = r * Math.Sin(fi);
        }
    }

    public PointD(double MaxR)
    {
        r = rnd.NextDouble() * MaxR;
        fi = rnd.NextDouble() * Math.PI * 2;
        x = r * Math.Cos(fi);
        y = r * Math.Sin(fi);
    }

    public PointD(int Max)
    {
        x = rnd.Next(Max);
        y = rnd.Next(Max);
        r = Math.Sqrt(x * x + y * y);
        fi = Math.Atan2(y, x);
    }

    public PointD(PointD p)
    {
        this = p;
    }

    static PointD()
    {
        rnd = new Random();
    }


    public void MoveX(double dx)
    {
        x += dx;
        FromDecartToPolar();
    }

    public void MoveY(double dy)
    {
        x += dy;
        FromDecartToPolar();
    }

    public void MoveR(double dr)
    {
        r += dr;
        FromPolarToDecart();
    }

    public void MoveFI(double dfi)
    {
        r += dfi;
        while (fi > Math.PI * 2) fi -= Math.PI * 2;
        while (fi > Math.PI * 2) fi += Math.PI * 2;
        FromPolarToDecart();
    }

    public static bool operator ==(PointD p1, PointD p2)
    {
        return p1.Equals(p2);
    }

    public static bool operator !=(PointD p1, PointD p2)
    {
        return !p1.Equals(p2);
    }

    void FromDecartToPolar()
    {
        r = Math.Sqrt(x * x + y * y);
        fi = Math.Atan2(y, x);
    }

    void FromPolarToDecart()
    {
        x = r * Math.Cos(fi);
        y = r * Math.Sin(fi);
    }
    
    public double X => x;

    public double Y => y;

    public double R => r;

    public double FI => fi;


    public override bool Equals(object point1)
    {
        if (point1.GetType().Name != "PointD") return false;
        PointD p = (PointD)point1;
        return (Math.Abs(this.x - p.x) < EPS) && (Math.Abs(this.y - p.y) < EPS);
    }

    public override int GetHashCode()
    {
        return Convert.ToInt32(r + fi);
    }

    public override string ToString()
    {
        string s = "x = {0}, y = {1}, r = {2}, fi = {3}";
        return String.Format(s, x, y, r, fi);
    }
}