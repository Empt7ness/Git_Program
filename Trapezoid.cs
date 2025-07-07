public class Trapezoid : BaseShape
{
    public double Side2 { get; set; }

    public Trapezoid(double side1, double side2, double height) : base(side1, height)
    {
        Side2 = side2;
    }

    public override double GetArea()
    {
        return (Side1 + Side2) * Height / 2;
    }

    public override string GetInfo()
    {
        return $"Трапеція: Сторона1 = {Side1}, Сторона2 = {Side2}, Висота = {Height}";
    }
}
