using AlborChallenge.Enum;
using AlborChallenge.Interface;

namespace AlborChallenge.Entity
{
    public class EquilateralTriangle : Shape, IShape
    {
        public EquilateralTriangle(int width) : base(ShapeTypeEnum.EQUILATERAL_TRIANGLE, width)
        {

        }

        public override decimal CalculateArea()
        {
            return (decimal)Math.Sqrt(3) * Width * Width / 4;
        }

        public override decimal CalculatePerimeter()
        {
            return Width * 3;
        }
    }
}
