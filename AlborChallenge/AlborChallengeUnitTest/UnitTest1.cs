using AlborChallenge.Entity;
using AlborChallenge.Interface;

namespace AlborChallengeUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestNoShape()
        {
            List<IShape> shapes = new();
            var error = Assert.Throws<Exception>(() => Shape.PrintInformation(shapes));
            Assert.Equal("There are no shapes.", error.Message);
        }

        [Fact]
        public void TestSquare()
        {
            List<IShape> shapes = new()
            {
                new Square(4)
            };
            string result = "The shape is a SQUARE. Area: 16. Perimeter: 16<br/>";
            Assert.Equal(result, Shape.PrintInformation(shapes));
        }

        [Fact]
        public void TestCircle()
        {
            List<IShape> shapes = new()
            {
                new Circle(4)
            };
            string result = "The shape is a CIRCLE. Area: 12,57. Perimeter: 12,57<br/>";
            Assert.Equal(result, Shape.PrintInformation(shapes));
        }

        [Fact]
        public void TestEquilateralTriangle()
        {
            List<IShape> shapes = new()
            {
                new EquilateralTriangle(4)
            };
            string result = "The shape is a EQUILATERAL_TRIANGLE. Area: 6,93. Perimeter: 12<br/>";
            Assert.Equal(result, Shape.PrintInformation(shapes));
        }

        [Fact]
        public void TestRectangle()
        {
            List<IShape> shapes = new()
            {
                new Rectangle(4,6)
            };
            string result = "The shape is a RECTANGLE. Area: 24. Perimeter: 20<br/>";
            Assert.Equal(result, Shape.PrintInformation(shapes));
        }

        [Fact]
        public void TestManyForms()
        {
            List<IShape> shapes = new()
            {
                new Square(3),
                new Circle(3),
                new EquilateralTriangle(3),
                new Rectangle(3,5),
                new Square(5),
                new Circle(5),
                new EquilateralTriangle(5),
                new Rectangle(5,7)
            };

            string result = "The shape is a SQUARE. Area: 9. Perimeter: 12<br/>" +
                "The shape is a CIRCLE. Area: 7,07. Perimeter: 9,42<br/>" +
                "The shape is a EQUILATERAL_TRIANGLE. Area: 3,90. Perimeter: 9<br/>" +
                "The shape is a RECTANGLE. Area: 15. Perimeter: 16<br/>" +
                "The shape is a SQUARE. Area: 25. Perimeter: 20<br/>" +
                "The shape is a CIRCLE. Area: 19,63. Perimeter: 15,71<br/>" +
                "The shape is a EQUILATERAL_TRIANGLE. Area: 10,83. Perimeter: 15<br/>" +
                "The shape is a RECTANGLE. Area: 35. Perimeter: 24<br/>";

            Assert.Equal(result, Shape.PrintInformation(shapes));
        }
    }
}