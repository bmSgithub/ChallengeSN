using AlborChallenge.Enum;
using AlborChallenge.Interface;

namespace AlborChallenge.Entity
{
    public class Rectangle : Shape, IRectangle
    {
        public int Height { get; set; }

        public Rectangle(int width, int height) : base(ShapeTypeEnum.RECTANGLE, width)
        {
            Height = height;
        }

        public override decimal CalculateArea()
        {
            return Width * Height;
        }

        public override decimal CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }
    }
}
