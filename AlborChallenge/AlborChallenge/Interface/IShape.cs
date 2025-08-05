using AlborChallenge.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
