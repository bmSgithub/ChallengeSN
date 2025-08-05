using AlborChallenge.Enum;

namespace AlborChallenge.Interface
{
    public interface IShape
    {
        ShapeTypeEnum Type { get; set; }

        int Width { get; set; }

        decimal CalculateArea();

        decimal CalculatePerimeter();
    }
}
