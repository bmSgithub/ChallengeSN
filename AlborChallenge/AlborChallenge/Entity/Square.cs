using AlborChallenge.Enum;
using AlborChallenge.Interface;

namespace AlborChallenge.Entity
{
    public class Square : Shape, IShape
    {
        public Square(int width) : base(ShapeTypeEnum.SQUARE, width)
        {

        }

        public override decimal CalculateArea()
        {
            return Width * Width;
        }

        public override decimal CalculatePerimeter()
        {
            return Width * 4;
        }
    }
}
