using AlborChallenge.Enum;
using AlborChallenge.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
