public class Rhombus : BaseShape
{
    public Rhombus(double side1, double height) : base(side1, height){}

    public override string GetInfo()
    {
        return $"Ромб: Сторона = {Side1}, Висота = {Height}";
    }
}
