/*
    Refactorizar la clase aplicando buenas prácticas.
    Implementar una nueva figura Rectangulo.
    Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 */

using AlborChallenge.Enum;

namespace AlborChallenge.Entity
{
    public abstract class Shape
    {
        public ShapeTypeEnum Type { get; set; }
        public int Width { get; set; }

        public Shape(ShapeTypeEnum type, int width)
        {
            Type = type;
            Width = width;
        }

        public static string PrintInformation(List<Shape> shapes)
        {
            var result = "";
            if (shapes.Any())
            {
                var sa = 0m; //represents the area of the square
                var ca = 0m; //represents the area of the circle
                var ta = 0m; // represents the area of the triangle
                var squarePerimeter = 0m;
                var circlePerimeter = 0m;
                var trianglePerimeter = 0m;
                for (var i = 0; i < shapes.Count; i++)
                {
                    if (shapes[i].Type == "Square")
                    {
                        sa = shapes[i].CalculateArea();
                        squarePerimeter = shapes[i].CalculatePerimeter();
                        result += "The area of the square is : " + Math.Round(sa, 2) + " and the perimeter is: " + Math.Round(squarePerimeter, 2) + "<br/>";
                    }
                    else if (shapes[i].Type == "Circle")
                    {
                        ca = shapes[i].CalculateArea();
                        circlePerimeter = shapes[i].CalculatePerimeter();
                        result += "The area of the circle is : " + Math.Round(ca, 2) + " and the perimeter is: " + Math.Round(circlePerimeter, 2) + "<br/>";
                    }
                    else if (shapes[i].Type == "EquilateralTriangle")
                    {
                        ta = shapes[i].CalculateArea();
                        trianglePerimeter = shapes[i].CalculatePerimeter();
                        result += "The area of the triangle is : " + Math.Round(ta, 2) + " and the perimeter is: " + Math.Round(trianglePerimeter, 2) + "<br/>";
                    }
                }
            }
            else
                result = "There are no shapes";
            return result;
        }

        public abstract decimal CalculateArea();

        public abstract decimal CalculatePerimeter();
    }
}