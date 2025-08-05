/*
    Refactorizar la clase aplicando buenas prácticas.
    Implementar una nueva figura Rectangulo.
    Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 */

namespace AlborChallenge
{
    public class Shapes
    {
        public string Type { get; set; }
        public int Width { get; set; }

        public Shapes(string type, int witdh)
        {
            Type = type;
            Width = witdh;
        }

        public static string PrintInformation(List<Shapes> shapes)
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

        public decimal CalculateArea()
        {
            decimal area = 0;
            if (Type == "Square")
            {
                area = Width * Width;
            }
            if (Type == "Circle")
            {
                area = (decimal)Math.PI * (Width / 2m) * (Width / 2m);
            }
            if (Type == "EquilateralTriangle")
                area = ((decimal)Math.Sqrt(3) * Width * Width) / 4;
            return area;
        }

        public decimal CalculatePerimeter()
        {
            decimal perimeter = 0;
            if (Type == "Square")
            {
                perimeter = Width * 4;
            }
            if (Type == "Circle")
            {
                perimeter = (decimal)Math.PI * (Width);
            }
            if (Type == "EquilateralTriangle")
                perimeter = Width * 3;
            return perimeter;
        }
    }
}