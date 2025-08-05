/*
    Refactorizar la clase aplicando buenas prácticas.
    Implementar una nueva figura Rectangulo.
    Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 */

using AlborChallenge.Enum;
using AlborChallenge.Interface;
using System.Text;

namespace AlborChallenge.Entity
{
    public abstract class Shape : IShape
    {
        public ShapeTypeEnum Type { get; set; }
        public int Width { get; set; }

        public Shape(ShapeTypeEnum type, int width)
        {
            Type = type;
            Width = width;
        }

        public abstract decimal CalculateArea();

        public abstract decimal CalculatePerimeter();

        public static string PrintInformation(List<IShape> shapes)
        {
            var result = new StringBuilder();

            if (shapes != null && shapes.Any())
            {
                foreach(var s in shapes)
                {
                    result.AppendLine($"The shape is a {s.Type}. Area: {Math.Round(s.CalculateArea(), 2)}. Perimeter: {Math.Round(s.CalculatePerimeter(), 2)}");
                }
            }
            else
            {
                throw new Exception("There are no shapes.");
            }

            return result.ToString();
        }
    }
}