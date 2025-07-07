public class BaseShape
{
    public double Side1 { get; set; }
    public double Height { get; set; }

    public BaseShape(double side1, double height)
    {
        Side1 = side1;
        Height = height;
    }

    public virtual double GetArea()
    {
        return Side1 * Height;
    }

    public virtual string GetInfo()
    {
        return $"Сторона1 = {Side1}, Висота = {Height}";
    }
}
