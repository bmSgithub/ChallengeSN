using AlborChallenge.Entity;

namespace AlborChallengeUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestNoShape()
        {
            Assert.Equal("There are no shapes", Shape.PrintInformation(new List<Shape>()));
        }

        [Fact]
        public void TestSquare()
        {
            List<Shape> shapes = new List<Shape>()
            {
                new Shape("Square", 4)
            };
            string result = "The area of the square is : 16 and the perimeter is: 16<br/>";
            Assert.Equal(result, Shape.PrintInformation(shapes));
        }

        [Fact]
        public void TestTwoSquare()
        {
            List<Shape> shapes = new List<Shape>()
            {
                new Shape("Square", 4),
                new Shape("Square", 5)
            };
            string result = "The area of the square is : 16 and the perimeter is: 16<br/>The area of the square is : 25 and the perimeter is: 20<br/>";
            Assert.Equal(result, Shape.PrintInformation(shapes));
        }

        [Fact]
        public void TestManyForms()
        {
            List<Shape> shapes = new List<Shape>()
            {
                new Shape("Square", 4),
                new Shape("Circle", 2),
                new Shape("Square", 5),
                new Shape("EquilateralTriangle", 5),
                new Shape("Circle", 3),
                new Shape("Circle", 2)
            };
            string result = "The area of the square is : 16 and the perimeter is: 16<br/>The area of the circle is : 3,14 and the perimeter is: 6,28<br/>The area of the square is : 25 and the perimeter is: 20<br/>The area of the triangle is : 10,83 and the perimeter is: 15<br/>The area of the circle is : 7,07 and the perimeter is: 9,42<br/>The area of the circle is : 3,14 and the perimeter is: 6,28<br/>";
            Assert.Equal(result, Shape.PrintInformation(shapes));
        }
    }
}