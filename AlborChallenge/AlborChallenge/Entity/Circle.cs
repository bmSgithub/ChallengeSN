using AlborChallenge.Enum;
using AlborChallenge.Interface;

namespace AlborChallenge.Entity
{
    public class Circle : Shape, IShape
    {
        public Circle(int width) : base(ShapeTypeEnum.CIRCLE, width)
        {

        }

        public override decimal CalculateArea()
        {
            return (decimal)Math.PI * (Width / 2m) * (Width / 2m);
        }

        public override decimal CalculatePerimeter()
        {
            return (decimal)Math.PI * Width;
        }
    }
}
